using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Coursework
{
    public partial class add_subject : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";

        public add_subject()
        {
            InitializeComponent();
            if (Session.role_signed_in == "Teacher")
            {
                previous_subject_lbl.Hide();
                previous_subject_textbox.Hide();
                current_subject_lbl.Text = "Subjects";
            }
            else
            {
                current_subject_lbl.Text = "Current subject:";
            }
            this.FormClosed += AddSubjectsClosed;
        }

        private void AddSubjectsClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();

            mainMenuForm.Show();

            this.Hide();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string query = "";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                if (Session.role_signed_in == "Teacher")
                {
                    query = "UPDATE TeachingStaff SET subjects = CONCAT(subjects, ', ', @new_subject) WHERE personId = @personId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@new_subject", current_subject_textbox.Text);
                        command.Parameters.AddWithValue("@personId", Session.id);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    query = "UPDATE Student SET";
                    bool updateRequired = false;

                    if (!string.IsNullOrEmpty(current_subject_textbox.Text))
                    {
                        query += " currentSubjects = CONCAT(currentSubjects, ',', @new_current_subject)";
                        updateRequired = true;
                    }

                    if (!string.IsNullOrEmpty(previous_subject_textbox.Text))
                    {
                        query += (updateRequired ? ", " : "") + " previousSubjects = CONCAT(previousSubjects, ',', @new_previous_subject)";
                        updateRequired = true;
                    }

                    query += " WHERE personId = @personId";

                    if (updateRequired)
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            if (!string.IsNullOrEmpty(current_subject_textbox.Text))
                            {
                                command.Parameters.AddWithValue("@new_current_subject", current_subject_textbox.Text);
                            }

                            if (!string.IsNullOrEmpty(previous_subject_textbox.Text))
                            {
                                command.Parameters.AddWithValue("@new_previous_subject", previous_subject_textbox.Text);
                            }

                            command.Parameters.AddWithValue("@personId", Session.id);
                            command.ExecuteNonQuery();
                        }
                    }
                }


                // Calls the GetNewData
                Program.DataAccessLayer dataAccessLayer = new Program.DataAccessLayer(connectionString);
                List<Person> people = new List<Person>();

                Program.DataAccessLayer.GetNewData(people, dataAccessLayer);

                MessageBox.Show("Subject(s) added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

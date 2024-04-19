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

namespace Coursework
{
    public partial class SignIn : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Khanh\Desktop\C#\Coursework\Coursework\Database1.mdf;Integrated Security=True";

        public SignIn()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();

            signUpForm.Show();

            this.Hide();
        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            string email = emailText.Text;
            string password = passwordText.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Email FROM Person WHERE email = @Email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        string email_selected = Convert.ToString(command.ExecuteScalar());

                        if (email_selected != "")
                        {
                            string query_password = "SELECT Password From Person WHERE email = @Email";

                            using (SqlCommand command_password = new SqlCommand(query_password, connection))
                            {
                                command_password.Parameters.AddWithValue("@Email", email_selected);

                                string database_password = Convert.ToString(command_password.ExecuteScalar());
                                if (database_password != password)
                                {
                                    MessageBox.Show("Wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string query_name = "SELECT Name From Person WHERE email = @Email";

                                    using (SqlCommand command_name = new SqlCommand(query_name, connection))
                                    {
                                        command_name.Parameters.AddWithValue("@Email", email_selected);

                                        Session.name = Convert.ToString(command_name.ExecuteScalar());
                                    }

                                    string query_role = "SELECT Role From Person WHERE email = @Email";

                                    using (SqlCommand command_role = new SqlCommand(query_role, connection))
                                    {
                                        command_role.Parameters.AddWithValue("@Email", email_selected);

                                        Session.role_signed_in = Convert.ToString(command_role.ExecuteScalar());

                                    }
                                    string query_id = "SELECT id From Person WHERE email = @Email";

                                    using (SqlCommand command_role = new SqlCommand(query_id, connection))
                                    {
                                        command_role.Parameters.AddWithValue("@Email", email_selected);

                                        Session.id = Convert.ToString(command_role.ExecuteScalar());

                                        MainMenu mainMenuForm = new MainMenu();

                                        mainMenuForm.Show();

                                        this.Hide();
                                    }
                                    Session.logged_in = true;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("E-mail doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

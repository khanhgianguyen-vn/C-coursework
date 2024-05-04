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
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";


        public SignIn()
        {
            InitializeComponent();

            // Set the border style to fixed
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Sets the maximum and minimum size of the window
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            // Opens up the sign up form if the sign_up_btn is clicked
            SignUp signUpForm = new SignUp();

            signUpForm.Show();

            this.Hide();
        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            // Declares email and password variable
            string email = emailText.Text;
            string password = passwordText.Text;

            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open connection
                    connection.Open();

                    // Building the query
                    string query = "SELECT Email FROM Person WHERE email = @Email";

                    // Creating a command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Inserting email into the query
                        command.Parameters.AddWithValue("@Email", email);

                        // Executing the query and applying the return into the variable email_selected
                        string email_selected = Convert.ToString(command.ExecuteScalar());

                        // Checks if email_selected is not empty
                        if (email_selected != "")
                        {
                            // If the email is in the database then collect the password from that account
                            string query_password = "SELECT Password From Person WHERE email = @Email";

                            // Command to check if the password is correct
                            using (SqlCommand command_password = new SqlCommand(query_password, connection))
                            {
                                // Assigning the email into the query
                                command_password.Parameters.AddWithValue("@Email", email_selected);

                                // Converts the string to a string and assigns it to the database_password variable
                                string database_password = Convert.ToString(command_password.ExecuteScalar());

                                // Checks if the inputted password matches with the password on the database
                                if (database_password != password)
                                {
                                    // Displays an error message if the password is wrong
                                    MessageBox.Show("Wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    // Getting the user's name from the Person table to insert into Session.name
                                    string query_name = "SELECT Name From Person WHERE email = @Email";

                                    using (SqlCommand command_name = new SqlCommand(query_name, connection))
                                    {
                                        // Adding email_selected to the query
                                        command_name.Parameters.AddWithValue("@Email", email_selected);

                                        Session.name = Convert.ToString(command_name.ExecuteScalar());
                                    }

                                    // Getting the user's role from the Person table to assign into Session.role_signed_in
                                    string query_role = "SELECT Role From Person WHERE email = @Email";

                                    using (SqlCommand command_role = new SqlCommand(query_role, connection))
                                    {
                                        // Adding email_selected to the query
                                        command_role.Parameters.AddWithValue("@Email", email_selected);

                                        Session.role_signed_in = Convert.ToString(command_role.ExecuteScalar());

                                    }
                                    // Getting the user's id from the Person table to assign into Session.id
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
                            // Shows an error message if the email doesnt exists
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

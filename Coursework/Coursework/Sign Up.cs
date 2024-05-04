using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class SignUp : Form
    {
        static string currentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..");
        static string fullPath = Path.GetFullPath(currentDirectory);
        public string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath}\Database1.mdf;Integrated Security=True;";

        public SignUp()
        {
            InitializeComponent();
            
            // Setting the window size and not allowing the user to change
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);

            //MessageBox.Show(fullPath);
            this.FormClosed += SignUpClosed;
        }

        // In case the user closes the sign up window
        private void SignUpClosed(object sender, FormClosedEventArgs e)
        {
            // Checks if the user is logged in
            if (Session.logged_in)
            {
                // Shows the main menu
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            }
            else
            {
                // Shows the sign in form
                SignIn signin = new SignIn();
                signin.Show();
            }
        }

        private void PersonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        // Function to show and hide textboxes and labels depending on the selected role when signing up
        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Getting the role from the combobox
            string Role = roleComboBox.Text;

            // A list of all of the label and textboxes related to the selected roles
            List<List<Control>> roleControls = new List<List<Control>>
            {
                new List<Control>{ salary_adminTextBox, fullTimeAdminCheckBox, workingHoursAdminTextBox, adminSalaryLabel, adminFullTimeLabel, adminWorkingHoursLabel},
                new List<Control>{ teacherSalaryTextBox, teacherSalaryLabel, teacherSubjectsTextBox, teacherSubjectsLabel},
                new List<Control>{ currentSubjectsTextBox, previousSubjectsTextBox, currentSubjectsLabel, previousSubjectsLabel}
            };

            // A loop which hides the labels and textboxes written in the list
            foreach (List<Control> controls in roleControls)
            {
                foreach (Control control in controls)
                {
                    control.Hide();
                }
            }

            // Setting the default role as none
            int roleIndex = -1;

            // Switch case for each roles and their respective index
            switch(Role)
            {
                case "Administrator":
                    roleIndex = 0;
                    break;
                case "Teacher":
                    roleIndex = 1;
                    break;
                case "Student":
                    roleIndex = 2;
                    break;
            }

            // An if statement to show labels and textboxes if there is a role selected
            if (roleIndex != -1)
            {
                foreach (Control control in roleControls[roleIndex])
                {
                    control.Show();
                }
            }
        }


        // Encapsulating the query that inserts admins
        private void insert_into_admin(SqlConnection connection, int personId, int salary, bool fullTime, int workingHours)
        {
            // Build query to insert into administration table
            string query = "INSERT INTO [Administration] (PersonId, Salary, FullTime, WorkingHours) VALUES (@person_id, @Salary, @FullTime, @WorkingHours)";
            SqlCommand command_insert_role = new SqlCommand(query, connection);
            command_insert_role.Parameters.AddWithValue("@person_id", personId);
            command_insert_role.Parameters.AddWithValue("@Salary", salary);
            command_insert_role.Parameters.AddWithValue("@FullTime", fullTime);
            command_insert_role.Parameters.AddWithValue("@WorkingHours", workingHours);
            command_insert_role.ExecuteNonQuery();
        }

        // Encapsulating the query that inserts teachers
        private void insert_into_teachingStaff(SqlConnection connection, int personId, decimal salary, string subjects)
        {
            // Build query to insert into teachingstaff table
            string query = "INSERT INTO [TeachingStaff] (PersonId, Salary, Subjects) VALUES (@person_id, @Salary, @Subjects)";
            SqlCommand command_insert_role = new SqlCommand(query, connection);
            command_insert_role.Parameters.AddWithValue("@person_id", personId);
            command_insert_role.Parameters.AddWithValue("@Salary", salary);
            command_insert_role.Parameters.AddWithValue("@Subjects", subjects);
            command_insert_role.ExecuteNonQuery();
        }

        // Encapsulating the query that inserts students
        private void insert_into_student(SqlConnection connection, int personId, string currentSubjects, string previousSubjects)
        {
            // Build query to insert into student table
            string query = "INSERT INTO [Student] (PersonId, currentSubjects, previousSubjects) VALUES (@person_id, @currentSubjects, @previousSubjects)";
            SqlCommand command_insert_role = new SqlCommand(query, connection);
            command_insert_role.Parameters.AddWithValue("@person_id", personId);
            command_insert_role.Parameters.AddWithValue("@currentSubjects", currentSubjects);
            command_insert_role.Parameters.AddWithValue("@previousSubjects", previousSubjects);
            command_insert_role.ExecuteNonQuery();
        }

        public int GetLastPersonId(SqlConnection connection)
        {
            // Getting the last Id from the person table to insert into the UserId column for their respective role
            string query = "SELECT MAX(Id) FROM Person";
            SqlCommand command = new SqlCommand(query, connection);

            // Execute the query and retrieve the inserted ID
            return Convert.ToInt32(command.ExecuteScalar()); // ExecuteScalar function executes the query and then collect the last ID
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Collecting all the inputs from the user
                string Name = nameTextBox.Text;
                string Telephone = telephoneTextBox.Text;
                string Email = emailTextBox.Text;
                string Role = roleComboBox.Text;
                string Password = passwordTextBox.Text;
                string confirmPassword = confirmPasswordTextBox.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Check if role is empty
                    if (Role != "")
                    {
                        // Validate if the user is a teacher or student and has inputted two subjects
                        if ((Role == "Teacher" && teacherSubjectsTextBox.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length == 2) ||
                            ((Role == "Student" && currentSubjectsTextBox.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length == 2) && 
                            (Role == "Student" && previousSubjectsTextBox.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length == 2)) || Role == "Administrator")
                        {
                            // Calling the insert function from SignUpManager.cs
                            if ((salary_adminTextBox.Text != "" && workingHoursAdminTextBox.Text != "") || (teacherSalaryTextBox.Text != "" && teacherSubjectsTextBox.Text != "") || (currentSubjectsTextBox.Text != "" && previousSubjectsTextBox.Text != ""))
                            {
                                UserSignUpManager signUpManager = new UserSignUpManager(connectionString);
                                bool signUpSuccess = signUpManager.SignUpUser(nameTextBox.Text, telephoneTextBox.Text,
                                    emailTextBox.Text, roleComboBox.Text, passwordTextBox.Text,
                                    confirmPasswordTextBox.Text);

                                if (signUpSuccess)
                                {
                                    connection.Open();

                                    int personId = GetLastPersonId(connection);

                                    Person newPerson = new Person();
                                    newPerson.Name = Name;
                                    newPerson.Telephone = Telephone;
                                    newPerson.Email = Email;
                                    newPerson.Role = Role;
                                    newPerson.Password = Password;

                                    // Retrieve values from visible controls based on the selected role
                                    // Separating which info and which table will be sent into the database
                                    if (Role == "Administrator")
                                    {
                                        Administrator newAdmin = new Administrator();
                                        newAdmin.PersonId = personId;
                                        newAdmin.Salary = Convert.ToInt32(salary_adminTextBox.Text);
                                        newAdmin.FullTime = fullTimeAdminCheckBox.Checked;
                                        newAdmin.WorkingHours = Convert.ToInt32(workingHoursAdminTextBox.Text);

                                        insert_into_admin(connection, newAdmin.PersonId, newAdmin.Salary, newAdmin.FullTime, newAdmin.WorkingHours);
                                    }
                                    if (Role == "Teacher")
                                    {
                                        TeachingStaff newTeacher = new TeachingStaff();
                                        newTeacher.PersonId = personId;
                                        newTeacher.Salary = Convert.ToInt32(teacherSalaryTextBox.Text);
                                        newTeacher.Subjects = teacherSubjectsTextBox.Text;

                                        insert_into_teachingStaff(connection, newTeacher.PersonId, newTeacher.Salary, newTeacher.Subjects);
                                    }
                                    if (Role == "Student")
                                    {
                                        Student newStudent = new Student();
                                        newStudent.PersonId = personId;
                                        newStudent.CurrentSubjects = currentSubjectsTextBox.Text;
                                        newStudent.PreviousSubjects = previousSubjectsTextBox.Text;

                                        insert_into_student(connection, newStudent.PersonId, newStudent.CurrentSubjects, newStudent.PreviousSubjects);
                                    }

                                    // Checks if the user is logged in (administrators reuses this sign up code)
                                    if (Session.logged_in)
                                    {
                                        // Popup message informing the user
                                        MessageBox.Show("New person added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        MainMenu mainMenu = new MainMenu();
                                        mainMenu.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        // Popup message informing the user
                                        MessageBox.Show("Signed up successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        SignIn signInForm = new SignIn();
                                        signInForm.Show();

                                        this.Hide();
                                    }
                                    // Calls the GetNewData
                                    Program.DataAccessLayer dataAccessLayer = new Program.DataAccessLayer(connectionString);
                                    List<Person> people = new List<Person>();

                                    Program.DataAccessLayer.GetNewData(people, dataAccessLayer);
                                }
                            }
                            else
                            {
                                // Error message telling the user to input all boxes
                                MessageBox.Show("Error occured: Please fill out all the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            // Error message telling the user to input two subjects
                            MessageBox.Show("Please input two subjects.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        // Error message informing the user that the role box can not be empty
                        MessageBox.Show("Role can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
            catch (Exception ex)
            {
                // Error message informing the user of other errors
                MessageBox.Show("Error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clicking on the logo
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Checks if the user is logged in
            if (Session.logged_in)
            {
                // Shows the mainMenuForm
                MainMenu mainMenuForm = new MainMenu();

                mainMenuForm.Show();

                this.Hide();
            }
            // if the user is not logged in
            else
            {
                // Shows the sign in form
                SignIn signInForm = new SignIn();

                signInForm.Show();

                this.Hide();
            }
        }
    }
}

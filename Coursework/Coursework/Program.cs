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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
        }

        // Creating a constructor collecting the data from the sql database
        public class DataAccessLayer
        {
            private string connectionString;

            public DataAccessLayer(string connectionString)
            {
                this.connectionString = connectionString;
            }

            // Creating a list and collecting all data from all tables
            public List<Person> GetAllPeople()
            {
                List<Person> people = new List<Person>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open a connection
                    connection.Open();
                    string query = "SELECT * FROM Person";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // While loop reading what's in the table person
                    while (reader.Read())
                    {
                        // Gets all the data from person table
                        string role = reader["Role"].ToString();
                        int personId = Convert.ToInt32(reader["Id"]);
                        string name = reader["Name"].ToString();
                        string telephone = reader["Telephone"].ToString();
                        string email = reader["Email"].ToString();
                        string password = reader["Password"].ToString();

                        // Checks if the role is Admin
                        if (role == "Administrator")
                        {
                            // Collecting data then assign them
                            Administrator admin = new Administrator();
                            admin.Id = personId;
                            admin.Name = name;
                            admin.Telephone = telephone;
                            admin.Email = email;
                            admin.Password = password;
                            admin.Role = role;

                            using (SqlConnection adminConnection = new SqlConnection(connectionString))
                            {
                                // Collecting all data from Administration table
                                adminConnection.Open();
                                string adminQuery = "SELECT * FROM Administration WHERE PersonId = @PersonId";
                                SqlCommand adminCommand = new SqlCommand(adminQuery, adminConnection);
                                adminCommand.Parameters.AddWithValue("@PersonId", personId);
                                SqlDataReader adminReader = adminCommand.ExecuteReader();

                                if (adminReader.Read())
                                {
                                    admin.FullTime = Convert.ToBoolean(adminReader["FullTime"]);
                                    admin.WorkingHours = Convert.ToInt32(adminReader["WorkingHours"]);
                                    admin.Salary = Convert.ToInt32(adminReader["Salary"]);
                                    admin.PersonId = personId;
                                }
                            }

                            // Add into people's list
                            people.Add(admin);
                        }
                        else if (role == "Teacher")
                        {
                            TeachingStaff teacher = new TeachingStaff();
                            teacher.Id = personId;
                            teacher.Name = name;
                            teacher.Telephone = telephone;
                            teacher.Email = email;
                            teacher.Password = password;
                            teacher.Role = role;

                            // Collecting all data from TeachingStaff table
                            using (SqlConnection teacherConnection = new SqlConnection(connectionString))
                            {
                                teacherConnection.Open();
                                string teacherQuery = "SELECT * FROM TeachingStaff WHERE PersonId = @PersonId";
                                SqlCommand teacherCommand = new SqlCommand(teacherQuery, teacherConnection);
                                teacherCommand.Parameters.AddWithValue("@PersonId", personId);
                                SqlDataReader teacherReader = teacherCommand.ExecuteReader();

                                if (teacherReader.Read())
                                {
                                    teacher.Salary = Convert.ToDecimal(teacherReader["Salary"]);
                                    teacher.Subjects = teacherReader["Subjects"].ToString();
                                    teacher.PersonId = personId;
                                }
                            }

                            // Add into people's table
                            people.Add(teacher);
                        }
                        else if (role == "Student")
                        {
                            Student student = new Student();
                            student.Id = personId;
                            student.Name = name;
                            student.Telephone = telephone;
                            student.Email = email;
                            student.Password = password;
                            student.Role = role;

                            using (SqlConnection studentConnection = new SqlConnection(connectionString))
                            {
                                studentConnection.Open();
                                string studentQuery = "SELECT * FROM Student WHERE PersonId = @PersonId";
                                SqlCommand studentCommand = new SqlCommand(studentQuery, studentConnection);
                                studentCommand.Parameters.AddWithValue("@PersonId", personId);
                                SqlDataReader studentReader = studentCommand.ExecuteReader();

                                if (studentReader.Read())
                                {
                                    student.CurrentSubjects = studentReader["CurrentSubjects"].ToString();
                                    student.PreviousSubjects = studentReader["PreviousSubjects"].ToString();
                                    student.PersonId = personId;
                                }
                            }

                            people.Add(student);
                        }
                    }

                    reader.Close();
                }

                return people;
            }
            
            // A function that deletes all the data from the list and then gets new data from the database
            public static void GetNewData(List<Person> people, Program.DataAccessLayer dataAccessLayer)
            {
                // Delete all current data
                for (int i = people.Count - 1; i >= 0; i--)
                {
                    people.RemoveAt(i);
                }

                // Retrieve new data from the database
                List<Person> newData = dataAccessLayer.GetAllPeople();

                // Add the new data to the existing list
                people.AddRange(newData);
            }
        }
    }
}

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

    public partial class MainMenu : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Khanh\Desktop\C#\Coursework\Coursework\Database1.mdf;Integrated Security=True";

        public string Role = Session.role_signed_in;

        public MainMenu()
        {
            // Inserts the name saved in the session into a public variable
            string Name = Session.name;
            InitializeComponent();

            // Text welcoming the user
            mainMenu_lbl.Text = "Welcome " + Name + "!";
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;

            // Window size modifications
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximumSize = new System.Drawing.Size(1122, 663);
            this.MinimumSize = new System.Drawing.Size(1122, 663);
        }

        // Function to hide all the functions associated with dataGridView
        private void dataGridViewHide()
        {
            dataGridView.Hide();
            search_lbl.Hide();
            search_textbox.Hide();
            search_btn.Hide();
            role_lbl.Hide();
            roleComboBox.Hide();
            ascending_btn.Hide();
            descending_btn.Hide();
            delete_btn.Hide();
        }

        // Function to show all the functions associated with dataGridView
        private void dataGridViewShow()
        {
            search_lbl.Show();
            search_textbox.Show();
            search_btn.Show();
            role_lbl.Show();
            roleComboBox.Show();
            ascending_btn.Show();
            descending_btn.Show();
            delete_btn.Show();

            // Checks if the role is student, if it is then hide everything but the dataGridView table
            if (Role == "Student")
            {
                search_lbl.Hide();
                search_textbox.Hide();
                search_btn.Hide();
                role_lbl.Hide();
                roleComboBox.Hide();
                ascending_btn.Hide();
                descending_btn.Hide();
                delete_btn.Hide();
            }
        }

        // Function to add to the ComboBox
        private string addToComboBox()
        {
            // Clear the combobox first
            roleComboBox.Items.Clear();
            string query = "";

            if (Role != "Student")
            {
                if (Role == "Administrator")
                {
                    query = "SELECT p.Id, p.Name, p.Telephone, p.Email, p.Role, " +
                       "CASE " +
                       "WHEN p.Role = 'Teacher' THEN t.salary " +
                       "ELSE NULL " +
                       "END AS Salary, " +
                       "CASE " +
                       "WHEN p.Role = 'Student' THEN s.currentSubjects " +
                       "ELSE NULL " +
                       "END AS CurrentSubjects " +
                       "FROM Person p " +
                       "LEFT JOIN TeachingStaff t ON p.Id = t.PersonId " +
                       "LEFT JOIN Student s ON p.Id = s.PersonId;";

                    string[] itemsToAdd = { "All", "Administrator", "Teacher", "Student" };
                    roleComboBox.Items.AddRange(itemsToAdd);
                }
                if (Role == "Teacher")
                {
                    query = "SELECT e.Id, d.Name, e.Subjects FROM TeachingStaff e INNER JOIN Person d ON e.PersonId = d.Id";

                    string[] itemsToAdd = { "Teacher", "Student" };
                    roleComboBox.Items.AddRange(itemsToAdd);
                }
            }
            return query;
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            string query = addToComboBox();
            dataGridViewShow();

            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (Role == "Student")
                    {
                        string id = Session.id;
                        query = "SELECT * FROM Student WHERE PersonId = @personId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@personId", id);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    else
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                dataGridView.Show();
                dataGridView.DataSource = dataTable;
                mainMenu_lbl.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();

            signInForm.Show();

            this.Hide();

            Session.role_signed_in = "";
            Session.name = "";
            Session.logged_in = false;
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Today;
            string formattedDate = currentDateTime.ToString("dd-MM-yyyy");
            mainMenu_lbl.Text = "Current Date: " + formattedDate;
            dataGridViewHide();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string search_query = search_textbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(search_query))
            {
                MessageBox.Show("Please enter a search query.");
                return;
            }

            string query = "";

            // Check if the user is an admin
            if (Role == "Administrator")
            {
                // Allow administrators to search for anyone
                query = "SELECT p.Id, p.Name, p.Telephone, p.Email, p.Role, " +
                        "CASE " +
                        "WHEN p.Role = 'Teacher' THEN t.salary " +
                        "ELSE NULL " +
                        "END AS Salary, " +
                        "CASE " +
                        "WHEN p.Role = 'Student' THEN s.currentSubjects " +
                        "ELSE NULL " +
                        "END AS CurrentSubjects " +
                        "FROM Person p " +
                        "LEFT JOIN TeachingStaff t ON p.Id = t.PersonId " +
                        "LEFT JOIN Student s ON p.Id = s.PersonId " +
                        $"WHERE p.Name LIKE '%{search_query}%' OR p.Email LIKE '%{search_query}%' " +
                        $"OR t.salary LIKE '%{search_query}%' OR s.currentSubjects LIKE '%{search_query}%';";
            }
            else if (Role == "Teacher")
            {
                // Allow teachers to search for other teachers and students
                query = "SELECT p.Id, p.Name, p.Telephone, p.Email, p.Role, " +
                        "CASE " +
                        "WHEN p.Role = 'Teacher' THEN t.salary " +
                        "ELSE NULL " +
                        "END AS Salary, " +
                        "CASE " +
                        "WHEN p.Role = 'Student' THEN s.currentSubjects " +
                        "ELSE NULL " +
                        "END AS CurrentSubjects " +
                        "FROM Person p " +
                        "LEFT JOIN TeachingStaff t ON p.Id = t.PersonId " +
                        "LEFT JOIN Student s ON p.Id = s.PersonId " +
                        $"WHERE (p.Role = 'Teacher' OR p.Role = 'Student') AND (p.Name LIKE '%{search_query}%' OR p.Email LIKE '%{search_query}%') OR s.currentSubjects LIKE '%{search_query}%';";
            }

            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                dataGridView.Show();
                dataGridView.DataSource = dataTable;
                mainMenu_lbl.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "";
            if (roleComboBox.Text == "All")
            {
                query = "SELECT p.Id, p.Name, p.Telephone, p.Email, p.Role, p.Password, " +
                       "CASE " +
                       "WHEN p.Role = 'Teacher' THEN t.salary " +
                       "ELSE NULL " +
                       "END AS Salary, " +
                       "CASE " +
                       "WHEN p.Role = 'Student' THEN s.currentSubjects " +
                       "ELSE NULL " +
                       "END AS CurrentSubjects " +
                       "FROM Person p " +
                       "LEFT JOIN TeachingStaff t ON p.Id = t.PersonId " +
                       "LEFT JOIN Student s ON p.Id = s.PersonId;";
            }
            if (roleComboBox.Text == "Administrator")
            {
                query = "SELECT A.*, P.Name FROM Administration A LEFT JOIN Person P ON A.PersonId = P.Id";
            }
            if (roleComboBox.Text == "Teacher")
            {
                query = "SELECT TS.*, P.Name FROM TeachingStaff TS LEFT JOIN Person P ON TS.PersonId = P.Id";
            }
            if (roleComboBox.Text == "Student")
            {
                query = "SELECT S.*, P.Name FROM Student S LEFT JOIN Person P ON S.PersonId = P.Id";
            }

            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                dataGridView.Show();
                dataGridView.DataSource = dataTable;
                mainMenu_lbl.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ascending_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView.DataSource != null && dataGridView.Rows.Count > 0)
            {
                // Get the column to sort by
                string columnName = dataGridView.Columns[0].Name; // Sorts by ID

                // Sort the data in ascending order based on the selected column
                ((DataTable)dataGridView.DataSource).DefaultView.Sort = columnName + " ASC";
            }
        }

        private void descending_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView.DataSource != null && dataGridView.Rows.Count > 0)
            {
                // Get the column to sort by
                string columnName = dataGridView.Columns[0].Name; // Sorts by ID

                // Sort the data in descending order based on the selected column
                ((DataTable)dataGridView.DataSource).DefaultView.Sort = columnName + " DESC";
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (Role == "Administrator")
            {
                SignUp signUpForm = new SignUp();
                signUpForm.Show();
                this.Hide();
            }
            else
            {
                add_subject add_SubjectForm = new add_subject();
                add_SubjectForm.Show();
                this.Hide();
            }
        }



        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataGridView dataGridView = (DataGridView)sender;

                    // Get the column name and the new value of the cell being edited
                    string columnName = dataGridView.Columns[e.ColumnIndex].Name;
                    string newValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    // Assuming the first column contains the primary key/id
                    string primaryKey = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                    // Determine the table and column name based on the DataGridView column name
                    string tableName = GetTableNameFromColumnName(columnName);

                    if (tableName == null)
                    {
                        MessageBox.Show("You don't have permission to change this.");
                        return;
                    }

                    // Build the UPDATE query
                    string query = $"UPDATE {tableName} SET {columnName} = @newValue WHERE Id = @primaryKey";

                    // Execute the UPDATE query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@newValue", newValue);
                        command.Parameters.AddWithValue("@primaryKey", primaryKey);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }

        // Method to determine the table name based on the column name
        private string GetTableNameFromColumnName(string columnName)
        {
            switch (columnName)
            {
                case "Name":
                    return "Person";
                case "Telephone":
                    return "Person";
                case "Email":
                    return "Person";
                case "Salary":
                    return "TeachingStaff";
                case "CurrentSubjects":
                    return "Student";
                case "previousSubjects":
                    return "Student";
                case "FullTime":
                    return "Administrator";
                // Add cases for other column names from different tables as needed
                default:
                    return null;
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string tableName = "";
            string role = "";
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Prompt the user with a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Get values from the selected row
                        DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                        // Extract values from each cell of the selected row
                        string id = "";

                        // Check if the personId column exists in the DataGridView
                        if (dataGridView.Columns.Contains("personId"))
                        {
                            DataGridViewCell personIdCell = selectedRow.Cells["personId"];
                            if (personIdCell != null && personIdCell.Value != null)
                            {
                                id = personIdCell.Value.ToString();
                            }
                        }
                        // If personId column doesn't exist, use the Id column
                        else if (dataGridView.Columns.Contains("Id"))
                        {
                            DataGridViewCell idCell = selectedRow.Cells["Id"];
                            if (idCell != null && idCell.Value != null)
                            {
                                id = idCell.Value.ToString();
                            }
                        }

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            // Build the UPDATE query
                            string query = "SELECT Role FROM Person WHERE Id = @personId";

                            // Execute the UPDATE query
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@personId", id);
                                role = Convert.ToString(command.ExecuteScalar());
                            }
                        }
                            

                        switch (role)
                        {
                            case "Administrator":
                                tableName = "Administration";
                                break;
                            case "Teacher":
                                tableName = "TeachingStaff";
                                break;
                            case "Student":
                                tableName = "Student";
                                break;
                        }

                        // Building the first DELETE query
                        string query1 = $"DELETE FROM {tableName} WHERE personId = @id";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query1, connection))
                            {
                                command.Parameters.AddWithValue("@id", id);
                                command.ExecuteNonQuery();
                            }
                        }

                        // Building the second DELETE query
                        string query2 = "DELETE FROM Person WHERE Id = @id";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query2, connection))
                            {
                                command.Parameters.AddWithValue("@id", id);
                                command.ExecuteNonQuery();
                            }
                        }
                        // Remove the selected row from the DataGridView
                        dataGridView.Rows.RemoveAt(selectedRow.Index);

                        MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace CarStoreApp
{
    public partial class RegisterForm : Form
    {
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtUsername;
        private TextBox txtNIC;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblUsername;
        private Label lblNIC;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblAddress;
        private Button btnRegister;
        private Button btnCancel;
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string nic = txtNIC.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;


            // Insert into database
            string connectionString = "Data Source=DESKTOP-SFJGOEO\\SQLEXPRESS;Initial Catalog=CarStoreDB;Integrated Security=True;Encrypt=False";




            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(nic))
            {
                MessageBox.Show("NIC is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                MessageBox.Show("A valid Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(phone) || !IsValidPhoneNumber(phone))
            {
                MessageBox.Show("A valid Phone number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Customer (FirstName, LastName, Username, NIC, Password, Email, Phone, Address) " +
                                "VALUES (@FirstName, @LastName, @Username, @NIC, @Password, @Email, @Phone, @Address)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@NIC", nic);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Address", address);


                        connection.Open();
                        int rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //close customer register window
                            this.Close();
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL exceptions
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


        // Helper method to validate phone number format (basic example)
        private bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length >= 7 && phone.Length <= 15;
        }






        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //close customer register window
            this.Close();
        }
    }
}

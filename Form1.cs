using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shahid
{
    public partial class SignUpForm : Form
    {

        public SignUpForm()
        {
            InitializeComponent();
        }


        private void SignUpForm_Load(object sender, EventArgs e)
        {
            DataBase.conn.Close();
            DataBase.conn.Open();
        }

      

        private void SignUpForm_Close(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter your first and last name.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain a digit and a special character.");
                return;
            }

            try
            {
                DataBase.Add_user(firstName, lastName, email, password);
                MessageBox.Show("register succeeded");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create user account. Error: {ex.Message}");
            }

        }

        static bool IsValidPassword(string password)
        {
            // Define a regular expression for password validation
            string pattern = @"^(?=.*[0-9])(?=.*[!@#$%^&*])[A-Za-z0-9!@#$%^&*]{8,}$";

            // Create Regex instance
            Regex regex = new Regex(pattern);

            // Check if the password matches the pattern
            return regex.IsMatch(password);
        }

        static bool IsValidEmail(string email)
        {
            // Define a regular expression for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkGray;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Shahid.LoginForm login = new LoginForm();
            login.Show();
            Visible = false;
        }
    }
}

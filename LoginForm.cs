using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shahid
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            DataBase.conn.Close();
            DataBase.conn.Open();
        }
        public static int user_id = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string enteredMail = LogInEmailTextBox.Text;
            string enteredPass = LogInPasswordTextBox.Text;
            bool isAccountCorrect = DataBase.CheckAccount(enteredMail, enteredPass);
            if (enteredMail == "admin" && enteredPass == "admin")
            {

                AdminForm Form = new AdminForm();
                Form.Show();
                Visible = false;

            }
            
            else if (isAccountCorrect)
            {
                user_id = DataBase.GetUserId(enteredMail);
                UserMainMenu menu = new UserMainMenu();
                menu.Show();
                Visible = false; 

            }
            else
                CheckAccountLabel.Text = "E-mail or password are incorrect";
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }
    }
}

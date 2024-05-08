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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }
        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            DataBase.conn.Close();
            DataBase.conn.Open();
        }

        private void WelcomeSignUpButton_Click(object sender, EventArgs e)
        {
            Shahid.SignUpForm sign_up = new SignUpForm();
            sign_up.Show();
            Visible = false;
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }

        private void WelcomeLogInButton_Click(object sender, EventArgs e)
        {
            Shahid.LoginForm welcome_log = new LoginForm();
            welcome_log.Show();
            Visible = false;
        }
    }
}

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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        

        private void Settings_Load(object sender, EventArgs e)
        {
            DataBase.conn.Close();
            DataBase.conn.Open();
            Shahid.UserMainMenu.User U = DataBase.Retrive_User_Info(Shahid.LoginForm.user_id);
            SettingsNameTextBox.Text = U.first_name + " " + U.last_name;
            SettingsEmailTextBox.Text = U.email;
            SettingsCurrentPasswordTextBox.Text = U.password ;

        }
        private void SettingsChangePasswordButton_Click(object sender, EventArgs e)
        {
            string new_password = SettingsNewPasswordTextBox.Text;
            DataBase.Save_Password(Shahid.LoginForm.user_id, new_password);
            SettingsCurrentPasswordTextBox.Text = new_password;
            SettingsNewPasswordTextBox.Text = "";
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }

        private void SettingsEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SettingsMainMenuButton_Click(object sender, EventArgs e)
        {
            Shahid.UserMainMenu mainmenu = new UserMainMenu();
            mainmenu.Show();
            Visible = false;
        }
    }
}

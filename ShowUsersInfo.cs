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
    public partial class ShowUsersInfo : Form
    {
        public static List<Shahid.UserMainMenu.User> AllUsers = new List<UserMainMenu.User>();
        public ShowUsersInfo()
        {
            InitializeComponent();
        }
        private void ShowUsersInfo_Load(object sender, EventArgs e)
        {
            DataBase.conn.Close();
            DataBase.conn.Open();
            PrintUserInRichBox();
        }

        private void AllUsersRichBox_TextChanged(object sender, EventArgs e)
        {


        }
        public  void PrintUserInRichBox()
        {
            int counter = 0;
            AllUsersRichBox.Text = "";
            foreach (Shahid.UserMainMenu.User user in AllUsers)
            {
                counter++;

                AllUsersRichBox.Text += counter + " - " + user.user_id + "                    " + user.first_name + "                    " + user.last_name + "                    " + user.email + "                    " + user.password + "                    " + "\n\n\n\n\n\n";


            }
        }

       

        private void ShowUsersInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }
    }
}

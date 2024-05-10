using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Shahid
{
    public partial class DispalyVideoForm : Form
    {
        public static Shahid.UserMainMenu.video video3;
        public DispalyVideoForm()
        {
            InitializeComponent();
        }

        private void DispalyVideoForm_Load(object sender, EventArgs e)
        {
            DataBase.conn.Close();
            DataBase.conn.Open();
            UserMainMenu.DisplayVideo(video3.URL, axWindowsMediaPlayer3);         

        }


        private void DispalyVideoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }

        private void ShowDisplayVidDetailsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(video3.Video_Name))
            {
                string name = "video_name = " + video3.Video_Name + "\n";
                string type = "" + video3.Video_Type + "\n";
                string age_allowed = "+" + video3.Age_Allowed + "\n";
                string description = "Description : " + video3.description + "\n";
                string watches = "Views = " + video3.views + "\n";
                DisplayedVideoRichBox.Text = name + type + age_allowed + description + watches;
            }
                
        }

        private void RateDisplayedVideoButton_Click(object sender, EventArgs e)
        {
            int user_id = Shahid.LoginForm.user_id;
            int video_id = video3.VideoId;
            try
            {
                int rate = Convert.ToInt32(DisplayedVidTextBox.Text);
                DataBase.AddRate(user_id, video_id, rate);
            }
            catch
            {
                MessageBox.Show("invalid rating");
            }
            
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            Shahid.UserMainMenu mainmenu = new UserMainMenu();
            mainmenu.Show();
            //Brilliant Move
            UserMainMenu.DisplayVideo("", axWindowsMediaPlayer3);
            Visible = false;
        }

        private void AddDisplayedVideoToFavoriteListButton_Click(object sender, EventArgs e)
        {
            int user_id = Shahid.LoginForm.user_id;
            int video_id = video3.VideoId;
            DataBase.AddToFavoriteList(user_id, video_id);
        }

        private void AddDisplayedVidToWatchLaterButton_Click(object sender, EventArgs e)
        {
            int user_id = Shahid.LoginForm.user_id;
            int video_id = video3.VideoId;
            DataBase.AddToWatchLaterList(user_id, video_id);
        }
    }
}

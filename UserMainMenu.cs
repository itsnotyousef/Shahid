using AxWMPLib;
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
using Shahid;

namespace Shahid
{
    public partial class UserMainMenu : Form
    {

        public UserMainMenu()
        {
            InitializeComponent();
        }
        private void UserMainMenu_Load(object sender, EventArgs e)
        {
            DataBase.conn.Close();

            DataBase.conn.Open();
        }
       

        public struct video
        {
            public int VideoId;

            public string Video_Name;
            public string Video_Type;
            public int Age_Allowed;
            public string description;
            public string URL;
            public int views;
            public int rate;

        }
        public struct User
        {
            public int user_id;
            public string first_name;
            public string last_name;
            public string email;
            public string password;
        }

        public video video1;
        public video video2;
        private void button2_Click(object sender, EventArgs e)
        {
            Shahid.ShowLists.Favorite_Videos_Names.Clear();
            Shahid.ShowLists.Watch_Later_Videos_Names.Clear();
            DataBase.Get_Favorite_Names(Shahid.LoginForm.user_id);
            DataBase.Get_Watch_Later_Names(Shahid.LoginForm.user_id);
            Shahid.ShowLists list = new ShowLists();
            list.Show();
            Visible = false;
           

        }
        public static void DisplayVideo(string URL, AxWindowsMediaPlayer VideoPlayer) 
        {
            VideoPlayer.URL = URL;
        }

        private void PlayVideoOneButton_Click(object sender, EventArgs e)
        {
            video1 = DataBase.Retrive_Video((Int32)(5));
            DisplayVideo(video1.URL , axWindowsMediaPlayer1);
        }

        private void PlayVideoTwoButton_Click(object sender, EventArgs e)
        {
            video2 = DataBase.Retrive_Video((Int32)(6));
            DisplayVideo(video2.URL , axWindowsMediaPlayer2);
        }

        private void AddVideoOneRateButton_Click(object sender, EventArgs e)
        {
            int user_id = Shahid.LoginForm.user_id;
            int video_id = video1.VideoId;
            int rate = Convert.ToInt32(RatingVidOneTextBox.Text);
            DataBase.AddRate(user_id, video_id, rate);
        }

        private void AddVideoTwoRateButton_Click(object sender, EventArgs e)
        {
            int user_id = Shahid.LoginForm.user_id;
            int video_id = video2.VideoId;
            int rate = Convert.ToInt32(RatingVidTwoTextBox.Text);
            DataBase.AddRate(user_id, video_id, rate);
        }

       

        private void AddVideoOneToFavoriteListButton_Click(object sender, EventArgs e)
        {
            int user_id = Shahid.LoginForm.user_id;
            int video_id = 1;
            DataBase.AddToFavoriteList(user_id, video_id);
        }

        private void AddVideoTwoToFavoriteListButton_Click(object sender, EventArgs e)
        {
            int user_id = Shahid.LoginForm.user_id;
            int video_id = 2;
            DataBase.AddToFavoriteList(user_id, video_id);
        }

        private void AddVideoOneToWatchLaterButton_Click(object sender, EventArgs e)
        {
            int user_id = Shahid.LoginForm.user_id;
            int video_id = 1;
            DataBase.AddToWatchLaterList(user_id, video_id);
        }

        private void AddVideoTwoToWatchLaterButton_Click(object sender, EventArgs e)
        {
            int user_id = Shahid.LoginForm.user_id;
            int video_id = 2;
            DataBase.AddToWatchLaterList(user_id, video_id);
        }
       

        private void ShowVideoOneDetailsButton_Click(object sender, EventArgs e)
        {
            string name = "video_name = "+video1.Video_Name + "\n";
            string type = "--" + video1.Video_Type +"--" + "\n";
            string age_allowed = "+"+video1.Age_Allowed + "\n";
            string description = "Description : " + video1.description + "\n";
            string watches = "Views = " + video1.views + "\n";
            richTextBox1.Text = name + type + age_allowed + description + watches;
        }

        private void ShowVideoTwoDetailsButton_Click(object sender, EventArgs e)
        {
            string name = "video_name = " + video2.Video_Name + "\n";
            string type = "" + video2.Video_Type + "\n";
            string age_allowed = "+" + video2.Age_Allowed + "\n";
            string description = "Description : " + video2.description + "\n";
            string watches = "Views = " + video2.views + "\n";
            richTextBox2.Text = name + type + age_allowed + description + watches;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

         private void UserMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }

        private void SearchVideoButton_Click(object sender, EventArgs e)
        {
            string video_name = SearchVideoTextBox.Text;
            int video_id = DataBase.GetVideoId(video_name);
            Shahid.DispalyVideoForm.video3 = DataBase.Retrive_Video(video_id);
            Shahid.DispalyVideoForm DisplayForm = new DispalyVideoForm();
            UserMainMenu.DisplayVideo("", axWindowsMediaPlayer2);
            UserMainMenu.DisplayVideo("", axWindowsMediaPlayer1);
            DisplayForm.Show();
            Visible = false;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Shahid.WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            Visible = false;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Shahid.Settings redirect = new Settings();
            redirect.Show();
            Visible = false;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

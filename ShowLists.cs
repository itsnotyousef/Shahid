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
    public partial class ShowLists : Form
    {
        public static List<string> Favorite_Videos_Names = new List<string>();
        public static List<string> Watch_Later_Videos_Names = new List<string>();
        public ShowLists()
        {
            InitializeComponent();
        }

        private void ShowLists_Load(object sender, EventArgs e)
        {
            FillWatchLaterList();
            FillFavoriteList();
            DataBase.conn.Close();
            DataBase.conn.Open();
            
        }
        public void FillFavoriteList() 
        {
            //Console.WriteLine("fill here " + Shahid.ShowLists.Favorite_Videos_Names.Count.ToString());
            int counter = 0;
            foreach (string name in Shahid.ShowLists.Favorite_Videos_Names) 
            {
                counter++;
                richTextBox2.Text += counter.ToString() + " - " + name + "\n"; 

            
            }
        
        
        }
        public void FillWatchLaterList() 
        {
            int counter = 0;
            foreach (string name in Shahid.ShowLists.Watch_Later_Videos_Names)
            {
                counter++;
                richTextBox1.Text += counter.ToString() + " - " + name + "\n";


            }

        }

        private void ShowLists_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListsMainMenuButton_Click(object sender, EventArgs e)
        {
            Shahid.UserMainMenu mainmenu = new UserMainMenu();
            mainmenu.Show();
            //Brilliant Move
            Visible = false;
        }

        private void SearchingByVideoName_Click(object sender, EventArgs e)
        {
            string video_name = SearchVidShowListTextBox.Text;
            int video_id = DataBase.GetVideoId(video_name);
            Shahid.DispalyVideoForm.video3 = DataBase.Retrive_Video(video_id);
            Shahid.DispalyVideoForm DisplayForm = new DispalyVideoForm();
            DisplayForm.Show();
            Visible = false;
        }
    }
}

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
    public partial class AddingVideoForm : Form
    {
        public AddingVideoForm()
        {
            InitializeComponent();
        }

        private void AddingVideoFormVideoURLTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddingVideoForm_Load(object sender, EventArgs e)
        {
            DataBase.conn.Close();
            DataBase.conn.Open();
        }




        private void AddingVideoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }

        private void AddingViedoButton_Click(object sender, EventArgs e)
        {

            string video_name = AddingVideoFormVideoNameTextBox.Text.ToString();
            string url = AddingVideoFormVideoURLTextBox.Text.ToString();
            string video_type = AddingVideoFormVideoTypeTextBox.Text.ToString();
            int age_allowed = Convert.ToInt32(AddingVideoFormVideoAgeAllowedTextBox.Text.ToString());
            int rating = Convert.ToInt32(AddingVideoFormVideoviewsTextBox.Text.ToString());
            int views = Convert.ToInt32(AddingVideoFormVideoviewsTextBox.Text.ToString());
            string description = AddingVideoFormVideoDescriptionTextBox.Text.ToString();
            DataBase.AddVideo(  video_name, url,video_type,age_allowed,rating,views,description);
        }
    }
}

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
            int age_allowed;

            try
            {
                age_allowed = Convert.ToInt32(AddingVideoFormVideoAgeAllowedTextBox.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Please enter a number in age");
                return;
            }
            
            string description = AddingVideoFormVideoDescriptionTextBox.Text.ToString();

            if (string.IsNullOrEmpty(video_name))
            {
                MessageBox.Show("Please enter a video name.");
                return;
            }

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a video URL.");
                return;
            }

            if (string.IsNullOrEmpty(video_type))
            {
                MessageBox.Show("Please enter a video type.");
                return;
            }

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter a video description.");
                return;
            }

            if (age_allowed < 0)
            {
                MessageBox.Show("Please enter a valid age allowed value (a non-negative integer).");
                return;
            }

            DataBase.AddVideo(video_name, url, video_type, age_allowed, 0, 0, description);
            MessageBox.Show("Video added successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm Form = new AdminForm();
            Form.Show();
            Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

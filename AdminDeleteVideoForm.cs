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
    public partial class AdminDeleteVideoForm : Form
    {
        public AdminDeleteVideoForm()
        {
            InitializeComponent();
        }

        private void AdminDeleteVideoForm_Load(object sender, EventArgs e)
        {
            DataBase.conn.Close();
            DataBase.conn.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Shahid.AdminForm back = new AdminForm();
            back.Show();
            Visible = false;

        }

        private void AdminDeleteVideoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int video_id = Convert.ToInt32(VideoIdDeleteTextBox.Text.ToString());
            DataBase.DeleteVideo(video_id);

        }
    }
}

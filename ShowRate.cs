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
    public partial class ShowRate : Form
    {
        public ShowRate()
        {
            InitializeComponent();
        }
        private void ShowRate_Load(object sender, EventArgs e)
        {
            DataBase.conn.Close();
            DataBase.conn.Open();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int user_id = Convert.ToInt32(UserIdTextBox.Text);
            int video_id = Convert.ToInt32(VideoIdTextBox.Text);
            Console.WriteLine("ïm here the values is " + user_id + "  " + video_id);
            int rate = DataBase.GetRate(user_id, video_id);

            textBox3.Text = rate.ToString();
        }

       

        private void ShowRate_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }
    }
}

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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            DataBase.conn.Close();

            DataBase.conn.Open();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Shahid.WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            Visible = false;
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.conn.Dispose();
        }

        private void AdminAddVideoButton_Click(object sender, EventArgs e)
        {
            Shahid.AddingVideoForm AddVideo = new AddingVideoForm();
            AddVideo.Show();
            Visible = false;
        }

        private void AdminShowAllUsersButton_Click(object sender, EventArgs e)
        {
            DataBase.RetrieveAllUsers();
            Shahid.ShowUsersInfo ShowInfo = new ShowUsersInfo();
            ShowInfo.Show();
            Visible = false;

        }

        private void AdminShowStatisticsButton_Click(object sender, EventArgs e)
        {
            Shahid.ShowRate ShowRate = new ShowRate();
            ShowRate.Show();
            Visible = false;
        }

        private void AdminDeleteVideoButton_Click(object sender, EventArgs e)
        {
            Shahid.AdminDeleteVideoForm delete = new AdminDeleteVideoForm();
            delete.Show();
            Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Shahid.CrystalReportForm report1 = new CrystalReportForm();
            report1.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shahid.CrystalReportForm2 report2 = new CrystalReportForm2();
            report2.Show();
            Visible = false;
        }
    }
}

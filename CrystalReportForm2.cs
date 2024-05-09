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
    public partial class CrystalReportForm2 : Form
    {
        CrystalReport2 CR;
        public CrystalReportForm2()
        {
            InitializeComponent();
        }

        private void CrystalReportForm2_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }
        private void CrystalReportForm2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
            Visible = false;
        }
    }
}

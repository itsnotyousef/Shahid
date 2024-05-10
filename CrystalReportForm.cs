using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Shahid
{
    public partial class CrystalReportForm : Form
    {
        CrystalReport1 CR;
        public CrystalReportForm()
        {
            InitializeComponent();
        }

        private void CrystalReportForm_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
            {
                USERIDcomboBox1.Items.Add(v.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(USERIDcomboBox1.Text))
            {

                CR.SetParameterValue(0, USERIDcomboBox1.Text);
                crystalReportViewer1.ReportSource = CR;

            }
            else
            {

                MessageBox.Show("please select a value from combo box");

            }


        }

        private void crystalreportcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

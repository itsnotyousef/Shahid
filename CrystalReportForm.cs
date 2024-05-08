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
        CrystalReport7 CR;
        public CrystalReportForm()
        {
            InitializeComponent();
        }

        private void CrystalReportForm_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport7();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues) 
            {
                crystalreportcomboBox1.Items.Add(v.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CR.SetParameterValue(0, crystalreportcomboBox1.Text);
            crystalReportViewer1.ReportSource = CR;

        }

        private void crystalreportcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

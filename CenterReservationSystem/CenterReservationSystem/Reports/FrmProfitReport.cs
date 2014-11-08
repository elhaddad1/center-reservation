using CenterReservation.BL.Manipulations;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterReservation.INT.Reports
{
    public partial class FrmProfitReport : Form
    {
        private static List<Physician> _AllPhysicians;
        public FrmProfitReport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProfitReport_Load(object sender, EventArgs e)
        {
              
            Physician _physician = new Physician();
            _AllPhysicians = _physician.GetPhysiciansWithPrics(DateTime.Now.Date);
            cbx_Physycian.DataSource = null;
            cbx_Physycian.DataSource = _AllPhysicians;
            cbx_Physycian.DisplayMember = "PhysicianName";
            cbx_Physycian.ValueMember = "PhysicianID";
            cbx_Physycian.SelectedIndex = -1;

           // this.reportViewer1.RefreshReport();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            //ReportDataSource source=new ReportDataSource ();
            //source .Value=@"D:\mohamed & rabab\center-reservation\CenterReservationSystem\CenterReservationSystem\Reports\Profitreport.rpt";
           // reportViewer1.LocalReport.DataSources.Add(source);
           // reportViewer1.Show();

        }
    }
}

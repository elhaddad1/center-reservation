using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CenterReservation.BL.Manipulations;
using CenterReservation.DL.Entity;
using CenterReservation.DL.DomainModel;
using CenterReservation.INT.BasicData;

namespace CenterReservation.INT.Reservasion
{
    public partial class FrmReservasion : Form
    {
        public CenterReservation.BL.Manipulations.Reservasion reservasionObj = new CenterReservation.BL.Manipulations.Reservasion();
        public FrmReservasion()
        {
            InitializeComponent();
        }


        #region Events
        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            FrmPatient frm = new FrmPatient();
            frm.FormClosed += FrmPatientClosed;
            frm.ShowDialog();
        }
        private void FrmPatientClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("برجاء البحث بأسم المريض المضاف الجديد");
            tbx_PatientName.Text = "";
            tbx_Phone.Text = "";
            dgrd_SearchResults.DataSource = null;
            dgrd_SearchResults.Refresh();

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tbx_PatientName.Text == "" && tbx_Phone.Text == "")
            {
                MessageBox.Show("برجاء ادخال الأسم او رقم التليفون أولا");
            }
            else
            {
                List<ACPatient> _result = reservasionObj.GetPatinetByNameORByPhoneNumber(tbx_PatientName.Text, tbx_Phone.Text);
                FillSearchGrid(_result);
            }
        }
        private void btn_ShowOldServices_Click(object sender, EventArgs e)
        {
            if (dgrd_SearchResults.SelectedRows.Count != 0)
            {
                string PatientID = dgrd_SearchResults.SelectedRows[0].Cells["clm_Code"].Value.ToString();
                FrmShowOldReservasion frm = new FrmShowOldReservasion(Convert.ToInt32(PatientID));
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("برجاء البحث عن مريض أولا");
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbx_PatientName.Text = "";
            tbx_Phone.Text = "";
            dgrd_SearchResults.DataSource = null;
            dgrd_SearchResults.Refresh();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btn_AddNewService_Click(object sender, EventArgs e)
        {
            if (dgrd_SearchResults.SelectedRows.Count != 0)
            {
                int PatientID = Convert.ToInt32(dgrd_SearchResults.SelectedRows[0].Cells["clm_Code"].Value.ToString());
                FrmAddNewReservasion frm = new FrmAddNewReservasion(PatientID);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("");
        }
        private void tbx_PatientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Search_Click(btn_Search, new EventArgs());
            }
        }
        private void tbx_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Search_Click(btn_Search, new EventArgs());
            }
        }
        #endregion


        #region Methods
        private void FillSearchGrid(List<ACPatient> _Acpationt)
        {
            dgrd_SearchResults.DataSource = null;
            dgrd_SearchResults.AutoGenerateColumns = false;
            dgrd_SearchResults.Columns[0].DataPropertyName = "PatientID";
            dgrd_SearchResults.Columns[1].DataPropertyName = "PatientName";
            dgrd_SearchResults.Columns[2].DataPropertyName = "Phone";
            dgrd_SearchResults.Columns[3].DataPropertyName = "DOB";
            dgrd_SearchResults.DataSource = _Acpationt;

        }
        #endregion

    }
}

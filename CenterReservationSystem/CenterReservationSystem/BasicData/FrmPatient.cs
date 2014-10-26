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
using CenterReservation.DL.DomainModel;
namespace CenterReservation.INT.BasicData
{
    public partial class FrmPatient : Form
    {
        Patient patient;
        public FrmPatient()
        {
            InitializeComponent();
            patient = new Patient();
        }
        #region Events
        private void FrmPatient_Load(object sender, EventArgs e)
            {
                DGVPatient.AutoGenerateColumns = false;
                DGVPatient.DataSource = patient.SelectAllBDPatient();

            }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            ACPatient _SelectedPatient = new ACPatient();
            _SelectedPatient.PatientID =txtNo.Text !=string .Empty ? Convert.ToInt32 (txtNo.Text):0;
            _SelectedPatient.PatientName = txtName.Text;
            _SelectedPatient.Address= txtAddress.Text ;
            _SelectedPatient.Phone = txtPhone.Text ;
            _SelectedPatient.Mobile = txtMobile.Text ;
           _SelectedPatient.DOB  = DtpDOB.Value;
           // txtAge.Text = (DateTime.Now - _SelectedPatient.DOB).ToString();
            _SelectedPatient.Notes  = txtNotes.Text;
            patient.addACPatient (_SelectedPatient);
            ResetFields();
            DGVPatient.DataSource = patient.SelectAllBDPatient();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (DGVPatient.SelectedCells !=null || DGVPatient.SelectedCells[0] != null)
            {
                int patientID = Convert.ToInt32(DGVPatient.Rows[DGVPatient.SelectedCells[0].RowIndex].Cells["PatientID"].Value);
                ACPatient _selectedPatint= patient.SelectPatientByID(patientID);
                txtNo.Text = _selectedPatint.PatientID.ToString ();
                txtName.Text = _selectedPatint.PatientName;
                txtAddress.Text = _selectedPatint.Address;
                txtPhone.Text = _selectedPatint.Phone;
                txtMobile.Text = _selectedPatint.Mobile;
                DtpDOB.Value = _selectedPatint.DOB.Value;
                txtNotes.Text = _selectedPatint.Notes;
                
            }

        }
        #endregion
        #region Methods
        private void ResetFields()
        {
            txtNo.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtMobile.Text = string.Empty;
            DtpDOB.Value = DateTime.Today;
            txtAge.Text = string.Empty;
            txtNotes.Text = string.Empty;
        } 
        #endregion

        private void DtpDOB_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text  = ( DateTime.Now - DtpDOB.Value ).ToString ();
        }

       

        
    }
}

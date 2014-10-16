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

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (DGVPatient.SelectedRows[0]!=null )
            {
                int patientID = Convert.ToInt32(DGVPatient.SelectedRows[0].Cells["PatientID"].Value);
                ACPatient _selectedPatint= patient.SelectPatientByID(patientID);
                txtName.Text = _selectedPatint.PatientName;
                txtAddress.Text = _selectedPatint.Address;
 
            }

        }
        #endregion
        #region Methods
        private void ResetFields()
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            DtpDOB.Value = DateTime.Today;
            txtAge.Text = string.Empty;
            txtNotes.Text = string.Empty;
        } 
        #endregion

        
    }
}

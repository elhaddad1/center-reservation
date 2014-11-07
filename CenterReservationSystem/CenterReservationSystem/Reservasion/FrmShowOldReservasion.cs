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
    public partial class FrmShowOldReservasion : Form
    {
        public CenterReservation.BL.Manipulations.Reservasion reservasionObj = new CenterReservation.BL.Manipulations.Reservasion();

        static int _patientID = -1;
        public FrmShowOldReservasion()
        {
            InitializeComponent();
        }

        public FrmShowOldReservasion(int PatientID)
        {
            InitializeComponent();
            _patientID = PatientID;
            FillVisitsGrid(PatientID);


        }

        #region Methods
        private void FillVisitsGrid(int _patientID)
        {
            var Query = reservasionObj.GetAllReservationsByPatinetID(_patientID);
            if (Query != null && Query.Count > 0)
            {
                dgrd_ShowVisits.DataSource = null;
                dgrd_ShowVisits.AutoGenerateColumns = false;
                dgrd_ShowVisits.Columns[0].DataPropertyName = "VisitID";
                dgrd_ShowVisits.Columns[1].DataPropertyName = "PhysicianName";
                dgrd_ShowVisits.Columns[2].DataPropertyName = "VisitName";
                dgrd_ShowVisits.Columns[3].DataPropertyName = "VisitDate";
                dgrd_ShowVisits.Columns[4].DataPropertyName = "VisitsCount";
                dgrd_ShowVisits.Columns[5].DataPropertyName = "TotalVisitPrice";
                dgrd_ShowVisits.Columns[6].DataPropertyName = "VisitPrice";
                dgrd_ShowVisits.Columns[7].DataPropertyName = "TimeFrom";
                dgrd_ShowVisits.Columns[8].DataPropertyName = "TimeTo";
                dgrd_ShowVisits.Columns[9].DataPropertyName = "Notes";
                dgrd_ShowVisits.DataSource = Query;
            }
        }
        #endregion

        #region Events
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrd_ShowVisits_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int VisitID = Convert.ToInt32(dgrd_ShowVisits.SelectedRows[0].Cells["id"].Value.ToString());
            if (reservasionObj.GetReservationByVisitID(VisitID) != null)
            {
                FrmAddNewReservasion frm = new FrmAddNewReservasion(reservasionObj.GetReservationByVisitID(VisitID));
                frm.FormClosed += AddresrvationClosed;
                frm.ShowDialog();


            }

        }
        private void AddresrvationClosed(object sender, FormClosedEventArgs e)
        {
            FillVisitsGrid(_patientID);
        }

        #endregion


    }
}

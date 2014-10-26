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

        public FrmShowOldReservasion()
        {
            InitializeComponent();
        }

        public FrmShowOldReservasion(int PatientID)
        {
            InitializeComponent();
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
        #endregion
    }
}

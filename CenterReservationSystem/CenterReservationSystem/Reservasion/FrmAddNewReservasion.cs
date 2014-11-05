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

namespace CenterReservation.INT.Reservasion
{
    public partial class FrmAddNewReservasion : Form
    {
        #region Public variables
        private static List<Physician> _AllPhysicians;
        private static List<VisitType> _AllVisits;
        private static decimal PhysicianPrice = 0;
        private static decimal VisitPrice = 0;
        private static string Mode = null;
        private static int PatientID = -1;

        private BL.Manipulations.Reservasion SelectedReservasion;
        #endregion

        #region Constracturs
        public FrmAddNewReservasion(int _patientID)
        {
            InitializeComponent();
            PatientID = _patientID;
            Mode = "Add";
            Fillcbx_Physician();
            Fillcbx_VisitType();
            tbx_TotalPrice.Text = "";
        }

        public FrmAddNewReservasion(BL.Manipulations.Reservasion _reservasion)
        {
            InitializeComponent();

            Mode = "Edit";
            Fillcbx_Physician();
            Fillcbx_VisitType();
            FillUIInEditMode(_reservasion);
            SelectedReservasion = _reservasion;
        }

        #endregion

        #region Events
        private void cbx_Physycian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Physycian.SelectedIndex != -1)
            {
                PhysicianPrice = ((CenterReservation.BL.Manipulations.Physician)(cbx_Physycian.SelectedItem)).PhysicianSalary;
                SetTotalPrice();
            }
        }

        private void cbx_VisitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_VisitType.SelectedIndex != -1)
            {
                VisitPrice = ((CenterReservation.BL.Manipulations.VisitType)(cbx_VisitType.SelectedItem)).VisitPrice;
                SetTotalPrice();
            }
        }

        private void tbx_PaiedPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbx_PaiedPrice.Text) && !string.IsNullOrEmpty(tbx_TotalPrice.Text))
            {
                if (Convert.ToDecimal(tbx_PaiedPrice.Text) > Convert.ToDecimal(tbx_TotalPrice.Text))
                    tbx_RestPrice.Text = (Convert.ToDecimal(tbx_PaiedPrice.Text) - Convert.ToDecimal(tbx_TotalPrice.Text)).ToString();
                else
                    tbx_RestPrice.Text = 0.ToString();
            }

        }

        private void num_VisitsCount_ValueChanged(object sender, EventArgs e)
        {
            SetTotalPrice();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateUI())
            {
                BL.Manipulations.Reservasion _reservationObj = new BL.Manipulations.Reservasion();

                if (Mode == "Add")
                {
                    BL.Manipulations.Reservasion _reservation = new BL.Manipulations.Reservasion();
                    if (_reservationObj.AddNewReservation(CollectDataFromUI(_reservation)))
                    {
                        MessageBox.Show("تمت العملية بنجاح");
                        this.Close();
                    }
                    else
                        MessageBox.Show("خطا اثناء الحفظ اعدالمحاولة ");

                }
                if (Mode == "Edit")
                {
                    if (_reservationObj.EditReservation(CollectDataFromUI(SelectedReservasion)))
                    {
                        MessageBox.Show("تمت العملية بنجاح");
                        this.Close();
                    }
                    else
                        MessageBox.Show("خطا اثناء الحفظ اعدالمحاولة ");
                }
            }
            else
            {
                MessageBox.Show("برجاء اكمال البيانات المطلوبة");
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Methods
        private void Fillcbx_Physician()
        {
            Physician _physician = new Physician();
            _AllPhysicians = _physician.GetPhysiciansWithPrics(DateTime.Now.Date);
            cbx_Physycian.DataSource = null;
            cbx_Physycian.DataSource = _AllPhysicians;
            cbx_Physycian.DisplayMember = "PhysicianName";
            cbx_Physycian.ValueMember = "PhysicianID";
            cbx_Physycian.SelectedIndex = -1;
            PhysicianPrice = 0;
            VisitPrice = 0;

        }
        private void Fillcbx_VisitType()
        {
            VisitType _visitType = new VisitType();
            _AllVisits = _visitType.GetVisitsWithPrics(DateTime.Now.Date);
            cbx_VisitType.DataSource = null;
            cbx_VisitType.DataSource = _AllVisits;
            cbx_VisitType.DisplayMember = "VisitTypeName";
            cbx_VisitType.ValueMember = "VisitTypeID";
            cbx_VisitType.SelectedIndex = -1;
            PhysicianPrice = 0;
            VisitPrice = 0;
        }
        private void SetTotalPrice()
        {
            if (PhysicianPrice != 0 && VisitPrice != 0)
            {
                tbx_TotalPrice.Text = "";
                tbx_TotalPrice.Text = ((PhysicianPrice + VisitPrice) * num_VisitsCount.Value).ToString();
            }
        }
        private bool ValidateUI()
        {
            if (cbx_Physycian.SelectedIndex == -1)
                return false;
            if (cbx_VisitType.SelectedIndex == -1)
                return false;
            if (string.IsNullOrEmpty(num_VisitsCount.Value.ToString()))
                return false;
            if (dtb_From.Value.Hour > dtb_To.Value.Hour)
                return false;
            if (string.IsNullOrEmpty(tbx_TotalPrice.Text))
                return false;
            //if (string.IsNullOrEmpty(rtch_Notes.Text))
            //    return false;k
            return true;
        }
        private BL.Manipulations.Reservasion CollectDataFromUI(BL.Manipulations.Reservasion _reservation)
        {
            _reservation.PatientID = PatientID;
            _reservation.PhysicianID = Convert.ToInt32(cbx_Physycian.SelectedValue);
            _reservation.VisitTypeID = Convert.ToInt32(cbx_VisitType.SelectedValue);
            _reservation.VisitsCount = Convert.ToInt32(num_VisitsCount.Value);
            _reservation.VisitPrice = VisitPrice;
            _reservation.PhysicianSalary = PhysicianPrice;
            _reservation.VisitDate = DateTime.Now;
            _reservation.TotalVisitPrice = Convert.ToDecimal(tbx_TotalPrice.Text);
            _reservation.TimeFrom = new TimeSpan(dtb_From.Value.Hour, dtb_From.Value.Minute, dtb_From.Value.Second);
            _reservation.TimeTo = new TimeSpan(dtb_To.Value.Hour, dtb_To.Value.Minute, dtb_To.Value.Second);
            _reservation.PaiedPrice = Convert.ToDecimal(tbx_PaiedPrice.Text);
            _reservation.RestPrice = Convert.ToDecimal(tbx_RestPrice.Text);
            _reservation.Notes = rtch_Notes.Text;

            return _reservation;
        }

        private void FillUIInEditMode(BL.Manipulations.Reservasion _reservasion)
        {
            PatientID = _reservasion.PatientID;
            cbx_Physycian.SelectedValue = _reservasion.PhysicianID;
            cbx_VisitType.SelectedValue = _reservasion.VisitTypeID;
            VisitPrice = _reservasion.VisitPrice;
            PhysicianPrice = _reservasion.PhysicianSalary;
            tbx_TotalPrice.Text = _reservasion.TotalVisitPrice.ToString();
            tbx_PaiedPrice.Text = _reservasion.PaiedPrice.ToString();
            tbx_RestPrice.Text = _reservasion.RestPrice.ToString();
            num_VisitsCount.Value = _reservasion.VisitsCount;
            rtch_Notes.Text = _reservasion.Notes;
            dtb_From.Value = new DateTime(1999, 1, 1, _reservasion.TimeFrom.Hours, _reservasion.TimeFrom.Minutes, _reservasion.TimeFrom.Seconds);
            dtb_To.Value = new DateTime(1999, 1, 1, _reservasion.TimeTo.Hours, _reservasion.TimeTo.Minutes, _reservasion.TimeTo.Seconds);

        }



        #endregion





    }
}

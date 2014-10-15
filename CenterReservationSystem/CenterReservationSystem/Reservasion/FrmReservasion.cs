using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CenterReservation.INT.BasicData;

namespace CenterReservation.INT.Reservasion
{
    public partial class FrmReservasion : Form
    {
        public FrmReservasion()
        {
            InitializeComponent();
        }


        #region Events
        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            FrmPatient frm = new FrmPatient();
            frm.ShowDialog();
        }

        #endregion

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tbx_PatientName.Text == "" && tbx_Phone.Text == "")
            {
                MessageBox.Show("برجاء ادخال الأسم او رقم التليفون أولا");
            }
            else
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterReservation.INT
{
    public partial class frm_MainWindow : Form
    {
        public frm_MainWindow()
        {
            InitializeComponent();
        }

        private void AddEditPhysicianWindow_Click(object sender, EventArgs e)
        {
            BasicData.FrmPhysician frm = new BasicData.FrmPhysician();
            frm.ShowDialog();
        }

        private void VisitTypeWindow_Click(object sender, EventArgs e)
        {
            BasicData.FrmVisitType frm = new BasicData.FrmVisitType();
            frm.ShowDialog();
        }

        private void PhysicianPriceWindow_Click(object sender, EventArgs e)
        {
            BasicData.FrmPhysicianSalary frm = new BasicData.FrmPhysicianSalary();
            frm.ShowDialog();
        }

        private void ToolStripMenuItemPatiant_Click(object sender, EventArgs e)
        {
            BasicData.FrmPatient frm = new BasicData.FrmPatient();
            frm.ShowDialog();
        }

        private void ReservasionWindow_Click(object sender, EventArgs e)
        {
            Reservasion.FrmReservasion frm = new Reservasion.FrmReservasion();
            frm.ShowDialog();
        }


        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicData.FrmVisitPrice frm = new BasicData.FrmVisitPrice();
            frm.ShowDialog();
        }

        private void NewReservasionWindow_Click(object sender, EventArgs e)
        {
            Reservasion.FrmReservasion frm = new Reservasion.FrmReservasion();
            frm.ShowDialog();
        }


    }
}

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


    }
}

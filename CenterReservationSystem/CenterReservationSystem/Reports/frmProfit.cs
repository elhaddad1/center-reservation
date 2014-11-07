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
    public partial class frmProfit : Form
    {
        public frmProfit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioBtnSpecficPhisician_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnSpecficPhisician.Checked)
            {
                
            }
        }
    }
}

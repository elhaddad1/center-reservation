using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterReservation.INT.BasicData
{
    public partial class FrmPhysicianSalary : Form
    {
        string Mode = "Select";

        public FrmPhysicianSalary()
        {
            InitializeComponent();
        }

        public void ControlUI(string order)
        {
            if (order == "Select")
            {
                // Default behavior
                btn_Save.Enabled = false;
                btn_Add.Enabled = true;
                btn_Edit.Enabled = true;
                btn_Back.Enabled = true;
                btn_Delete.Enabled = true;

                //exception behavior
                cbx_PhysicianName.Visible = true;

            }
            else if (order == "Add")
            {
                // Default behaior
                btn_Add.Enabled = false;
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Save.Enabled = true;

                // exception behavior

                cbx_PhysicianName.Visible = false;
            }
            else if (order == "Edit")
            {
                // Default behaior
                btn_Add.Enabled = false;
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Save.Enabled = true;
                // exception behavior

                cbx_PhysicianName.Visible = false;
            }
        }

        #region
        //Events
        private void FrmPhysician_Load(object sender, EventArgs e)
        {
            Mode = "Select";
            ControlUI("Select");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Mode = "Change";
            ControlUI("Add");
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Mode = "Change";
            ControlUI("Edit");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ControlUI("Select");
            Mode = "Select";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (Mode == "Select")
            {
                this.Close();
            }
            else if (Mode == "Change")
            {
                ControlUI("Select");
                Mode = "Select";
            }
        }

        #endregion
    }
}

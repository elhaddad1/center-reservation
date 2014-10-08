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
using CenterReservation.BL.DataContract;
namespace CenterReservation.INT.BasicData
{
    public partial class FrmPhysician : Form
    {
        string Mode = "Select";
        Physician physician = new Physician();
        BDPhsycian _SelectedPhysician;
        public FrmPhysician()
        {
            InitializeComponent();
        }



        #region
        //Events
        private void FrmPhysician_Load(object sender, EventArgs e)
        {
            Mode = "Select";
            ControlUI("Select");

            FillPhysicianCombo();
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
            if (Mode == "Add")
            {
                BDPhsycian _bdphysician = new BDPhsycian();
                _bdphysician.PhysicianName = tbx_PhysicianName.Text.ToString();
                physician.addBDPhysician(_bdphysician);
            }
            else if (Mode == "Edit")
            {
                _SelectedPhysician.PhysicianName = tbx_PhysicianName.Text.ToString();
                physician.addBDPhysician(_SelectedPhysician);
            }
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
                tbx_PhysicianName.Visible = false;
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
                tbx_PhysicianName.Visible = true;
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
                tbx_PhysicianName.Visible = true;
            }
        }

        public void FillPhysicianCombo()
        {
            cbx_PhysicianName.DataSource = physician.SelectAllBDPhysician();
            cbx_PhysicianName.DisplayMember = "PhysicianName";
            cbx_PhysicianName.ValueMember = "PhysicianID";

        }

    }
}

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
        BDPhsycian _SelectedPhysician = new BDPhsycian();
        public FrmPhysician()
        {

            InitializeComponent();
            //cbx_PhysicianName.SelectedIndex = 0;
            Mode = "Select";
            ControlUI("Select");
            FillPhysicianCombo();

        }



        #region
        //Events
        private void FrmPhysician_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Mode = "Add";
            ControlUI("Add");
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Mode = "Edit";
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
                FillPhysicianCombo();
            }
            else if (Mode == "Edit")
            {
                _SelectedPhysician.PhysicianName = tbx_PhysicianName.Text.ToString();
                physician.addBDPhysician(_SelectedPhysician);
                FillPhysicianCombo();
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
            else if (Mode == "Add" || Mode == "Edit")
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
                tbx_PhysicianName.Text = "";
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
                tbx_PhysicianName.Text = "";
            }
        }

        public void FillPhysicianCombo()
        {
            cbx_PhysicianName.DataSource = physician.SelectAllBDPhysician();
            cbx_PhysicianName.DisplayMember = "PhysicianName";
            cbx_PhysicianName.ValueMember = "PhysicianID";
            cbx_PhysicianName.SelectedIndex = 0;
            cbx_PhysicianName_SelectedIndexChanged(cbx_PhysicianName, new EventArgs());
        }

        private void cbx_PhysicianName_SelectedIndexChanged(object sender, EventArgs e)
        {


            int code = 0;
            int.TryParse(cbx_PhysicianName.SelectedValue.ToString(), out code);
            if (code == 0)
                return;

            _SelectedPhysician.PhysicianID = code;

        }

    }
}

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
    public partial class FrmVisitType : Form
    {
        #region Public variables
        //Public variables
        string Mode = "Select";
        VisitType visitType = new VisitType();
        VisitType _SelectedVisitType = new VisitType();
        #endregion
        public FrmVisitType()
        {
            InitializeComponent();
            Mode = "Select";
            ControlUI("Select");
            FillVisitTypeCombo();
        }
        #region Events
        //Events
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
            _SelectedVisitType.VisitTypeName = cbx_VisitName.Text;
            string _message = visitType.deleteBDVisitType(_SelectedVisitType);
            FillVisitTypeCombo();
            MessageBox.Show(_message);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Mode == "Add")
            {
                VisitType _bdvisitType = new VisitType();
                _bdvisitType.VisitTypeName = tbx_VisitName.Text.ToString();
                string _message = _bdvisitType.addBDVisitType(_bdvisitType);
                FillVisitTypeCombo();
                MessageBox.Show(_message);
            }
            else if (Mode == "Edit")
            {
                _SelectedVisitType.VisitTypeName = tbx_VisitName.Text.ToString();
                string _message = visitType.addBDVisitType(_SelectedVisitType);
                FillVisitTypeCombo();
                MessageBox.Show(_message);
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

        private void cbx_VisitName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbx_VisitName.SelectedIndex != -1)
            {
                int code = 0;
                int.TryParse(cbx_VisitName.SelectedValue.ToString(), out code);
                if (code == 0)
                    return;

                _SelectedVisitType.VisitTypeID = code;

            }
        }

        #endregion
        #region Methods
        // Methods
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
                tbx_VisitName.Visible = false;
                cbx_VisitName.Visible = true;

            }
            else if (order == "Add")
            {
                // Default behaior
                btn_Add.Enabled = false;
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Save.Enabled = true;

                // exception behavior

                cbx_VisitName.Visible = false;
                tbx_VisitName.Visible = true;
                tbx_VisitName.Text = "";
            }
            else if (order == "Edit")
            {
                // Default behaior
                btn_Add.Enabled = false;
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Save.Enabled = true;
                // exception behavior

                cbx_VisitName.Visible = false;
                tbx_VisitName.Visible = true;
                tbx_VisitName.Text = cbx_VisitName.Text;
            }
        }

        public void FillVisitTypeCombo()
        {
            cbx_VisitName.DataSource = visitType.SelectAllBDVisitType();
            cbx_VisitName.DisplayMember = "VisitTypeName";
            cbx_VisitName.ValueMember = "VisitTypeID";
            cbx_VisitName.SelectedIndex = -1;
            cbx_VisitName_SelectedIndexChanged(cbx_VisitName, new EventArgs());
        }
        #endregion
    }
}

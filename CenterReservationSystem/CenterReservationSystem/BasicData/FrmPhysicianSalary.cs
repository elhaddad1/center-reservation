using CenterReservation.BL.Manipulations;
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
        private void FrmPhysicianSalary_Load(object sender, EventArgs e)
        {
            Mode = "Select";
            ControlUI("Select");
            fillDrobdown();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Mode = "Change";
            ControlUI("Add");
            fillGrid();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Mode = "Change";
            ControlUI("Edit");
            fillGrid();
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

        private void cbx_PhysicianName_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGrid();
        }
        #endregion

        private void fillGrid()
        {
            try
            {
                int code = 0;
                int.TryParse(cbx_PhysicianName.SelectedValue.ToString(), out code);
                if (code == 0)
                    return;
                PhysicianSalary newObj = new PhysicianSalary();
                dataGridView1.DataSource = null;
                var query = newObj.GetAll().Where(a => a.PhysicianID == code).OrderBy(a => a.PhysicianPriceID).ToList();
                dataGridView1.AutoGenerateColumns = false;
                var queryGrid = (from v in query
                                 select new
                                 {
                                     From = v.FromDate != null ? v.FromDate.ToShortDateString() : "",
                                     To = v.ToDate != null ? v.ToDate.ToShortDateString() : "",
                                     Price = Convert.ToString(v.PhysicianSalary)
                                 }).ToList();
                dataGridView1.DataSource = query;
                dataGridView1.Columns[0].DataPropertyName = "Price";
                dataGridView1.Columns[1].DataPropertyName = "From";
                dataGridView1.Columns[2].DataPropertyName = "To";
            }
            catch (Exception ex)
            {
                 throw;
            }
        }


        private void fillDrobdown()
        {
            try
            {
                Physician newObj = new Physician();
                cbx_PhysicianName.DataSource = newObj.SelectAllBDPhysician();
                cbx_PhysicianName.DisplayMember = "PhysicianName";
                cbx_PhysicianName.ValueMember = "PhysicianID";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}

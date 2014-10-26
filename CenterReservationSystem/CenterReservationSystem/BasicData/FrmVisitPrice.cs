using CenterReservation.BL.Manipulations;
using CenterReservation.DL.DomainModel;
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
    public partial class FrmVisitPrice : Form
    {
        private string Mode = "Select";

        private VisitPriceModel newObjVisitPriceModel = new VisitPriceModel();

        private VisitType newObjVisitType = new VisitType();

        public FrmVisitPrice()
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
                btn_Back.Enabled = true;
                btn_Delete.Enabled = true;
                groupBox1.Enabled = true;
                dataGridView1.Enabled = true;
            }
            else if (order == "Add")
            {
                // Default behaior
                btn_Add.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Save.Enabled = true;
                groupBox1.Enabled = true;
                dataGridView1.Enabled = true;
            }
        }

        #region
        
        //Events

        private void FrmVisitPrice_Load(object sender, EventArgs e)
        {
            Mode = "Select";
            ControlUI("Select");
            fillDrobdown();
            fillGrid();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Mode = "Change";
            ControlUI("Add");
            ClearUI();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int code = 0;
            int.TryParse(txtId.Text, out code);
            if (code > 0 && newObjVisitPriceModel.Delete(code))
            {
                ClearUI();
            }
            else
                MessageBox.Show("لم يتم الحذف لارتباط العنصر ببيانات اخرى.");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var PSObj = ObjectFromUI();
            if (newObjVisitPriceModel.ValidateVisitPrice(PSObj))
            {
                newObjVisitPriceModel.VisitPriceSaveChange(PSObj);
                ControlUI("Select");
                Mode = "Select";
                ClearUI();
            }
            else
                MessageBox.Show("من فضلك, تأكد من ادخال البيانات صحيحة او عدم تداخل او تكرار الفترة.");
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

        private void cbx_VisitTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGrid();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int code = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var PSObj = newObjVisitPriceModel.Find(code);
            ObjectToUI(PSObj);
            // Default behavior
            btn_Save.Enabled = true;
            btn_Add.Enabled = true;
            btn_Back.Enabled = true;
            btn_Delete.Enabled = true;
        }
        #endregion

        /// <summary>
        /// Get data from UI to create new Object
        /// </summary>
        /// <returns></returns>
        private BDVisitPrice ObjectFromUI()
        {
            BDVisitPrice newObj = new BDVisitPrice();
            newObj.VisitPriceID = int.Parse(txtId.Text);
            newObj.FromDate = dateTimePicker1.Value;
            newObj.ToDate = dateTimePicker2.Value;
            newObj.VisitPrice = numericUpDown2.Value;
            newObj.VisitTypeID = int.Parse(cbx_VisitTypeName.SelectedValue.ToString());
            return newObj;
        }
        /// <summary>
        /// ma object to control in UI form
        /// </summary>
        /// <param name="newObj"></param>
        private void ObjectToUI(BDVisitPrice newObj)
        {
            txtId.Text = newObj.VisitPriceID.ToString();
            dateTimePicker1.Value = newObj.FromDate;
            dateTimePicker2.Value = newObj.ToDate;
            numericUpDown2.Value = newObj.VisitPrice;
            cbx_VisitTypeName.SelectedValue = newObj.VisitTypeID;
        }
        /// <summary>
        /// clear ui
        /// </summary>
        private void ClearUI()
        {
            txtId.Text = "0";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            numericUpDown2.Value = 0;
            //fillDrobdown();
            fillGrid();
        }
        /// <summary>
        /// fill grid with data filter by visit type id
        /// </summary>
        private void fillGrid()
        {
            try
            {
                int code = 0;
                int.TryParse(cbx_VisitTypeName.SelectedValue.ToString(), out code);
                if (code == 0)
                    return;
                dataGridView1.DataSource = null;
                List<BDVisitPrice> query = newObjVisitPriceModel.FindByVisitPriceCode(code).ToList();
                dataGridView1.AutoGenerateColumns = false;
                var queryGrid = (from v in query
                                 select new
                                 {
                                     id=v.VisitPriceID,
                                     From = v.FromDate != null ? v.FromDate.ToShortDateString() : "",
                                     To = v.ToDate != null ? v.ToDate.ToShortDateString() : "",
                                     Price = Convert.ToString(v.VisitPrice)
                                 }).ToList();
                dataGridView1.DataSource = queryGrid;
                dataGridView1.Columns[0].DataPropertyName = "id";
                dataGridView1.Columns[1].DataPropertyName = "Price";
                dataGridView1.Columns[2].DataPropertyName = "From";
                dataGridView1.Columns[3].DataPropertyName = "To";
            }
            catch (Exception ex)
            {
                 throw;
            }
        }
        /// <summary>
        /// fill dropdown with visit type names with id as a selected value
        /// </summary>
        private void fillDrobdown()
        {
            try
            {
                cbx_VisitTypeName.DataSource = newObjVisitType.SelectAllBDVisitType().ToList();
                cbx_VisitTypeName.DisplayMember = "VisitTypeName";
                cbx_VisitTypeName.ValueMember = "VisitTypeID";
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}

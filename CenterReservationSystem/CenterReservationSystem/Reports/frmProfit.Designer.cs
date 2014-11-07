namespace CenterReservation.INT.Reports
{
    partial class frmProfit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DTPFromDate = new System.Windows.Forms.DateTimePicker();
            this.DTPToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioBtnSpecficPhisician = new System.Windows.Forms.RadioButton();
            this.RadioBtnAllPhisician = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBoxCenterProfit = new System.Windows.Forms.CheckBox();
            this.chkBoxPhisicianProfit = new System.Windows.Forms.CheckBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTPFromDate
            // 
            this.DTPFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFromDate.Location = new System.Drawing.Point(171, 38);
            this.DTPFromDate.Name = "DTPFromDate";
            this.DTPFromDate.RightToLeftLayout = true;
            this.DTPFromDate.Size = new System.Drawing.Size(108, 20);
            this.DTPFromDate.TabIndex = 0;
            // 
            // DTPToDate
            // 
            this.DTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPToDate.Location = new System.Drawing.Point(171, 78);
            this.DTPToDate.Name = "DTPToDate";
            this.DTPToDate.RightToLeftLayout = true;
            this.DTPToDate.Size = new System.Drawing.Size(108, 20);
            this.DTPToDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "التاريخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "من:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "إلي:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radioBtnSpecficPhisician);
            this.groupBox1.Controls.Add(this.RadioBtnAllPhisician);
            this.groupBox1.Location = new System.Drawing.Point(58, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(334, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الأخصائي";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // radioBtnSpecficPhisician
            // 
            this.radioBtnSpecficPhisician.AutoSize = true;
            this.radioBtnSpecficPhisician.Location = new System.Drawing.Point(232, 47);
            this.radioBtnSpecficPhisician.Name = "radioBtnSpecficPhisician";
            this.radioBtnSpecficPhisician.Size = new System.Drawing.Size(89, 17);
            this.radioBtnSpecficPhisician.TabIndex = 1;
            this.radioBtnSpecficPhisician.TabStop = true;
            this.radioBtnSpecficPhisician.Text = "أخصائي معين";
            this.radioBtnSpecficPhisician.UseVisualStyleBackColor = true;
            this.radioBtnSpecficPhisician.CheckedChanged += new System.EventHandler(this.radioBtnSpecficPhisician_CheckedChanged);
            // 
            // RadioBtnAllPhisician
            // 
            this.RadioBtnAllPhisician.AutoSize = true;
            this.RadioBtnAllPhisician.Location = new System.Drawing.Point(231, 22);
            this.RadioBtnAllPhisician.Name = "RadioBtnAllPhisician";
            this.RadioBtnAllPhisician.Size = new System.Drawing.Size(90, 17);
            this.RadioBtnAllPhisician.TabIndex = 0;
            this.RadioBtnAllPhisician.TabStop = true;
            this.RadioBtnAllPhisician.Text = "كل الاخصائيين";
            this.RadioBtnAllPhisician.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBoxCenterProfit);
            this.groupBox2.Controls.Add(this.chkBoxPhisicianProfit);
            this.groupBox2.Location = new System.Drawing.Point(58, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 72);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عرض";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // chkBoxCenterProfit
            // 
            this.chkBoxCenterProfit.AutoSize = true;
            this.chkBoxCenterProfit.Location = new System.Drawing.Point(238, 43);
            this.chkBoxCenterProfit.Name = "chkBoxCenterProfit";
            this.chkBoxCenterProfit.Size = new System.Drawing.Size(83, 17);
            this.chkBoxCenterProfit.TabIndex = 1;
            this.chkBoxCenterProfit.Text = "أرباح المركز";
            this.chkBoxCenterProfit.UseVisualStyleBackColor = true;
            // 
            // chkBoxPhisicianProfit
            // 
            this.chkBoxPhisicianProfit.AutoSize = true;
            this.chkBoxPhisicianProfit.Location = new System.Drawing.Point(223, 19);
            this.chkBoxPhisicianProfit.Name = "chkBoxPhisicianProfit";
            this.chkBoxPhisicianProfit.Size = new System.Drawing.Size(98, 17);
            this.chkBoxPhisicianProfit.TabIndex = 0;
            this.chkBoxPhisicianProfit.Text = "أرباح الأخصائي";
            this.chkBoxPhisicianProfit.UseVisualStyleBackColor = true;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Location = new System.Drawing.Point(105, 328);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(121, 32);
            this.btnShowReport.TabIndex = 8;
            this.btnShowReport.Text = "عرض التقرير";
            this.btnShowReport.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(244, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 386);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPToDate);
            this.Controls.Add(this.DTPFromDate);
            this.Name = "frmProfit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تقرير الارباح";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker DTPFromDate;
        public System.Windows.Forms.DateTimePicker DTPToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioBtnSpecficPhisician;
        private System.Windows.Forms.RadioButton RadioBtnAllPhisician;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBoxCenterProfit;
        private System.Windows.Forms.CheckBox chkBoxPhisicianProfit;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Button btnCancel;

    }
}
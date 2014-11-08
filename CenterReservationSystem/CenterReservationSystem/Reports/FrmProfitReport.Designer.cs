namespace CenterReservation.INT.Reports
{
    partial class FrmProfitReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_Physycian = new System.Windows.Forms.ComboBox();
            this.radioBtnSpecficPhisician = new System.Windows.Forms.RadioButton();
            this.RadioBtnAllPhisician = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPToDate = new System.Windows.Forms.DateTimePicker();
            this.DTPFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBoxCenterProfit = new System.Windows.Forms.CheckBox();
            this.chkBoxPhisicianProfit = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Physycian);
            this.groupBox1.Controls.Add(this.radioBtnSpecficPhisician);
            this.groupBox1.Controls.Add(this.RadioBtnAllPhisician);
            this.groupBox1.Location = new System.Drawing.Point(86, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(334, 87);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الأخصائي";
            // 
            // cbx_Physycian
            // 
            this.cbx_Physycian.FormattingEnabled = true;
            this.cbx_Physycian.Location = new System.Drawing.Point(104, 45);
            this.cbx_Physycian.Name = "cbx_Physycian";
            this.cbx_Physycian.Size = new System.Drawing.Size(121, 21);
            this.cbx_Physycian.TabIndex = 2;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "إلي:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "من:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "التاريخ";
            // 
            // DTPToDate
            // 
            this.DTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPToDate.Location = new System.Drawing.Point(199, 56);
            this.DTPToDate.Name = "DTPToDate";
            this.DTPToDate.RightToLeftLayout = true;
            this.DTPToDate.Size = new System.Drawing.Size(108, 20);
            this.DTPToDate.TabIndex = 11;
            // 
            // DTPFromDate
            // 
            this.DTPFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFromDate.Location = new System.Drawing.Point(199, 16);
            this.DTPFromDate.Name = "DTPFromDate";
            this.DTPFromDate.RightToLeftLayout = true;
            this.DTPFromDate.Size = new System.Drawing.Size(108, 20);
            this.DTPFromDate.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBoxCenterProfit);
            this.groupBox2.Controls.Add(this.chkBoxPhisicianProfit);
            this.groupBox2.Location = new System.Drawing.Point(86, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 72);
            this.groupBox2.TabIndex = 16;
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
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(272, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 32);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Location = new System.Drawing.Point(133, 306);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(121, 32);
            this.btnShowReport.TabIndex = 17;
            this.btnShowReport.Text = "عرض التقرير";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 48;
            this.reportViewer1.Location = new System.Drawing.Point(12, 291);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.ReportPath = "Reports/ProfitReport.rpt";
            this.reportViewer1.Size = new System.Drawing.Size(99, 55);
            this.reportViewer1.TabIndex = 19;
            // 
            // FrmProfitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 354);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPToDate);
            this.Controls.Add(this.DTPFromDate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShowReport);
            this.Name = "FrmProfitReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FrmProfitReport";
            this.Load += new System.EventHandler(this.FrmProfitReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_Physycian;
        private System.Windows.Forms.RadioButton radioBtnSpecficPhisician;
        private System.Windows.Forms.RadioButton RadioBtnAllPhisician;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker DTPToDate;
        public System.Windows.Forms.DateTimePicker DTPFromDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBoxCenterProfit;
        private System.Windows.Forms.CheckBox chkBoxPhisicianProfit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnShowReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
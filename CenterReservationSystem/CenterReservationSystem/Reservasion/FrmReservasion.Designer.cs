namespace CenterReservation.INT.Reservasion
{
    partial class FrmReservasion
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
            this.tbx_PatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Phone = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AddPatient = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrd_SearchResults = new System.Windows.Forms.DataGridView();
            this.clm_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ShowOldServices = new System.Windows.Forms.Button();
            this.btn_AddNewService = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddPatient);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbx_Phone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_PatientName);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث ";
            // 
            // tbx_PatientName
            // 
            this.tbx_PatientName.Location = new System.Drawing.Point(312, 28);
            this.tbx_PatientName.Name = "tbx_PatientName";
            this.tbx_PatientName.Size = new System.Drawing.Size(257, 20);
            this.tbx_PatientName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "الأسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "رقم التليفون";
            // 
            // tbx_Phone
            // 
            this.tbx_Phone.Location = new System.Drawing.Point(312, 60);
            this.tbx_Phone.Name = "tbx_Phone";
            this.tbx_Phone.Size = new System.Drawing.Size(257, 20);
            this.tbx_Phone.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(129, 8);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 53);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_AddPatient
            // 
            this.btn_AddPatient.Location = new System.Drawing.Point(129, 68);
            this.btn_AddPatient.Name = "btn_AddPatient";
            this.btn_AddPatient.Size = new System.Drawing.Size(112, 53);
            this.btn_AddPatient.TabIndex = 5;
            this.btn_AddPatient.Text = "أضافة مريض";
            this.btn_AddPatient.UseVisualStyleBackColor = true;
            this.btn_AddPatient.Click += new System.EventHandler(this.btn_AddPatient_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrd_SearchResults);
            this.groupBox2.Location = new System.Drawing.Point(13, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نتائج البحث";
            // 
            // dgrd_SearchResults
            // 
            this.dgrd_SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_SearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Code,
            this.clm_name,
            this.clm_Phone,
            this.clm_DOB});
            this.dgrd_SearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrd_SearchResults.Location = new System.Drawing.Point(3, 16);
            this.dgrd_SearchResults.Name = "dgrd_SearchResults";
            this.dgrd_SearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrd_SearchResults.Size = new System.Drawing.Size(661, 155);
            this.dgrd_SearchResults.TabIndex = 0;
            // 
            // clm_Code
            // 
            this.clm_Code.HeaderText = "كود المريض";
            this.clm_Code.Name = "clm_Code";
            // 
            // clm_name
            // 
            this.clm_name.HeaderText = "الاٍسم";
            this.clm_name.Name = "clm_name";
            this.clm_name.Width = 200;
            // 
            // clm_Phone
            // 
            this.clm_Phone.HeaderText = "التليفون";
            this.clm_Phone.Name = "clm_Phone";
            // 
            // clm_DOB
            // 
            this.clm_DOB.HeaderText = "تاريخ الميلاد";
            this.clm_DOB.Name = "clm_DOB";
            this.clm_DOB.Width = 150;
            // 
            // btn_ShowOldServices
            // 
            this.btn_ShowOldServices.Location = new System.Drawing.Point(178, 323);
            this.btn_ShowOldServices.Name = "btn_ShowOldServices";
            this.btn_ShowOldServices.Size = new System.Drawing.Size(112, 49);
            this.btn_ShowOldServices.TabIndex = 5;
            this.btn_ShowOldServices.Text = "عرض الجلسات السابقه";
            this.btn_ShowOldServices.UseVisualStyleBackColor = true;
            // 
            // btn_AddNewService
            // 
            this.btn_AddNewService.Location = new System.Drawing.Point(298, 323);
            this.btn_AddNewService.Name = "btn_AddNewService";
            this.btn_AddNewService.Size = new System.Drawing.Size(112, 49);
            this.btn_AddNewService.TabIndex = 6;
            this.btn_AddNewService.Text = "أضافة جلسة جديده";
            this.btn_AddNewService.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(418, 323);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(112, 49);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "رجوع";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // FrmReservasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_AddNewService);
            this.Controls.Add(this.btn_ShowOldServices);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReservasion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة الحجز";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_SearchResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_PatientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Phone;
        private System.Windows.Forms.Button btn_AddPatient;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrd_SearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DOB;
        private System.Windows.Forms.Button btn_ShowOldServices;
        private System.Windows.Forms.Button btn_AddNewService;
        private System.Windows.Forms.Button btn_Back;
    }
}
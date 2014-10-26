namespace CenterReservation.INT.Reservasion
{
    partial class FrmShowOldReservasion
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
            this.dgrd_ShowVisits = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhysicianName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVisitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_ShowVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrd_ShowVisits
            // 
            this.dgrd_ShowVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_ShowVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PhysicianName,
            this.VisitName,
            this.VisitDate,
            this.To,
            this.TotalVisitPrice,
            this.VisitPrice,
            this.TimeFrom,
            this.TimeTo,
            this.Notes});
            this.dgrd_ShowVisits.GridColor = System.Drawing.Color.Black;
            this.dgrd_ShowVisits.Location = new System.Drawing.Point(7, 17);
            this.dgrd_ShowVisits.Name = "dgrd_ShowVisits";
            this.dgrd_ShowVisits.ReadOnly = true;
            this.dgrd_ShowVisits.RowHeadersVisible = false;
            this.dgrd_ShowVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrd_ShowVisits.Size = new System.Drawing.Size(846, 238);
            this.dgrd_ShowVisits.TabIndex = 23;
            // 
            // id
            // 
            this.id.HeaderText = "VisitID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // PhysicianName
            // 
            this.PhysicianName.HeaderText = "الأخصائى";
            this.PhysicianName.Name = "PhysicianName";
            this.PhysicianName.ReadOnly = true;
            this.PhysicianName.Width = 120;
            // 
            // VisitName
            // 
            this.VisitName.HeaderText = "نوع الزيارة";
            this.VisitName.Name = "VisitName";
            this.VisitName.ReadOnly = true;
            this.VisitName.Width = 120;
            // 
            // VisitDate
            // 
            this.VisitDate.HeaderText = "تاريخ الزيارة";
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "عدد الجلسات";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            this.To.Width = 80;
            // 
            // TotalVisitPrice
            // 
            this.TotalVisitPrice.HeaderText = "المبلغ المسدد";
            this.TotalVisitPrice.Name = "TotalVisitPrice";
            this.TotalVisitPrice.ReadOnly = true;
            this.TotalVisitPrice.Width = 80;
            // 
            // VisitPrice
            // 
            this.VisitPrice.HeaderText = "سعر الجلسة";
            this.VisitPrice.Name = "VisitPrice";
            this.VisitPrice.ReadOnly = true;
            this.VisitPrice.Width = 80;
            // 
            // TimeFrom
            // 
            this.TimeFrom.HeaderText = "التوقيت من";
            this.TimeFrom.Name = "TimeFrom";
            this.TimeFrom.ReadOnly = true;
            this.TimeFrom.Width = 80;
            // 
            // TimeTo
            // 
            this.TimeTo.HeaderText = "التوقيت إلى";
            this.TimeTo.Name = "TimeTo";
            this.TimeTo.ReadOnly = true;
            this.TimeTo.Width = 80;
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notes.HeaderText = "ملاحظات";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(769, 272);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(79, 47);
            this.btn_Back.TabIndex = 24;
            this.btn_Back.Text = "عودة";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // FrmShowOldReservasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 323);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgrd_ShowVisits);
            this.Name = "FrmShowOldReservasion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الحجوزات القديمة";
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_ShowVisits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrd_ShowVisits;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhysicianName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVisitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;


    }
}
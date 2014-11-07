namespace CenterReservation.INT.Reservasion
{
    partial class FrmAddNewReservasion
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
            this.cbx_Physycian = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_VisitType = new System.Windows.Forms.ComboBox();
            this.num_VisitsCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtb_From = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtb_To = new System.Windows.Forms.DateTimePicker();
            this.tbx_TotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtch_Notes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_RestPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_PaiedPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_VisitsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_Physycian
            // 
            this.cbx_Physycian.FormattingEnabled = true;
            this.cbx_Physycian.Location = new System.Drawing.Point(75, 21);
            this.cbx_Physycian.Name = "cbx_Physycian";
            this.cbx_Physycian.Size = new System.Drawing.Size(223, 21);
            this.cbx_Physycian.TabIndex = 0;
            this.cbx_Physycian.SelectedIndexChanged += new System.EventHandler(this.cbx_Physycian_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "الأخصائى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "نوع الجلسة";
            // 
            // cbx_VisitType
            // 
            this.cbx_VisitType.FormattingEnabled = true;
            this.cbx_VisitType.Location = new System.Drawing.Point(387, 21);
            this.cbx_VisitType.Name = "cbx_VisitType";
            this.cbx_VisitType.Size = new System.Drawing.Size(223, 21);
            this.cbx_VisitType.TabIndex = 1;
            this.cbx_VisitType.SelectedIndexChanged += new System.EventHandler(this.cbx_VisitType_SelectedIndexChanged);
            // 
            // num_VisitsCount
            // 
            this.num_VisitsCount.Location = new System.Drawing.Point(388, 64);
            this.num_VisitsCount.Name = "num_VisitsCount";
            this.num_VisitsCount.Size = new System.Drawing.Size(106, 20);
            this.num_VisitsCount.TabIndex = 4;
            this.num_VisitsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_VisitsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_VisitsCount.ValueChanged += new System.EventHandler(this.num_VisitsCount_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "عدد الجلسات";
            // 
            // dtb_From
            // 
            this.dtb_From.CustomFormat = "HH:MM";
            this.dtb_From.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtb_From.Location = new System.Drawing.Point(147, 65);
            this.dtb_From.Name = "dtb_From";
            this.dtb_From.Size = new System.Drawing.Size(151, 20);
            this.dtb_From.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ميعاد الجلسة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "من";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "إلى";
            // 
            // dtb_To
            // 
            this.dtb_To.CustomFormat = "HH:MM";
            this.dtb_To.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtb_To.Location = new System.Drawing.Point(147, 93);
            this.dtb_To.Name = "dtb_To";
            this.dtb_To.Size = new System.Drawing.Size(151, 20);
            this.dtb_To.TabIndex = 9;
            // 
            // tbx_TotalPrice
            // 
            this.tbx_TotalPrice.Enabled = false;
            this.tbx_TotalPrice.Location = new System.Drawing.Point(75, 132);
            this.tbx_TotalPrice.Name = "tbx_TotalPrice";
            this.tbx_TotalPrice.ReadOnly = true;
            this.tbx_TotalPrice.Size = new System.Drawing.Size(150, 20);
            this.tbx_TotalPrice.TabIndex = 11;
            this.tbx_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "المبلغ المطلوب";
            // 
            // rtch_Notes
            // 
            this.rtch_Notes.Location = new System.Drawing.Point(12, 258);
            this.rtch_Notes.Multiline = true;
            this.rtch_Notes.Name = "rtch_Notes";
            this.rtch_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rtch_Notes.Size = new System.Drawing.Size(594, 134);
            this.rtch_Notes.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ملاحظات";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(313, 428);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(79, 47);
            this.btn_Back.TabIndex = 16;
            this.btn_Back.Text = "عودة";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(226, 428);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(79, 47);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "المتبقى";
            // 
            // tbx_RestPrice
            // 
            this.tbx_RestPrice.Location = new System.Drawing.Point(75, 175);
            this.tbx_RestPrice.Name = "tbx_RestPrice";
            this.tbx_RestPrice.ReadOnly = true;
            this.tbx_RestPrice.Size = new System.Drawing.Size(150, 20);
            this.tbx_RestPrice.TabIndex = 17;
            this.tbx_RestPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "المبلغ المدفوع";
            // 
            // tbx_PaiedPrice
            // 
            this.tbx_PaiedPrice.Location = new System.Drawing.Point(387, 132);
            this.tbx_PaiedPrice.Name = "tbx_PaiedPrice";
            this.tbx_PaiedPrice.Size = new System.Drawing.Size(150, 20);
            this.tbx_PaiedPrice.TabIndex = 19;
            this.tbx_PaiedPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_PaiedPrice.TextChanged += new System.EventHandler(this.tbx_PaiedPrice_TextChanged);
            // 
            // FrmAddNewReservasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 492);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_PaiedPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_RestPrice);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtch_Notes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_TotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtb_To);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtb_From);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_VisitsCount);
            this.Controls.Add(this.cbx_VisitType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Physycian);
            this.Name = "FrmAddNewReservasion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حجز جلسه";
            ((System.ComponentModel.ISupportInitialize)(this.num_VisitsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Physycian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_VisitType;
        private System.Windows.Forms.NumericUpDown num_VisitsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtb_From;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtb_To;
        private System.Windows.Forms.TextBox tbx_TotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rtch_Notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_RestPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_PaiedPrice;
    }
}
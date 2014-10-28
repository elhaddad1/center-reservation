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
            this.SuspendLayout();
            // 
            // cbx_Physycian
            // 
            this.cbx_Physycian.FormattingEnabled = true;
            this.cbx_Physycian.Location = new System.Drawing.Point(75, 21);
            this.cbx_Physycian.Name = "cbx_Physycian";
            this.cbx_Physycian.Size = new System.Drawing.Size(223, 21);
            this.cbx_Physycian.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "الأخصائى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 24);
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
            this.cbx_VisitType.TabIndex = 4;
            // 
            // FrmAddNewReservasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 262);
            this.Controls.Add(this.cbx_VisitType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Physycian);
            this.Name = "FrmAddNewReservasion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حجز جلسه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Physycian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_VisitType;
    }
}
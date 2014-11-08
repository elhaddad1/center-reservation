namespace CenterReservation.INT
{
    partial class frm_MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.البياناتالرئيسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEditPhysicianWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.PhysicianPriceWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.VisitTypeWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPatiant = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الحجزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewReservasionWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProfitReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.البياناتالرئيسيةToolStripMenuItem,
            this.الحجزToolStripMenuItem,
            this.toolStripMenuItem1,
            this.التقاريرToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // البياناتالرئيسيةToolStripMenuItem
            // 
            this.البياناتالرئيسيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEditPhysicianWindow,
            this.PhysicianPriceWindow,
            this.VisitTypeWindow,
            this.ToolStripMenuItemPatiant,
            this.ToolStripMenuItem});
            this.البياناتالرئيسيةToolStripMenuItem.Name = "البياناتالرئيسيةToolStripMenuItem";
            this.البياناتالرئيسيةToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.البياناتالرئيسيةToolStripMenuItem.Text = "البيانات الرئيسية";
            // 
            // AddEditPhysicianWindow
            // 
            this.AddEditPhysicianWindow.Name = "AddEditPhysicianWindow";
            this.AddEditPhysicianWindow.Size = new System.Drawing.Size(174, 22);
            this.AddEditPhysicianWindow.Text = "أدخال وتعديل أخصائى";
            this.AddEditPhysicianWindow.Click += new System.EventHandler(this.AddEditPhysicianWindow_Click);
            // 
            // PhysicianPriceWindow
            // 
            this.PhysicianPriceWindow.Name = "PhysicianPriceWindow";
            this.PhysicianPriceWindow.Size = new System.Drawing.Size(174, 22);
            this.PhysicianPriceWindow.Text = "سعر الأخصائى";
            this.PhysicianPriceWindow.Click += new System.EventHandler(this.PhysicianPriceWindow_Click);
            // 
            // VisitTypeWindow
            // 
            this.VisitTypeWindow.Name = "VisitTypeWindow";
            this.VisitTypeWindow.Size = new System.Drawing.Size(174, 22);
            this.VisitTypeWindow.Text = "أدخال وتعديل الزيارات";
            this.VisitTypeWindow.Click += new System.EventHandler(this.VisitTypeWindow_Click);
            // 
            // ToolStripMenuItemPatiant
            // 
            this.ToolStripMenuItemPatiant.Name = "ToolStripMenuItemPatiant";
            this.ToolStripMenuItemPatiant.Size = new System.Drawing.Size(174, 22);
            this.ToolStripMenuItemPatiant.Text = "إدخال وتعديل المريض";
            this.ToolStripMenuItemPatiant.Click += new System.EventHandler(this.ToolStripMenuItemPatiant_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ToolStripMenuItem.Text = "سعر الزيارة";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // الحجزToolStripMenuItem
            // 
            this.الحجزToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewReservasionWindow});
            this.الحجزToolStripMenuItem.Name = "الحجزToolStripMenuItem";
            this.الحجزToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.الحجزToolStripMenuItem.Text = "الحجز";
            // 
            // NewReservasionWindow
            // 
            this.NewReservasionWindow.Name = "NewReservasionWindow";
            this.NewReservasionWindow.Size = new System.Drawing.Size(118, 22);
            this.NewReservasionWindow.Text = "حجز جديد";
            this.NewReservasionWindow.Click += new System.EventHandler(this.NewReservasionWindow_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // التقاريرToolStripMenuItem
            // 
            this.التقاريرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemProfitReport});
            this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
            this.التقاريرToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.التقاريرToolStripMenuItem.Text = "التقارير";
            // 
            // ToolStripMenuItemProfitReport
            // 
            this.ToolStripMenuItemProfitReport.Name = "ToolStripMenuItemProfitReport";
            this.ToolStripMenuItemProfitReport.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemProfitReport.Text = "تقرير الربح";
            this.ToolStripMenuItemProfitReport.Click += new System.EventHandler(this.ToolStripMenuItemProfitReport_Click);
            // 
            // frm_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 375);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem البياناتالرئيسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddEditPhysicianWindow;
        private System.Windows.Forms.ToolStripMenuItem PhysicianPriceWindow;
        private System.Windows.Forms.ToolStripMenuItem VisitTypeWindow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPatiant;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الحجزToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewReservasionWindow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProfitReport;
    }
}
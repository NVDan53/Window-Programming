namespace FinalProjectWin.View
{
    partial class FrmMain
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
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPerIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTask = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_show = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.miniToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(461, 34);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(452, 30);
            this.miniToolStrip.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItemSearch,
            this.menuItem4,
            this.menuItemExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 72);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem1
            // 
            this.menuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemStaff,
            this.menuItemPerIn});
            this.menuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(95, 68);
            this.menuItem1.Text = "&Category";
            // 
            // menuItemStaff
            // 
            this.menuItemStaff.Name = "menuItemStaff";
            this.menuItemStaff.Size = new System.Drawing.Size(259, 26);
            this.menuItemStaff.Text = "Staff";
            this.menuItemStaff.Click += new System.EventHandler(this.menuItemStaff_Click);
            // 
            // menuItemPerIn
            // 
            this.menuItemPerIn.Name = "menuItemPerIn";
            this.menuItemPerIn.Size = new System.Drawing.Size(259, 26);
            this.menuItemPerIn.Text = "Personal information";
            this.menuItemPerIn.Click += new System.EventHandler(this.menuItemPerIn_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAccount,
            this.menuItemDepartment,
            this.menuItemProject,
            this.menuItemTask,
            this.menuItemSalary});
            this.menuItem2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(86, 68);
            this.menuItem2.Text = "&Manage";
            // 
            // menuItemAccount
            // 
            this.menuItemAccount.Name = "menuItemAccount";
            this.menuItemAccount.Size = new System.Drawing.Size(224, 26);
            this.menuItemAccount.Text = "&Account";
            this.menuItemAccount.Click += new System.EventHandler(this.menuItemAccount_Click);
            // 
            // menuItemDepartment
            // 
            this.menuItemDepartment.Name = "menuItemDepartment";
            this.menuItemDepartment.Size = new System.Drawing.Size(224, 26);
            this.menuItemDepartment.Text = "&Department";
            this.menuItemDepartment.Click += new System.EventHandler(this.menuItemDepartment_Click);
            // 
            // menuItemProject
            // 
            this.menuItemProject.Name = "menuItemProject";
            this.menuItemProject.Size = new System.Drawing.Size(224, 26);
            this.menuItemProject.Text = "&Project";
            this.menuItemProject.Click += new System.EventHandler(this.menuItemProject_Click);
            // 
            // menuItemTask
            // 
            this.menuItemTask.Name = "menuItemTask";
            this.menuItemTask.Size = new System.Drawing.Size(224, 26);
            this.menuItemTask.Text = "&Task";
            this.menuItemTask.Click += new System.EventHandler(this.menuItemTask_Click);
            // 
            // menuItemSalary
            // 
            this.menuItemSalary.Name = "menuItemSalary";
            this.menuItemSalary.Size = new System.Drawing.Size(224, 26);
            this.menuItemSalary.Text = "&Salary";
            this.menuItemSalary.Click += new System.EventHandler(this.menuItemSalary_Click);
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItemSearch.Name = "menuItemSearch";
            this.menuItemSearch.Size = new System.Drawing.Size(78, 68);
            this.menuItemSearch.Text = "&Search";
            this.menuItemSearch.Click += new System.EventHandler(this.menuItemSearch_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(63, 68);
            this.menuItem4.Text = "&Help";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(56, 68);
            this.menuItemExit.Text = "&Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // panel_show
            // 
            this.panel_show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_show.Location = new System.Drawing.Point(0, 66);
            this.panel_show.Margin = new System.Windows.Forms.Padding(4);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1258, 630);
            this.panel_show.TabIndex = 18;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 709);
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private DevComponents.DotNetBar.BubbleBar barBubble;
        //private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab;
        //public DevComponents.DotNetBar.BubbleButton btntracuu;
        //public DevComponents.DotNetBar.BubbleButton btndmk;
        //private DevComponents.DotNetBar.BubbleButton btnchedo;
        //private DevComponents.DotNetBar.BubbleButton btnluong;
        //private DevComponents.DotNetBar.BubbleButton bubblenhansu;
        //private DevComponents.DotNetBar.BubbleButton bubblebophan;
        //private DevComponents.DotNetBar.BubbleButton bubblephongban;
        //private DevComponents.DotNetBar.BubbleButton bubbleBcnhanvien;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem menuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemStaff;
        private System.Windows.Forms.ToolStripMenuItem menuItemPerIn;
        public System.Windows.Forms.ToolStripMenuItem menuItemSearch;
        public System.Windows.Forms.ToolStripMenuItem menuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItemDepartment;
        private System.Windows.Forms.ToolStripMenuItem menuItemProject;
        private System.Windows.Forms.ToolStripMenuItem menuItemSalary;
        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.ToolStripMenuItem menuItemAccount;
        private System.Windows.Forms.ToolStripMenuItem menuItemTask;
        private System.Windows.Forms.ToolStripMenuItem menuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}
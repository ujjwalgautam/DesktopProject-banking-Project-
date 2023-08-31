namespace DesktopProject
{
    partial class Menu
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
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSearchAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem,
            this.updateSearchAccountToolStripMenuItem,
            this.allCustomersToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // updateSearchAccountToolStripMenuItem
            // 
            this.updateSearchAccountToolStripMenuItem.Name = "updateSearchAccountToolStripMenuItem";
            this.updateSearchAccountToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.updateSearchAccountToolStripMenuItem.Text = "Update/Search Account";
            this.updateSearchAccountToolStripMenuItem.Click += new System.EventHandler(this.updateSearchAccountToolStripMenuItem_Click);
            // 
            // allCustomersToolStripMenuItem
            // 
            this.allCustomersToolStripMenuItem.Name = "allCustomersToolStripMenuItem";
            this.allCustomersToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.allCustomersToolStripMenuItem.Text = "All Customers";
            this.allCustomersToolStripMenuItem.Click += new System.EventHandler(this.allCustomersToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceSheetToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // balanceSheetToolStripMenuItem
            // 
            this.balanceSheetToolStripMenuItem.Name = "balanceSheetToolStripMenuItem";
            this.balanceSheetToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.balanceSheetToolStripMenuItem.Text = "Balance Sheet";
            this.balanceSheetToolStripMenuItem.Click += new System.EventHandler(this.balanceSheetToolStripMenuItem_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logOutToolStripMenuItem.Text = "Logout";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 722);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem newCustomerToolStripMenuItem;
        private ToolStripMenuItem updateSearchAccountToolStripMenuItem;
        private ToolStripMenuItem allCustomersToolStripMenuItem;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripMenuItem depositToolStripMenuItem;
        private ToolStripMenuItem withdrawToolStripMenuItem;
        private ToolStripMenuItem transferToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem balanceSheetToolStripMenuItem;
        private ToolStripMenuItem othersToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
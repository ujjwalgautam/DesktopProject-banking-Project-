namespace DesktopProject
{
    partial class AllCustomers
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
            this.dataAllCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataAllCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAllCustomers
            // 
            this.dataAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAllCustomers.Location = new System.Drawing.Point(18, 20);
            this.dataAllCustomers.Name = "dataAllCustomers";
            this.dataAllCustomers.RowHeadersWidth = 51;
            this.dataAllCustomers.RowTemplate.Height = 29;
            this.dataAllCustomers.Size = new System.Drawing.Size(1051, 451);
            this.dataAllCustomers.TabIndex = 0;
            // 
            // AllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 483);
            this.Controls.Add(this.dataAllCustomers);
            this.Name = "AllCustomers";
            this.Text = "AllCustomers";
            this.Load += new System.EventHandler(this.AllCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAllCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataAllCustomers;
    }
}
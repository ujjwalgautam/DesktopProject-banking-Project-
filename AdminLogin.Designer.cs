namespace DesktopProject
{
    partial class AdminLogin
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
            this.textAdminPassword = new System.Windows.Forms.TextBox();
            this.textAdminUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAdminPassword
            // 
            this.textAdminPassword.Location = new System.Drawing.Point(107, 146);
            this.textAdminPassword.Name = "textAdminPassword";
            this.textAdminPassword.Size = new System.Drawing.Size(218, 27);
            this.textAdminPassword.TabIndex = 9;
            this.textAdminPassword.UseSystemPasswordChar = true;
            // 
            // textAdminUserName
            // 
            this.textAdminUserName.Location = new System.Drawing.Point(107, 90);
            this.textAdminUserName.Name = "textAdminUserName";
            this.textAdminUserName.Size = new System.Drawing.Size(218, 27);
            this.textAdminUserName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "UserName :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(140, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Login";
            // 
            // buttonAdminLogin
            // 
            this.buttonAdminLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdminLogin.Location = new System.Drawing.Point(140, 190);
            this.buttonAdminLogin.Name = "buttonAdminLogin";
            this.buttonAdminLogin.Size = new System.Drawing.Size(94, 40);
            this.buttonAdminLogin.TabIndex = 10;
            this.buttonAdminLogin.Text = "Login";
            this.buttonAdminLogin.UseVisualStyleBackColor = true;
            this.buttonAdminLogin.Click += new System.EventHandler(this.buttonAdminLogin_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 242);
            this.Controls.Add(this.buttonAdminLogin);
            this.Controls.Add(this.textAdminPassword);
            this.Controls.Add(this.textAdminUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textAdminPassword;
        private TextBox textAdminUserName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonAdminLogin;
    }
}
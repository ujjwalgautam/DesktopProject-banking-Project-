namespace DesktopProject
{
    partial class Transfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SAccNo = new System.Windows.Forms.TextBox();
            this.SName = new System.Windows.Forms.TextBox();
            this.RAccNo = new System.Windows.Forms.TextBox();
            this.RName = new System.Windows.Forms.TextBox();
            this.CBalance = new System.Windows.Forms.TextBox();
            this.TAmount = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.TransferA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senders Account No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senders Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receivers Account No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Receivers Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Current Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Transfer Amount";
            // 
            // SAccNo
            // 
            this.SAccNo.Location = new System.Drawing.Point(206, 51);
            this.SAccNo.Name = "SAccNo";
            this.SAccNo.Size = new System.Drawing.Size(234, 27);
            this.SAccNo.TabIndex = 7;
            // 
            // SName
            // 
            this.SName.Location = new System.Drawing.Point(206, 96);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(234, 27);
            this.SName.TabIndex = 8;
            // 
            // RAccNo
            // 
            this.RAccNo.Location = new System.Drawing.Point(206, 151);
            this.RAccNo.Name = "RAccNo";
            this.RAccNo.Size = new System.Drawing.Size(234, 27);
            this.RAccNo.TabIndex = 9;
            // 
            // RName
            // 
            this.RName.Location = new System.Drawing.Point(206, 205);
            this.RName.Name = "RName";
            this.RName.Size = new System.Drawing.Size(234, 27);
            this.RName.TabIndex = 10;
            // 
            // CBalance
            // 
            this.CBalance.Location = new System.Drawing.Point(206, 260);
            this.CBalance.Name = "CBalance";
            this.CBalance.Size = new System.Drawing.Size(234, 27);
            this.CBalance.TabIndex = 11;
            // 
            // TAmount
            // 
            this.TAmount.Location = new System.Drawing.Point(206, 315);
            this.TAmount.Name = "TAmount";
            this.TAmount.Size = new System.Drawing.Size(234, 27);
            this.TAmount.TabIndex = 12;
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.check.Location = new System.Drawing.Point(493, 134);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(94, 29);
            this.check.TabIndex = 13;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // TransferA
            // 
            this.TransferA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransferA.Location = new System.Drawing.Point(493, 213);
            this.TransferA.Name = "TransferA";
            this.TransferA.Size = new System.Drawing.Size(94, 29);
            this.TransferA.TabIndex = 14;
            this.TransferA.Text = "Transfer";
            this.TransferA.UseVisualStyleBackColor = true;
            this.TransferA.Click += new System.EventHandler(this.TransferA_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 360);
            this.Controls.Add(this.TransferA);
            this.Controls.Add(this.check);
            this.Controls.Add(this.TAmount);
            this.Controls.Add(this.CBalance);
            this.Controls.Add(this.RName);
            this.Controls.Add(this.RAccNo);
            this.Controls.Add(this.SName);
            this.Controls.Add(this.SAccNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox SAccNo;
        private TextBox SName;
        private TextBox RAccNo;
        private TextBox RName;
        private TextBox CBalance;
        private TextBox TAmount;
        private Button check;
        private Button TransferA;
    }
}
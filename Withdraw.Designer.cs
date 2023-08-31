namespace DesktopProject
{
    partial class Withdraw
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
            this.deposit = new System.Windows.Forms.Button();
            this.ckeck = new System.Windows.Forms.Button();
            this.mode = new System.Windows.Forms.ComboBox();
            this.depositAmount = new System.Windows.Forms.TextBox();
            this.OldBlc = new System.Windows.Forms.TextBox();
            this.accName = new System.Windows.Forms.TextBox();
            this.accNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(506, 136);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(94, 29);
            this.deposit.TabIndex = 23;
            this.deposit.Text = "Withdraw";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // ckeck
            // 
            this.ckeck.Location = new System.Drawing.Point(506, 78);
            this.ckeck.Name = "ckeck";
            this.ckeck.Size = new System.Drawing.Size(94, 29);
            this.ckeck.TabIndex = 22;
            this.ckeck.Text = "Check";
            this.ckeck.UseVisualStyleBackColor = true;
            this.ckeck.Click += new System.EventHandler(this.ckeck_Click);
            // 
            // mode
            // 
            this.mode.FormattingEnabled = true;
            this.mode.Location = new System.Drawing.Point(186, 193);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(191, 28);
            this.mode.TabIndex = 21;
            // 
            // depositAmount
            // 
            this.depositAmount.Location = new System.Drawing.Point(186, 248);
            this.depositAmount.Name = "depositAmount";
            this.depositAmount.Size = new System.Drawing.Size(191, 27);
            this.depositAmount.TabIndex = 20;
            // 
            // OldBlc
            // 
            this.OldBlc.Location = new System.Drawing.Point(186, 138);
            this.OldBlc.Name = "OldBlc";
            this.OldBlc.Size = new System.Drawing.Size(191, 27);
            this.OldBlc.TabIndex = 19;
            // 
            // accName
            // 
            this.accName.Location = new System.Drawing.Point(186, 88);
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(191, 27);
            this.accName.TabIndex = 18;
            // 
            // accNum
            // 
            this.accNum.Location = new System.Drawing.Point(186, 40);
            this.accNum.Name = "accNum";
            this.accNum.Size = new System.Drawing.Size(191, 27);
            this.accNum.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Withdraw Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Old Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Account Number";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 307);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.ckeck);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.depositAmount);
            this.Controls.Add(this.OldBlc);
            this.Controls.Add(this.accName);
            this.Controls.Add(this.accNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deposit;
        private Button ckeck;
        private ComboBox mode;
        private TextBox depositAmount;
        private TextBox OldBlc;
        private TextBox accName;
        private TextBox accNum;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
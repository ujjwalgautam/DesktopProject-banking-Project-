namespace DesktopProject
{
    partial class DepositCash
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
            this.label5 = new System.Windows.Forms.Label();
            this.accNum = new System.Windows.Forms.TextBox();
            this.accName = new System.Windows.Forms.TextBox();
            this.OldBlc = new System.Windows.Forms.TextBox();
            this.depositAmount = new System.Windows.Forms.TextBox();
            this.mode = new System.Windows.Forms.ComboBox();
            this.ckeck = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Old Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Deposit Amount";
            // 
            // accNum
            // 
            this.accNum.Location = new System.Drawing.Point(182, 55);
            this.accNum.Name = "accNum";
            this.accNum.Size = new System.Drawing.Size(191, 27);
            this.accNum.TabIndex = 5;
            // 
            // accName
            // 
            this.accName.Location = new System.Drawing.Point(182, 103);
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(191, 27);
            this.accName.TabIndex = 6;
            // 
            // OldBlc
            // 
            this.OldBlc.Location = new System.Drawing.Point(182, 153);
            this.OldBlc.Name = "OldBlc";
            this.OldBlc.Size = new System.Drawing.Size(191, 27);
            this.OldBlc.TabIndex = 7;
            // 
            // depositAmount
            // 
            this.depositAmount.Location = new System.Drawing.Point(182, 263);
            this.depositAmount.Name = "depositAmount";
            this.depositAmount.Size = new System.Drawing.Size(191, 27);
            this.depositAmount.TabIndex = 8;
            // 
            // mode
            // 
            this.mode.FormattingEnabled = true;
            this.mode.Location = new System.Drawing.Point(182, 208);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(191, 28);
            this.mode.TabIndex = 9;
            // 
            // ckeck
            // 
            this.ckeck.Location = new System.Drawing.Point(502, 93);
            this.ckeck.Name = "ckeck";
            this.ckeck.Size = new System.Drawing.Size(94, 29);
            this.ckeck.TabIndex = 10;
            this.ckeck.Text = "Check";
            this.ckeck.UseVisualStyleBackColor = true;
            this.ckeck.Click += new System.EventHandler(this.ckeck_Click);
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(502, 151);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(94, 29);
            this.deposit.TabIndex = 11;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // DepositCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "DepositCash";
            this.Text = "DepositCash";
            this.Load += new System.EventHandler(this.DepositCash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox accNum;
        private TextBox accName;
        private TextBox OldBlc;
        private TextBox depositAmount;
        private ComboBox mode;
        private Button ckeck;
        private Button deposit;
    }
}
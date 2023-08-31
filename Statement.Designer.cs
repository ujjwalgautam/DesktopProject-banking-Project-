namespace DesktopProject
{
    partial class Statement
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
            this.name = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.ANo = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.withdraw = new System.Windows.Forms.DataGridView();
            this.received = new System.Windows.Forms.DataGridView();
            this.sent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Deposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.received)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Balance";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(119, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(183, 27);
            this.name.TabIndex = 3;
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(584, 49);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(183, 27);
            this.balance.TabIndex = 4;
            // 
            // ANo
            // 
            this.ANo.Location = new System.Drawing.Point(119, 74);
            this.ANo.Name = "ANo";
            this.ANo.Size = new System.Drawing.Size(183, 27);
            this.ANo.TabIndex = 5;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(334, 47);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(94, 29);
            this.check.TabIndex = 6;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // Deposit
            // 
            this.Deposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Deposit.Location = new System.Drawing.Point(35, 149);
            this.Deposit.Name = "Deposit";
            this.Deposit.RowHeadersWidth = 51;
            this.Deposit.RowTemplate.Height = 29;
            this.Deposit.Size = new System.Drawing.Size(433, 128);
            this.Deposit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Deposit Statement :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sent Statement :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Withdraw Statement :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Received Statement :";
            // 
            // withdraw
            // 
            this.withdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.withdraw.Location = new System.Drawing.Point(512, 149);
            this.withdraw.Name = "withdraw";
            this.withdraw.RowHeadersWidth = 51;
            this.withdraw.RowTemplate.Height = 29;
            this.withdraw.Size = new System.Drawing.Size(431, 128);
            this.withdraw.TabIndex = 12;
            this.withdraw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.withdraw_CellContentClick);
            // 
            // received
            // 
            this.received.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.received.Location = new System.Drawing.Point(512, 335);
            this.received.Name = "received";
            this.received.RowHeadersWidth = 51;
            this.received.RowTemplate.Height = 29;
            this.received.Size = new System.Drawing.Size(431, 128);
            this.received.TabIndex = 14;
            this.received.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.received_CellContentClick);
            // 
            // sent
            // 
            this.sent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sent.Location = new System.Drawing.Point(35, 335);
            this.sent.Name = "sent";
            this.sent.RowHeadersWidth = 51;
            this.sent.RowTemplate.Height = 29;
            this.sent.Size = new System.Drawing.Size(433, 128);
            this.sent.TabIndex = 13;
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 484);
            this.Controls.Add(this.received);
            this.Controls.Add(this.sent);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.check);
            this.Controls.Add(this.ANo);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statement";
            this.Text = "Statement";
            this.Load += new System.EventHandler(this.Statement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Deposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.received)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox balance;
        private TextBox ANo;
        private Button check;
        private DataGridView Deposit;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView withdraw;
        private DataGridView received;
        private DataGridView sent;
    }
}
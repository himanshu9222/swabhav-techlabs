namespace Banking_App
{
    partial class Transaction
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
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.depositRadioBtn = new System.Windows.Forms.RadioButton();
            this.withdrawRadioBtn = new System.Windows.Forms.RadioButton();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount :";
            // 
            // amountTextbox
            // 
            this.amountTextbox.Location = new System.Drawing.Point(164, 95);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(100, 20);
            this.amountTextbox.TabIndex = 1;
            // 
            // depositRadioBtn
            // 
            this.depositRadioBtn.AutoSize = true;
            this.depositRadioBtn.Location = new System.Drawing.Point(164, 150);
            this.depositRadioBtn.Name = "depositRadioBtn";
            this.depositRadioBtn.Size = new System.Drawing.Size(61, 17);
            this.depositRadioBtn.TabIndex = 2;
            this.depositRadioBtn.TabStop = true;
            this.depositRadioBtn.Text = "Deposit";
            this.depositRadioBtn.UseVisualStyleBackColor = true;
            // 
            // withdrawRadioBtn
            // 
            this.withdrawRadioBtn.AutoSize = true;
            this.withdrawRadioBtn.Location = new System.Drawing.Point(164, 173);
            this.withdrawRadioBtn.Name = "withdrawRadioBtn";
            this.withdrawRadioBtn.Size = new System.Drawing.Size(70, 17);
            this.withdrawRadioBtn.TabIndex = 3;
            this.withdrawRadioBtn.TabStop = true;
            this.withdrawRadioBtn.Text = "Withdraw";
            this.withdrawRadioBtn.UseVisualStyleBackColor = true;
            // 
            // transactionBtn
            // 
            this.transactionBtn.Location = new System.Drawing.Point(128, 227);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(75, 23);
            this.transactionBtn.TabIndex = 4;
            this.transactionBtn.Text = "Transact";
            this.transactionBtn.UseVisualStyleBackColor = true;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(177, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 363);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.transactionBtn);
            this.Controls.Add(this.withdrawRadioBtn);
            this.Controls.Add(this.depositRadioBtn);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.RadioButton depositRadioBtn;
        private System.Windows.Forms.RadioButton withdrawRadioBtn;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Label nameLabel;
    }
}
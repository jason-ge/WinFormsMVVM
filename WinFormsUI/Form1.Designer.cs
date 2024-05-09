namespace WinFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBiller = new Label();
            cboBillers = new ComboBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            rdbCash = new RadioButton();
            rdbCheque = new RadioButton();
            rdbAccount = new RadioButton();
            lblPaymentSource = new Label();
            btnPay = new Button();
            SuspendLayout();
            // 
            // lblBiller
            // 
            lblBiller.AutoSize = true;
            lblBiller.Location = new Point(37, 31);
            lblBiller.Name = "lblBiller";
            lblBiller.Size = new Size(43, 20);
            lblBiller.TabIndex = 0;
            lblBiller.Text = "Biller";
            // 
            // cboBillers
            // 
            cboBillers.FormattingEnabled = true;
            cboBillers.Location = new Point(187, 28);
            cboBillers.Name = "cboBillers";
            cboBillers.Size = new Size(375, 28);
            cboBillers.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(37, 93);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 20);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(184, 86);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(378, 27);
            txtAmount.TabIndex = 3;
            // 
            // rdbCash
            // 
            rdbCash.AutoSize = true;
            rdbCash.CausesValidation = false;
            rdbCash.Location = new Point(187, 155);
            rdbCash.Name = "rdbCash";
            rdbCash.Size = new Size(61, 24);
            rdbCash.TabIndex = 5;
            rdbCash.Text = "Cash";
            rdbCash.UseVisualStyleBackColor = true;
            // 
            // rdbCheque
            // 
            rdbCheque.AutoSize = true;
            rdbCheque.CausesValidation = false;
            rdbCheque.Location = new Point(311, 155);
            rdbCheque.Name = "rdbCheque";
            rdbCheque.Size = new Size(80, 24);
            rdbCheque.TabIndex = 5;
            rdbCheque.Text = "Cheque";
            rdbCheque.UseVisualStyleBackColor = true;
            // 
            // rdbAccount
            // 
            rdbAccount.AutoSize = true;
            rdbAccount.CausesValidation = false;
            rdbAccount.Location = new Point(436, 155);
            rdbAccount.Name = "rdbAccount";
            rdbAccount.Size = new Size(84, 24);
            rdbAccount.TabIndex = 5;
            rdbAccount.Text = "Account";
            rdbAccount.UseVisualStyleBackColor = true;
            // 
            // lblPaymentSource
            // 
            lblPaymentSource.AutoSize = true;
            lblPaymentSource.Location = new Point(37, 155);
            lblPaymentSource.Name = "lblPaymentSource";
            lblPaymentSource.Size = new Size(114, 20);
            lblPaymentSource.TabIndex = 6;
            lblPaymentSource.Text = "Payment Source";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(187, 217);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(94, 29);
            btnPay.TabIndex = 7;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 355);
            Controls.Add(rdbAccount);
            Controls.Add(rdbCheque);
            Controls.Add(rdbCash);
            Controls.Add(btnPay);
            Controls.Add(lblPaymentSource);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(cboBillers);
            Controls.Add(lblBiller);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBiller;
        private ComboBox cboBillers;
        private Label lblAmount;
        private TextBox txtAmount;
        private RadioButton rdbCash;
        private RadioButton rdbCheque;
        private RadioButton rdbAccount;
        private Label lblPaymentSource;
        private Button btnPay;
    }
}
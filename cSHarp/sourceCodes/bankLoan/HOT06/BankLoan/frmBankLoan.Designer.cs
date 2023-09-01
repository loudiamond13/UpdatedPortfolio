namespace BankLoan
{
    partial class frmBankLoan
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
            this.gbCreateLoan = new System.Windows.Forms.GroupBox();
            this.rdoLongTermLoan = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.txtAMT = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rdoShortTermLoan = new System.Windows.Forms.RadioButton();
            this.gbManageLoan = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lblAfterPaymentIntrst = new System.Windows.Forms.Label();
            this.lblAfterPaymentAMT = new System.Windows.Forms.Label();
            this.lblLoanAMT = new System.Windows.Forms.Label();
            this.lblTypeOfLoan = new System.Windows.Forms.Label();
            this.lblLoanInfo = new System.Windows.Forms.Label();
            this.gbCreateLoan.SuspendLayout();
            this.gbManageLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreateLoan
            // 
            this.gbCreateLoan.Controls.Add(this.rdoLongTermLoan);
            this.gbCreateLoan.Controls.Add(this.lblType);
            this.gbCreateLoan.Controls.Add(this.btnClear);
            this.gbCreateLoan.Controls.Add(this.btnCreateLoan);
            this.gbCreateLoan.Controls.Add(this.txtAMT);
            this.gbCreateLoan.Controls.Add(this.txtName);
            this.gbCreateLoan.Controls.Add(this.lblAmount);
            this.gbCreateLoan.Controls.Add(this.lblName);
            this.gbCreateLoan.Controls.Add(this.rdoShortTermLoan);
            this.gbCreateLoan.Location = new System.Drawing.Point(34, 44);
            this.gbCreateLoan.Name = "gbCreateLoan";
            this.gbCreateLoan.Size = new System.Drawing.Size(744, 330);
            this.gbCreateLoan.TabIndex = 0;
            this.gbCreateLoan.TabStop = false;
            this.gbCreateLoan.Text = "Create Loan";
            // 
            // rdoLongTermLoan
            // 
            this.rdoLongTermLoan.Location = new System.Drawing.Point(192, 267);
            this.rdoLongTermLoan.Name = "rdoLongTermLoan";
            this.rdoLongTermLoan.Size = new System.Drawing.Size(349, 40);
            this.rdoLongTermLoan.TabIndex = 3;
            this.rdoLongTermLoan.TabStop = true;
            this.rdoLongTermLoan.Text = "Long Term Loan";
            this.rdoLongTermLoan.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(26, 210);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(145, 51);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type :";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(547, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 51);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(547, 47);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(141, 51);
            this.btnCreateLoan.TabIndex = 4;
            this.btnCreateLoan.Text = "Create Loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // txtAMT
            // 
            this.txtAMT.Location = new System.Drawing.Point(192, 123);
            this.txtAMT.Multiline = true;
            this.txtAMT.Name = "txtAMT";
            this.txtAMT.Size = new System.Drawing.Size(349, 51);
            this.txtAMT.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 47);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(349, 51);
            this.txtName.TabIndex = 0;
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(26, 123);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(145, 51);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount :";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(26, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 51);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoShortTermLoan
            // 
            this.rdoShortTermLoan.Location = new System.Drawing.Point(192, 221);
            this.rdoShortTermLoan.Name = "rdoShortTermLoan";
            this.rdoShortTermLoan.Size = new System.Drawing.Size(349, 40);
            this.rdoShortTermLoan.TabIndex = 2;
            this.rdoShortTermLoan.TabStop = true;
            this.rdoShortTermLoan.Text = "Short Term Loan";
            this.rdoShortTermLoan.UseVisualStyleBackColor = true;
            // 
            // gbManageLoan
            // 
            this.gbManageLoan.Controls.Add(this.btnExit);
            this.gbManageLoan.Controls.Add(this.btnMakePayment);
            this.gbManageLoan.Controls.Add(this.lblAfterPaymentIntrst);
            this.gbManageLoan.Controls.Add(this.lblAfterPaymentAMT);
            this.gbManageLoan.Controls.Add(this.lblLoanAMT);
            this.gbManageLoan.Controls.Add(this.lblTypeOfLoan);
            this.gbManageLoan.Controls.Add(this.lblLoanInfo);
            this.gbManageLoan.Location = new System.Drawing.Point(34, 416);
            this.gbManageLoan.Name = "gbManageLoan";
            this.gbManageLoan.Size = new System.Drawing.Size(744, 330);
            this.gbManageLoan.TabIndex = 1;
            this.gbManageLoan.TabStop = false;
            this.gbManageLoan.Text = "Manage Loan";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(565, 106);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(565, 46);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(173, 51);
            this.btnMakePayment.TabIndex = 0;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lblAfterPaymentIntrst
            // 
            this.lblAfterPaymentIntrst.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblAfterPaymentIntrst.Location = new System.Drawing.Point(26, 236);
            this.lblAfterPaymentIntrst.Name = "lblAfterPaymentIntrst";
            this.lblAfterPaymentIntrst.Size = new System.Drawing.Size(692, 43);
            this.lblAfterPaymentIntrst.TabIndex = 6;
            // 
            // lblAfterPaymentAMT
            // 
            this.lblAfterPaymentAMT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblAfterPaymentAMT.Location = new System.Drawing.Point(26, 172);
            this.lblAfterPaymentAMT.Name = "lblAfterPaymentAMT";
            this.lblAfterPaymentAMT.Size = new System.Drawing.Size(692, 43);
            this.lblAfterPaymentAMT.TabIndex = 5;
            // 
            // lblLoanAMT
            // 
            this.lblLoanAMT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblLoanAMT.Location = new System.Drawing.Point(354, 114);
            this.lblLoanAMT.Name = "lblLoanAMT";
            this.lblLoanAMT.Size = new System.Drawing.Size(205, 43);
            this.lblLoanAMT.TabIndex = 4;
            // 
            // lblTypeOfLoan
            // 
            this.lblTypeOfLoan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTypeOfLoan.Location = new System.Drawing.Point(26, 114);
            this.lblTypeOfLoan.Name = "lblTypeOfLoan";
            this.lblTypeOfLoan.Size = new System.Drawing.Size(306, 43);
            this.lblTypeOfLoan.TabIndex = 3;
            // 
            // lblLoanInfo
            // 
            this.lblLoanInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblLoanInfo.Location = new System.Drawing.Point(26, 54);
            this.lblLoanInfo.Name = "lblLoanInfo";
            this.lblLoanInfo.Size = new System.Drawing.Size(533, 43);
            this.lblLoanInfo.TabIndex = 2;
            // 
            // frmBankLoan
            // 
            this.AcceptButton = this.btnMakePayment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 773);
            this.Controls.Add(this.gbManageLoan);
            this.Controls.Add(this.gbCreateLoan);
            this.Name = "frmBankLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Loan";
            this.gbCreateLoan.ResumeLayout(false);
            this.gbCreateLoan.PerformLayout();
            this.gbManageLoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreateLoan;
        private System.Windows.Forms.GroupBox gbManageLoan;
        private System.Windows.Forms.RadioButton rdoShortTermLoan;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rdoLongTermLoan;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.TextBox txtAMT;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblAfterPaymentIntrst;
        private System.Windows.Forms.Label lblAfterPaymentAMT;
        private System.Windows.Forms.Label lblLoanAMT;
        private System.Windows.Forms.Label lblTypeOfLoan;
        private System.Windows.Forms.Label lblLoanInfo;
    }
}


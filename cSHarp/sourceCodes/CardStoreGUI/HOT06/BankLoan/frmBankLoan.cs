using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLoan
{
    public partial class frmBankLoan : Form
    {
        public frmBankLoan()
        {
            InitializeComponent();
            btnMakePayment.Enabled = false;
        }

        // const global variables
        decimal balance         = 0m;   //loan balance
        decimal plusInterest    = 0m;   //with interest 


        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all
            btnMakePayment.Enabled = false;

            txtAMT.Text = "";
            txtName.Text = "";

            lblAfterPaymentAMT.Text = "";
            lblAfterPaymentIntrst.Text = "";
            lblTypeOfLoan.Text = "";
            lblLoanAMT.Text = "";
            lblLoanInfo.Text = "";
           
            
            rdoLongTermLoan.Checked = false;
            rdoShortTermLoan.Checked = false;

            txtName.Focus();
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramQuestion();
        }

        private void exitProgramQuestion()
        {
            DialogResult dialog = MessageBox.Show(
                   "Do You Really Want To Exit The Program?",
                   "EXIT NOW?",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
           

            validateInput();
        }

        private void validateInput()    
        {
           
            string message  = "";

            
            message += validateNameInput();     //validate name entry and 
            message += validateAmountInput();   //amount entry
            message += validteTypeOfLoan();     //validate if one radio is cheked

            if (message != "")
            {
                MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                btnMakePayment.Enabled = true;
            }

            return ;
        
        }

        private string validteTypeOfLoan() 
        {
            string message = "";

            if ((rdoLongTermLoan.Checked == false && (rdoShortTermLoan.Checked == false)))
            {
                message = "\nPlease Select One Type Of Loan!";
            }


            return message;
        }
        private string validateAmountInput() 
        {

            string message = "";

           
            // try if it can be parsed
            bool validateNumber = decimal.TryParse(txtAMT.Text, out _);
            if (!validateNumber)
            {
                message = "\nPlease Enter A Valid Number!";
            }

            return message;
        }
        private string validateNameInput() 
        {
            string message = "";

            if (txtName.Text.Trim() == "")
            {
                message = "Please Input A Valid Name!";
            }
            return message;
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            decimal loanAMT = Convert.ToDecimal(txtAMT.Text);
            if (rdoShortTermLoan.Checked == true)       //if short term is selected
            {                                           // calculate -450, 10%
                
                calculatePaymentAndInterestForSTLoan(loanAMT);

            }
            else if (rdoLongTermLoan.Checked == true)   //if long term is selected, calculate
            {                                           //-200, 5%
                calculatePaymentAndInterestForLTLoan(loanAMT);
            
            }

            
        }

        private void calculatePaymentAndInterestForSTLoan(decimal loanAMT)
        {
            
            
            STLoan newLoanST = new STLoan(txtName.Text, rdoShortTermLoan.Text, loanAMT);

            // calculates and minus when payment is made
           
                btnMakePayment.Enabled = true;
                balance = newLoanST.MakePayment();
                plusInterest = newLoanST.ApplyInterest(balance);

            displayPaymentInfo(balance, plusInterest);


        }
        private void calculatePaymentAndInterestForLTLoan(decimal loanAMT)
        {
            
            LTLoan newLoanLT = new LTLoan(txtName.Text, rdoShortTermLoan.Text, loanAMT);

            // calculates and minus when payment is made

            btnMakePayment.Enabled = true;
            balance = newLoanLT.MakePayment();
            plusInterest = newLoanLT.ApplyInterest(balance);

            

            

            displayPaymentInfo(balance, plusInterest);
        }

        private void displayPaymentInfo(decimal loanAMTbalance, decimal interest)
        {
            if (rdoLongTermLoan.Checked == true)
            {
                lblTypeOfLoan.Text = rdoLongTermLoan.Text;
            }
            else if (rdoShortTermLoan.Checked == true)
            {
                lblTypeOfLoan.Text = rdoShortTermLoan.Text;

            }

            lblLoanInfo.Text = txtName.Text;
            
            lblLoanAMT.Text = txtAMT.Text;
            lblAfterPaymentAMT.Text = $"After the last payment, The Loan is down to {loanAMTbalance.ToString("c")}";
            lblAfterPaymentIntrst.Text = $"After the last interest accumulation the loan is Now {interest.ToString("c")}";

        }
    }
}

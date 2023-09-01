using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HOT02
{
    public partial class shirtDiscountGUI : Form
    {
        public shirtDiscountGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearScreen();
        }
        private void clearScreen() 
        {
            txtDiscCode.Text = "";
            txtQTY.Text = "";
            txtResult.Text = "";

            txtQTY.Focus();
            return;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {



            //declaring variables
            bool validInput;

            // gets users input 
            string discCode = txtDiscCode.Text;
            decimal discount = 0; //= decimal.Parse(discCode);


            validInput = validateInput();    // validate inputs

            if (!validInput) // if not valid, show error.
            {
                invalidInput();
            }

            // else if inputs are valid, perform calculation
            else if (validInput)
            {
                // take the qty.
                int inputQTY = int.Parse(txtQTY.Text);


                discount = checkDiscountCode(discCode);


                // show invoice/result to the user.
                showInvoice(inputQTY, discount);
            }
            else 
            {
                return;
            }


        }

        private void showInvoice(int qty, decimal discount)
        {
            // declaring constants and initializing

             const decimal PRICE = 13.75m;
             const decimal TAX = 0.08m;

            // declaring calculation variables 
            decimal total = 0;
            decimal afterTax = 0; 
            decimal priceAfterDisc = 0;
            decimal subTotal = 0;

            decimal disc30 = 0.3m;
            decimal disc20 = 0.2m;
            decimal disc10 = 0.1m;


            // check where the discount belongs, if no discount, do default
            switch (discount)
            {
                case 0.3m:  // if the discount is 30% (8264)
                    priceAfterDisc = PRICE * disc30;
                    priceAfterDisc = PRICE - priceAfterDisc;
                    subTotal = priceAfterDisc * qty;
                    afterTax = TAX * subTotal;
                    total = afterTax + subTotal;
                    break;

                case 0.2m:      // if the discount is 20% (5679)
                    priceAfterDisc = PRICE * disc20;
                    priceAfterDisc = PRICE - priceAfterDisc;
                    subTotal = priceAfterDisc * qty;
                    afterTax = TAX * subTotal;
                    total = afterTax + subTotal;
                    break;

                case 0.1m:      // if the discount is 10% (6483)
                    priceAfterDisc = PRICE * disc10;
                    priceAfterDisc = PRICE - priceAfterDisc;
                    subTotal = priceAfterDisc * qty;
                    afterTax = TAX * subTotal;
                    total = afterTax + subTotal;
                    break;

                default:    // No discount!!!!!
                    priceAfterDisc = PRICE;
                    subTotal = PRICE * qty;
                    afterTax = TAX * subTotal;
                    total = afterTax + subTotal;
                    break;
            }




            //display results/ totals
            
            txtResult.AppendText(qty + " T-shirts @ $" + priceAfterDisc.ToString("n2") + " each");
            txtResult.AppendText(Environment.NewLine);
            txtResult.AppendText("------------------------------");
            txtResult.AppendText(Environment.NewLine);
            txtResult.AppendText("Subtotal: \t\t $"  + subTotal.ToString("n2"));
            txtResult.AppendText(Environment.NewLine);
            txtResult.AppendText("Tax: \t\t $" + afterTax.ToString("n2"));
            txtResult.AppendText(Environment.NewLine);
            txtResult.AppendText("Total: \t\t $"+ total.ToString("n2"));
            txtResult.AppendText(Environment.NewLine); 
            txtResult.AppendText(Environment.NewLine);
            txtResult.AppendText(Environment.NewLine);

            txtQTY.Focus();
            return;
        }
        private decimal checkDiscountCode(string discCode)
        {
            //declaring local variable
            decimal discPercent = 0;

            // checking the disc code and returning discount percentage if valid
            switch (discCode) 
            {
                case "8264":
                    discPercent = 0.3m;
                    break;

                case "5679":
                    discPercent = 0.2m;
                    break;
                case "6483":
                    discPercent = 0.1m;
                    break;
                default:
                    discPercent = 0;
                    break;

            }


            return discPercent;
        }

        private bool validateInput()
        {
            //declaring variables and boolean
            bool isValid;

            int number = 0;

            // checks if quantity input is valid, must be integer
            // returns false if input is empty or not integer
            bool validQTY = int.TryParse((txtQTY.Text).Trim(), out number);


            // if not valid input, return false
            if (!validQTY)  
            {
                isValid = false;
            }
            // if qty input is < 0, return false
          else if(number < 0)
           {
                
               
               isValid = false;

           }
            else { isValid = true; }

           

            
            return isValid;
        }

        
        private void invalidInput() 
        {
            MessageBox.Show("Please Enter A Valid Number!",
                   "Invalid Input",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

            txtQTY.Focus();
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

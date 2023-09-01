using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawnCareGUIhot
{
    public partial class LawnCare : Form
    {
        public LawnCare()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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


        private void invalidInputMessage()
        {
            MessageBox.Show("Please Enter A Valid Number! ",
                   "Invalid Input",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

            txtLength.Focus();
            return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTexts();
        }

        private void clearTexts()
        {
            txtResult.Text = string.Empty;
            txtLength.Text = string.Empty;
            txtWidth.Text = string.Empty;

            txtLength.Focus();
            return;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //validate inputs
            validateInput();

            
        }

       

        

        private void validateInput() 
        {
            // initializing and declaring var
            int length;
            int width;

            //checking if inputs  are valid 
            bool validLength = int.TryParse(txtLength.Text.Trim(), out length);
            bool validWidth = int.TryParse(txtWidth.Text.Trim(), out width);


            // if one of the inputs are invalid, show error
            if (!validLength || !validWidth)
            {
                invalidInputMessage();

            }
            //if one of the inputs are less than || = zero, show error
            else if (length <= 0 || width <= 0)
            {
                invalidInputMessage();

            }
            // if inputs are valid, perform calculation
            else { lawnCareCalculation(); }
        }


        private void lawnCareCalculation()
        {
            // declaring and initializing variables
            int length = int.Parse(txtLength.Text);
            int width = int.Parse(txtWidth.Text);
            int area = 0;
            int fee = 0;
            int total = 0;

            // initializing and declaring const 
            const int MOWseason = 20;               // mowing season 20 weeks
            const int SQF600 = 600;                 // 600 square feet
            const int SQF400 = 400;                 // 400 square feet



            //get the area  (length * Width)
            area = length * width;

            //if area is >= 600 square feet, fee 50
            if (area >= SQF600)
            {
                fee = 50;
                total = MOWseason * fee;

            }
            // if area is 400>==<600 sqfeet, fee 35$ 
            else if ((area >= SQF400) && (area <= SQF600))
            {
                fee = 35;
                total = MOWseason * fee;

            }
            //if area is <400sqf 25$ fee 
            else if (area < SQF400)
            {
                fee = 25;
                total = MOWseason * fee;
            }


            // display result 
            txtResult.AppendText("Area : \t\t" + area + " Square Feet");
            txtResult.AppendText(Environment.NewLine);
            txtResult.AppendText("Weekly Fee : \t" + fee.ToString("c"));
            txtResult.AppendText(Environment.NewLine);
            txtResult.AppendText("Season Length : \t" + MOWseason + " Weeks");
            txtResult.AppendText(Environment.NewLine);
            txtResult.AppendText("Total : \t\t" + total.ToString("c"));
            txtResult.AppendText(Environment.NewLine);

            txtResult.AppendText(Environment.NewLine);
            txtResult.AppendText(Environment.NewLine);



            txtLength.Focus();
            return;

        }
    }
}

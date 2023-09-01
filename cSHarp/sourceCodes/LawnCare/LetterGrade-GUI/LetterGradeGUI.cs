using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterGrade_GUI
{
    public partial class LetterGradeGUI : Form
    {
        public LetterGradeGUI()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid;
            // validate input
            valid = validateInput();

            if (!valid) // if invalid input show invalid message
            {
                invalidInputMessage();
            }
            else    // if valid calculate input to letter grade
            {
                calculateToLetterGrade();
            }
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            clearScreen();

        }

        private void clearScreen()
        {
            txtNumGrade.Text = "";
            txtResult.Text = "";

            txtNumGrade.Focus();
            return;
        }

        private void button3_Click(object sender, EventArgs e)
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
        

        private void lblResult_Click(object sender, EventArgs e)
        {
            
           
        }

        // declaring constants
        const decimal AgradeMAX = 4.0m;

        const decimal Bgrade = 3.2m;
        const decimal Cgrade = 2.5m;
        const decimal Dgrade = 1.5m;
        const decimal FgradeMIN = 0.0m;

        private void calculateToLetterGrade()
        {
        


            // declaring variables
            decimal numGrade = Convert.ToDecimal(txtNumGrade.Text);

            string resultLetter = "";
           
            // if number grade is > 3.2 = A grade 
            if ((numGrade > Bgrade )&& (numGrade <= AgradeMAX))
            {
                resultLetter = "A";
            }

            // if number grade is > 2.5 = B grade 
            else if ((numGrade > Cgrade) && (numGrade <= Bgrade))
            {
                resultLetter = "B";
            }
            // if number grade is > 1.5 = C grade 
            else if ((numGrade > Dgrade) && (numGrade <= Cgrade))
            {
                resultLetter = "C";
            }
            // if number grade is < 1.5 = D grade 
            else if ((numGrade > FgradeMIN) && (numGrade <= Dgrade))
            {
                resultLetter = "D";
            }

            // if number grade is equal to 0 = A grade 
            else if ((numGrade == FgradeMIN))
            {
                resultLetter = "F";
            }

          

            // display result
            txtResult.AppendText("Your Letter Grade Is : " + resultLetter);
            txtResult.AppendText(Environment.NewLine);

            return;

        }

        private bool validateInput()
        {
            // declaring variables and boolean
            bool isValid;
            decimal num;

            //decimal userInput = decimal.Parse(txtNumGrade.Text);

            bool numInput = decimal.TryParse(txtNumGrade.Text, out num);

            // if not valid 
            if (!numInput)
            {
                isValid = false;
            }
            // if less that 0 or more than max 4, show error
            else if (num > 4 || num < 0)  
            {
                isValid = false;
            }

            // if input is empty show error
            else if (txtNumGrade.Text.Trim() == "")
            {
                isValid = false;
            }
            else { isValid = true; }

            return isValid;
        }

        private void invalidInputMessage()
        {
            MessageBox.Show("Please Enter A Valid Number! (0.0 - 4.0)",
                   "Invalid Input",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }
    }
}

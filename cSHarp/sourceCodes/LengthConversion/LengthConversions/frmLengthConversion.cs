using System.Linq.Expressions;

namespace LengthConversions
{
    public partial class frmLengthConversion : Form
    {
        public frmLengthConversion()
        {
            InitializeComponent();
        }

        string[,] conversionTable = {
        {"Miles to kilometers", "Miles:", "Kilometers:", "1.6093"},
        {"Kilometers to miles", "Kilometers:", "Miles:", "0.6214"},
        {"Feet to meters", "Feet:", "Meters:", "0.3048"},
        {"Meters to feet", "Meters:", "Feet:", "3.2808"},
        {"Inches to centimeters", "Inches:", "Centimeters:", "2.54"},
        {"Centimeters to inches", "Centimeters:", "Inches:", "0.3937"}
    };

        public string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " is a required field.\n";
            }
            return msg;
        }

        public string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
            }
            return msg;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*foreach (string choices in conversionTable)
           {
              cboConversions.Items.Add(choices);

           }*/
            cboConversions.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                cboConversions.Items.Add(conversionTable[i, 0]);
            }
            /* for (int j = 0; j < conversionTable.Length; j++)
             {
                 ;
             }*/

            /* for (int i = 0; i < conversionTable.Length; i++)
             {
                // cboConversions.Items.Add(conversionTable.ToString());
                 for (int j = 3; j < conversionTable.Length; j=j+3)
                 {

                    ;
                 }

             }*/
            txtLength.Focus();
            cboConversions.SelectedIndex = 0;
            txtLength.Text = 1.ToString();
        }

        private void cboConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboConversions.SelectedIndex == 0)
            {
                lblFromLength.Text = conversionTable[0, 1];
                lblToLength.Text = conversionTable[0, 2];
                txtCalculatedLength.Text = conversionTable[0, 3].ToString();
            }
            else if (cboConversions.SelectedIndex == 1)
            {
                lblFromLength.Text = conversionTable[1, 1];
                lblToLength.Text = conversionTable[1, 2];
                txtCalculatedLength.Text = conversionTable[1, 3].ToString();

            }
            else if (cboConversions.SelectedIndex == 2)
            {
                lblFromLength.Text = conversionTable[2, 1];
                lblToLength.Text = conversionTable[2, 2];
                txtCalculatedLength.Text = conversionTable[2, 3].ToString();

            }
            else if (cboConversions.SelectedIndex == 3)
            {
                lblFromLength.Text = conversionTable[3, 1];
                lblToLength.Text = conversionTable[3, 2];
                txtCalculatedLength.Text = conversionTable[3, 3].ToString();

            }
            else if (cboConversions.SelectedIndex == 4)
            {
                lblFromLength.Text = conversionTable[4, 1];
                lblToLength.Text = conversionTable[4, 2];
                txtCalculatedLength.Text = conversionTable[4, 3].ToString();

            }
            else if (cboConversions.SelectedIndex == 5)
            {
                lblFromLength.Text = conversionTable[5, 1];
                lblToLength.Text = conversionTable[5, 2];
                txtCalculatedLength.Text = conversionTable[5, 3].ToString();

            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try 
            { 
                if(IsValidData())
                { 
                    if (cboConversions.SelectedIndex == 0)
                    {
                        decimal inputValue = decimal.Parse(txtLength.Text);
                        decimal result = (decimal.Parse(conversionTable[0, 3]) * inputValue);
                        txtCalculatedLength.Text = result.ToString("n2");
                    }
                    else if (cboConversions.SelectedIndex == 1)
                    {
                        decimal inputValue = decimal.Parse(txtLength.Text);
                        decimal result = (decimal.Parse(conversionTable[1, 3]) * inputValue);
                        txtCalculatedLength.Text = result.ToString("n2");

                    }
                    else if (cboConversions.SelectedIndex == 2)
                    {
                        decimal inputValue = decimal.Parse(txtLength.Text);
                        decimal result = (decimal.Parse(conversionTable[2, 3]) * inputValue);
                        txtCalculatedLength.Text = result.ToString("n2");

                    }
                    else if (cboConversions.SelectedIndex == 3)
                    {
                        decimal inputValue = decimal.Parse(txtLength.Text);
                        decimal result = (decimal.Parse(conversionTable[3, 3]) * inputValue);
                        txtCalculatedLength.Text = result.ToString("n2");

                    }
                    else if (cboConversions.SelectedIndex == 4)
                    {
                        decimal inputValue = decimal.Parse(txtLength.Text);
                        decimal result = (decimal.Parse(conversionTable[4, 3]) * inputValue);
                        txtCalculatedLength.Text = result.ToString("n2");

                    }
                    else if (cboConversions.SelectedIndex == 5)
                    {
                        decimal inputValue = decimal.Parse(txtLength.Text);
                        decimal result = (decimal.Parse(conversionTable[5, 3]) * inputValue);
                        txtCalculatedLength.Text = result.ToString("n2");

                    }
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message, "Error");
            
            }


            return;

        }

        private bool IsValidData()
        {
            bool isValid = true;
            string errMessage = "";

            errMessage += IsPresent(txtLength.Text, "Input Length");
            errMessage += IsDecimal(txtLength.Text, "Input Length");

            if (errMessage != "")
            {
                MessageBox.Show(errMessage, "Error!");
                return false;
            }
            return isValid;
        }
    }
}
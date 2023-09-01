using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CardDesignerGUI
{
    public partial class frmCardDesignerGUI : Form
    {
        public frmCardDesignerGUI()
        {
            InitializeComponent();
        }

        //global arrays for combo boxes

        string[] occassions = {"Select Occasion ",
                                     "Thank You ($2.00)",
                                           "Love ($2.50)",
                                         "Birthday ($3.00)" };

        //styles options for thank you card
        string[] tyStyles = {"Candle", "Scrabble","Simple" };

        ////styles options for love card
        string[] loveStyles = {"Glitters","Red Hearts", "Yellow Heart" };

        //styles options for bday card
        string[] bdayStyles = { "Cake","Cup Cake","Ice Cream Cone" };


        string[] tyImages = {
                    //// photo by Daniel Andrade from unsplash.com
                    @"C:\Users\diamo\Desktop\C#_SUMMER_SEM\AWD1100-Summer2023-LouDiamondLoyloy-master\HOT\HOT04CardStoreGUI\CardDesignerGUI\Images\tyStyles\thankYouCandle.jpg",
                    //// photo by Priscilla Du Preez from unsplash.com
                    @"C:\Users\diamo\Desktop\C#_SUMMER_SEM\AWD1100-Summer2023-LouDiamondLoyloy-master\HOT\HOT04CardStoreGUI\CardDesignerGUI\Images\tyStyles\thankYouScrabble.jpg",
                    //// photo by Morvanic Lee from unsplash.com
                    @"C:\Users\diamo\Desktop\C#_SUMMER_SEM\AWD1100-Summer2023-LouDiamondLoyloy-master\HOT\HOT04CardStoreGUI\CardDesignerGUI\Images\tyStyles\thankYouSimple.jpg"

        };

        string[] loveImages = {
                    // photo by Pawel Czerwinski from unsplash.com
                    @"C:\Users\diamo\Desktop\C#_SUMMER_SEM\AWD1100-Summer2023-LouDiamondLoyloy-master\HOT\HOT04CardStoreGUI\CardDesignerGUI\Images\loveStyles\loveHeartGlitters.jpg",
                    // photo by Kostiantyn Li from unsplash.com
                    @"C:\Users\diamo\Desktop\C#_SUMMER_SEM\AWD1100-Summer2023-LouDiamondLoyloy-master\HOT\HOT04CardStoreGUI\CardDesignerGUI\Images\loveStyles\loveRedHearts.jpg",
                    //photo by Dhaya Eddine Bentaleb from unsplash.com  
                    @"C:\Users\diamo\Desktop\C#_SUMMER_SEM\AWD1100-Summer2023-LouDiamondLoyloy-master\HOT\HOT04CardStoreGUI\CardDesignerGUI\Images\loveStyles\loveYellowHeart.jpg"
        };

        string[] bdayImages = {
                    //photo by M O E from unsplash.com
                    @"C:\Users\diamo\Desktop\C#_SUMMER_SEM\AWD1100-Summer2023-LouDiamondLoyloy-master\HOT\HOT04CardStoreGUI\CardDesignerGUI\Images\bdayStyles\birthdayCake.jpg",
                    //photo by Angele kamp from unsplash.com
                    @"C:\Users\diamo\Desktop\C#_SUMMER_SEM\AWD1100-Summer2023-LouDiamondLoyloy-master\HOT\HOT04CardStoreGUI\CardDesignerGUI\Images\bdayStyles\birthdayCupCake.jpg",
                    //photo by Seyedeh Hamideh Kazemi from unsplash.com 
                    @"C:\Users\diamo\Desktop\C#_SUMMER_SEM\AWD1100-Summer2023-LouDiamondLoyloy-master\HOT\HOT04CardStoreGUI\CardDesignerGUI\Images\bdayStyles\birthdayIceCreamCone.jpg"
        };

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitYesNo();
        }

        private void exitYesNo() 
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

        private void frmCardDesignerGUI_Load(object sender, EventArgs e)
        {
            

            cboStyle.Items.Clear();
            loadOccasions();

            txtCustomMessage.Enabled = false;
        }

       

        private void loadOccasions() 
        {
            //load occasion options 
            cboOccasion.Items.Clear();
            foreach (string occassion in occassions)
            {
                cboOccasion.Items.Add(occassion);
            };

            cboOccasion.SelectedIndex = 0;

            return;
        }

        private void cboOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboOccasion.SelectedIndex;

            switch (index) 
            {
                // no occasion selected
                case 0:
                    cboStyle.Items.Clear();
                    cboStyle.Text = string.Empty;
                    cboStyle.Enabled=false;
                    
                    break;
                    //thank you occassion selected
                case 1:
                    cboStyle.Enabled = true;
                    loadTYstyles();
                    break;
                    // love occasion selected
                case 2:
                    cboStyle.Enabled = true;
                    loadLovestyles();
                    break;
                    //bday occasion selected
                case 3:
                    cboStyle.Enabled = true;
                    loadBdaystyles();
                    break;

                    default: break;
            }
        }

        private void loadTYstyles() 
        {
            cboStyle.Items.Clear();
            foreach (string ty in tyStyles)
            { 
                cboStyle.Items.Add(ty);
            }
            cboStyle.SelectedIndex = 0;
            return;
        }

        private void loadLovestyles() 
        {
            cboStyle.Items.Clear();

            foreach (string love in loveStyles)
            {
                cboStyle.Items.Add(love);
            }
            cboStyle.SelectedIndex = 0;
            return;
        }

        private void loadBdaystyles()
        {
            cboStyle.Items.Clear();

            foreach (string bday in bdayStyles)
            {
                cboStyle.Items.Add(bday);
            }

            cboStyle.SelectedIndex = 0;
            return;
        }

        private void ckCustomMessage_CheckedChanged(object sender, EventArgs e)
        {
            enableDisableTXTBOXforCustomMessage();
        }

        private void enableDisableTXTBOXforCustomMessage() 
        {
            if (ckCustomMessage.Checked == true)
            {
                txtCustomMessage.Enabled = true;
            }
            else
            {
                txtCustomMessage.Text = string.Empty;
                txtCustomMessage.Enabled = false;
                lblCustomMessage.Text = string.Empty;
            }
        }

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboOccasion.SelectedIndex;

            switch (index) 
            {
               
                case 0:
                    
                case 1://thank you occasion selected
                    picbEnvelopeDesign.Image =
                        System.Drawing.Image.FromFile(tyImages[cboStyle.SelectedIndex]);

                    break;
                case 2://love occasion selected
                    picbEnvelopeDesign.Image =
                        System.Drawing.Image.FromFile(loveImages[cboStyle.SelectedIndex]);

                    break;
                case 3: //bday occasion selected
                    picbEnvelopeDesign.Image =
                        System.Drawing.Image.FromFile(bdayImages[cboStyle.SelectedIndex]);

                    break;


                default: break;
            }
            return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearALL();
        }

        private void clearALL()
        { 

            // clears all

            picbEnvelopeDesign.Image = null;
            txtCustomMessage.Enabled = false;
            ckCustomMessage.Checked = false;
            ckEnvelope.Checked = false;
            ckStamp.Checked = false;
            txtCustomMessage.Text = string.Empty;
            cboOccasion.Items.Clear();
            loadOccasions();

            lblCustomMessage.Text = string.Empty;
            lblCost.Text = "Cost : $00.00";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculateCost();

            showCustomMessage();
        }

        private void showCustomMessage() 
        {
            //get the input text and show in the label custom message area
           
            if(ckCustomMessage.Checked == true)
            {
                string customMessage = txtCustomMessage.Text;
                lblCustomMessage.Text = "Custom Message :\n" + customMessage;
            }
        }

        private void calculateCost() 
        {

            //initializing and declaring constants
            const decimal ENVELOPEprice = 0.25m;
            const decimal STAMPprice = 0.50m;
            const decimal CUSTmessagePRICE = 0.30m;
            //declaring and initializing variables
            int index = cboOccasion.SelectedIndex;
            decimal cost = 0m;

            switch (index)
            {
                case 0:
                    break;
                case 1: // if thank you is selected, price is 2$
                    cost += 2.00m;
                    break;
                case 2:// if love is selected, price is 2.50$
                    cost += 2.50m;
                    break;
                case 3:// if bday is selected, price is 3$
                    cost += 3.00m;
                    break;
                default: break;
            }

            // check checkboxes and add the appropriate prices
            if (ckCustomMessage.Checked == true)
            {
                cost += CUSTmessagePRICE;
            }
            if (ckEnvelope.Checked == true)
            {
                cost += ENVELOPEprice;
            }
            if (ckStamp.Checked == true)
            {
                cost += STAMPprice;
            }

            lblCost.Text = "Cost : " + cost.ToString("c");
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            frmWelcomeGUI frmWelcome = new frmWelcomeGUI();
            frmWelcome.ShowDialog();

            this.Hide();
        }
    }
}

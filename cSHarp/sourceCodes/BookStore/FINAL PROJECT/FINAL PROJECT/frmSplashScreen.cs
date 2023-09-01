
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

namespace FINAL_PROJECT
{
    public partial class frmSplashScreen : Form
    {


        public frmSplashScreen()
        {
            InitializeComponent();




        }


        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            //fill authors name
            lblBookStoreName.Text = "Danielle's Book Store";



        }


        private void btnMainPage_Click(object sender, EventArgs e)
        {
            GoToMainPageForm();




        }



        private void tsbSearch_Click_1(object sender, EventArgs e)
        {
            GoToSearchBooksForm();
        }



        private void btnContact_Click(object sender, EventArgs e)
        {

            GoToContactForm();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit program
            ExitAppYesNo();
        }





        /*--------------------------------------------------------------------------*/

        private void GoToMainPageForm()
        {
            //close this form and open mainpage form
            this.Hide();
            frmMainPage frmMainPage = new frmMainPage();
            frmMainPage.Show();
        }



        private void GoToSearchBooksForm()
        {
            //close this form and open searchbooks form
            this.Hide();
            frmSearchBooks frmSearchBooks = new frmSearchBooks();
            frmSearchBooks.Show();

        }

        private void GoToContactForm()
        {
            //close this form and open contact form
            this.Hide();
            frmContact frmContact = new frmContact();
            frmContact.Show();

        }

        private void ExitAppYesNo()
        {
            //show message box before exit if yes
            DialogResult yesORno = MessageBox.Show("Do You Want to Exit?",
                                                    "Exit Now?",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (yesORno == DialogResult.Yes)
            {
                Application.Exit();

            }
        }







    }
}

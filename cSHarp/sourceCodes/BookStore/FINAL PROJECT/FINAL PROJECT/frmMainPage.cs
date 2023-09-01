
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer;

namespace FINAL_PROJECT
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();


        }





        private void frmMainPage_Load_1(object sender, EventArgs e)
        {



            lblAuthor.Text = "Book Authors :";

            lblJeffArchInfo.Text = "Jeffrey Howard Archer, Baron Archer of Weston-super-Mare is " +
                                    "an English novelist, life peer, convicted criminal, and former " +
                                    "politician. Before becoming an author, Archer was a Member of " +
                                    "Parliament, but did not seek re-election after a financial " +
                                    "scandal that left him almost bankrupt. ";

            lblPauloCinfo.Text = "Paulo Coelho de Souza is a Brazilian lyricist and novelist and a " +
                                    "member of the Brazilian Academy of Letters since 2002. His novel " +
                                    "The Alchemist became an international best-seller and he has published " +
                                    "30 more books since then.";

            lblStephKinfo.Text = "Stephen Edwin King is an American author of horror, supernatural fiction," +
                                    " suspense, crime, science-fiction, and fantasy novels. Described as the \"King of Horror\", his " +
                                    "books have sold more than 350 million copies as of 2006, and many have been adapted into films, television series," +
                                    " miniseries, and comic books.";



        }







        private void btnSplashScreen_Click(object sender, EventArgs e)
        {
            //close this form and open splash screen form
            GoToSplashScreenForm();
        }




        private void btnSearchBooks_Click(object sender, EventArgs e)
        {

            //close this form and open searchbook form
            GoToSearchBooksForm();

        }



        private void btnContact_Click(object sender, EventArgs e)
        {
            //close this form and open contact form
            GoToContactForm();


        }






        private void btnExit_Click_1(object sender, EventArgs e)
        {
            //exit program yes or no 
            ExitAppYesNo();
        }




        /*--------------------------------------------------------------------------*/


        private void GoToSplashScreenForm()
        {
            this.Hide();
            frmSplashScreen frmSplashScreen = new frmSplashScreen();
            frmSplashScreen.Show();

        }


        private void GoToSearchBooksForm()
        {
            this.Hide();
            frmSearchBooks frmSearchBooks = new frmSearchBooks();
            frmSearchBooks.Show();

        }

        private void GoToContactForm()
        {
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

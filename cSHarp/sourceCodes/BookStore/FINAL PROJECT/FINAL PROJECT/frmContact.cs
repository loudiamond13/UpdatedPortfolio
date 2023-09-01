using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
        }

        private void btnSplashScreen_Click(object sender, EventArgs e)
        {
            GoToSplashScreenForm();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            GoToMainPageForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitAppYesNo();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            GoToSearchForm();
        }



        private void ExitAppYesNo()
        {
            // show exit or no message then exit if YES
            DialogResult yesORno = MessageBox.Show("Do You Want to Exit?",
                                                    "Exit Now?",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (yesORno == DialogResult.Yes)
            {
                Application.Exit();

            }
        }


        private void GoToMainPageForm()
        {
            this.Hide();
            frmMainPage frmMainPage = new frmMainPage();
            frmMainPage.Show();
        }

        private void GoToSplashScreenForm()
        {
            this.Hide();
            frmSplashScreen frmSplashScreen = new frmSplashScreen();
            frmSplashScreen.Show();

        }

        private void GoToSearchForm()
        {
            this.Hide();
            frmSearchBooks frmSearchBooks = new frmSearchBooks();
            frmSearchBooks.Show();
        }


    }
}

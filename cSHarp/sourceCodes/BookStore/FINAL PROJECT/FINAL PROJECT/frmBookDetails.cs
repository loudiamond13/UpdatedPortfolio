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
    public partial class frmBookDetails : Form
    {





        public frmBookDetails()
        {
            InitializeComponent();
        }



        // global variables
        public string BookName { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Img { get; set; }

        private void frmBookDetails_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            lblBookName.Text = BookName;
            lblIsbn.Text = $"ISBN: {Isbn}";
            lblYear.Text = $"Published Year: {Year}";
            lblPastReviewText.Text = $"Past Review: ";
            lblWriteRev.Text = $"Write A Review: ";
            lblAuthorName.Text = $"Author: {Author}";
            lblPastReviewList.Text = $"";

            pbBook.Image = Image.FromFile(Img);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            GoToSearchBookForm();
        }


        private void btnContact_Click(object sender, EventArgs e)
        {
            GoToContactForm();
        }



        /***************************************************************************/


        private void GoToSearchBookForm()
        {
            this.Hide();
            frmSearchBooks frmSearchBooks = new frmSearchBooks();
            frmSearchBooks.ShowDialog();

        }


        private void GoToContactForm()
        {
            // close this form and open contact form
            this.Hide();
            frmContact frmContact = new frmContact();
            frmContact.Show();

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
    }
}

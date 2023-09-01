using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer;

using Microsoft.EntityFrameworkCore;




namespace FINAL_PROJECT
{
    public partial class frmSearchBooks : Form
    {


        public frmSearchBooks()
        {
            InitializeComponent();
        }


        //Global

        ClsBookInfos bookInfos = new ClsBookInfos();

        List<Books> BookList;
        List<ReviewsT> ReviewsList;


        // authors name list
        List<string> authors = new List<string>()
        {
            "Select Author",    "Jeffrey Archer", "Paulo Coelho", "Stephen King"
        };




        private void frmSearchBooks_Load(object sender, EventArgs e)
        {
            //adding txtSearchByISBN textbox event handller 
            this.txtSearchByISBN.Enter += new EventHandler(txtSearchByISBN_Enter);
            this.txtSearchByISBN.Leave += new EventHandler(txtSearchByISBN_Leave);

            // adding txtSearchByISBN text box default label text
            txtSearchByISBN_Text();
            dgvSearchResult.Select();


            // load authors name combo box
            foreach (string author in authors)
            {
                cbAuthors.Items.Add(author);
            }

            cbAuthors.SelectedIndex = 0;

            btnDetails.Enabled = false;

        }



        protected void txtSearchByISBN_Enter(object sender, EventArgs e)
        {


            // if selected set fore color to black and remove text
            txtSearchByISBN.Text = "";
            txtSearchByISBN.ForeColor = Color.Black;

            //if something is entered for isbn search, unselect authors name
            cbAuthors.SelectedIndex = 0;
        }


        private void txtSearchByISBN_Leave(object sender, EventArgs e)
        {
            //if nothing is entered 
            // set to default label text 
            if (txtSearchByISBN.Text.Trim() == "")
            {
                txtSearchByISBN_Text();


            }
        }
        protected void txtSearchByISBN_Text()
        {
            //default text box text label
            this.txtSearchByISBN.Text = "ISBN: 978-";
            txtSearchByISBN.ForeColor = Color.Gray;
        }


        private void cbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if one author is selected to search, clear ISBN text

            if (cbAuthors.SelectedIndex != 0)
            {
                txtSearchByISBN_Text();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

            string searchText = txtSearchByISBN.Text;

            if (searchText != "ISBN: 978-")
            {
                SearchForIsbn();
                
            }
            else 
            { 
                SearchForAuthor(); 
               
            }
        }



        // private void dgvSearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //  {
        // ViewBookDetailsForm();
        // }
        private void dgvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewBookDetailsForm();
        }

      


        private void btnSplashScreen_Click(object sender, EventArgs e)
        {

            GoToSplashScreenForm();
        }
        private void btnContact_Click(object sender, EventArgs e)
        {
            GoToContactForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitAppYesNo();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            GoToMainPageForm();
        }


        private void btnDetails_Click(object sender, EventArgs e)
        {
            ViewBookDetailsForm();

        }









        /*********************************************************************************/





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














        private void SearchForAuthor()
        {

            string selectedAuthor = cbAuthors.Text;


            BookList = bookInfos.Books.Select(e => e).Where(e => e.AuthorName == selectedAuthor).ToList();


            dgvSearchResult.DataSource = BookList.ToList();
            
            //turn on detail button
            btnDetails.Enabled = true;
        }

        private void SearchForIsbn()
        {
            // find the users input isbn 
            BookList = bookInfos.Books.Select(e => e).Where(e => e.Isbn == txtSearchByISBN.Text).ToList();

            dgvSearchResult.DataSource = BookList.ToList();

            //turn on detail button
            btnDetails.Enabled = true;
        }

        




        private void ViewBookDetailsForm()
        {
            

            //img file path
            string img = $"C:\\Users\\diamo\\Desktop\\C#_SUMMER_SEM\\AWD1100-Summer2023-LouDiamondLoyloy-master\\FINAL PROJECT\\FINAL PROJECT\\FINAL PROJECT\\Images\\BookImages\\";


            // set the book infos
            this.Hide();
            frmBookDetails frmBookDetails = new frmBookDetails();
            frmBookDetails.BookName = dgvSearchResult.SelectedRows[0].Cells[3].Value.ToString();
            frmBookDetails.Isbn = dgvSearchResult.SelectedRows[0].Cells[1].Value.ToString();
            frmBookDetails.Author = dgvSearchResult.SelectedRows[0].Cells[2].Value.ToString();
            frmBookDetails.Year = dgvSearchResult.SelectedRows[0].Cells[4].Value.ToString();
            frmBookDetails.Img = img + dgvSearchResult.SelectedRows[0].Cells[5].Value.ToString();


            frmBookDetails.ShowDialog();


        }


    }
}

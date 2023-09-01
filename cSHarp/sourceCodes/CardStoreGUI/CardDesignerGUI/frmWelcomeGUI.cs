using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardDesignerGUI
{
    public partial class frmWelcomeGUI : Form
    {
        public frmWelcomeGUI()
        {
            InitializeComponent();
        }

        private void picbHomeImage_Click(object sender, EventArgs e)
        {
            //
           //photo by Sixteen Miles Out from unsplash.com
        }

        private void btnCardDesigner_Click(object sender, EventArgs e)
        {
            frmCardDesignerGUI frmCardDesigner = new frmCardDesignerGUI();

            frmCardDesigner.ShowDialog();

            this.Hide();
        }

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
    
    }
}

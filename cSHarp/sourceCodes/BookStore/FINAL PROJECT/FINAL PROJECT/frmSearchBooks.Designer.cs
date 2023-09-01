namespace FINAL_PROJECT
{
    partial class frmSearchBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchBooks));
            txtSearchByISBN = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            dgvSearchResult = new System.Windows.Forms.DataGridView();
            cbAuthors = new System.Windows.Forms.ComboBox();
            btnDetails = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnContact = new System.Windows.Forms.Button();
            btnSplashScreen = new System.Windows.Forms.Button();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            tsbSplashScreen = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbMainPage = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsbContact = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            tsbExit = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            btnMainPage = new System.Windows.Forms.Button();
            lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResult).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchByISBN
            // 
            txtSearchByISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearchByISBN.Location = new System.Drawing.Point(21, 135);
            txtSearchByISBN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtSearchByISBN.Name = "txtSearchByISBN";
            txtSearchByISBN.Size = new System.Drawing.Size(375, 35);
            txtSearchByISBN.TabIndex = 0;
            txtSearchByISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSearch.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(231, 262);
            btnSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(170, 50);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvSearchResult
            // 
            dgvSearchResult.AllowUserToAddRows = false;
            dgvSearchResult.AllowUserToDeleteRows = false;
            dgvSearchResult.AllowUserToResizeColumns = false;
            dgvSearchResult.AllowUserToResizeRows = false;
            dgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvSearchResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgvSearchResult.Location = new System.Drawing.Point(430, 75);
            dgvSearchResult.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            dgvSearchResult.MultiSelect = false;
            dgvSearchResult.Name = "dgvSearchResult";
            dgvSearchResult.RowHeadersWidth = 51;
            dgvSearchResult.Size = new System.Drawing.Size(940, 622);
            dgvSearchResult.TabIndex = 8;
            dgvSearchResult.CellDoubleClick += dgvSearchResult_CellDoubleClick;
            // 
            // cbAuthors
            // 
            cbAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            cbAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbAuthors.FormattingEnabled = true;
            cbAuthors.Location = new System.Drawing.Point(21, 197);
            cbAuthors.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            cbAuthors.Name = "cbAuthors";
            cbAuthors.Size = new System.Drawing.Size(375, 37);
            cbAuthors.TabIndex = 1;
            cbAuthors.UseWaitCursor = true;
            cbAuthors.SelectedIndexChanged += cbAuthors_SelectedIndexChanged;
            // 
            // btnDetails
            // 
            btnDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDetails.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDetails.Location = new System.Drawing.Point(170, 647);
            btnDetails.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new System.Drawing.Size(249, 50);
            btnDetails.TabIndex = 7;
            btnDetails.Text = "View Book Details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnExit.Location = new System.Drawing.Point(1084, 968);
            btnExit.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(230, 82);
            btnExit.TabIndex = 6;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnContact
            // 
            btnContact.BackColor = System.Drawing.Color.MidnightBlue;
            btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            btnContact.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnContact.Location = new System.Drawing.Point(761, 968);
            btnContact.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            btnContact.Name = "btnContact";
            btnContact.Size = new System.Drawing.Size(230, 82);
            btnContact.TabIndex = 5;
            btnContact.Text = "&Contact";
            btnContact.UseVisualStyleBackColor = false;
            btnContact.Click += btnContact_Click;
            // 
            // btnSplashScreen
            // 
            btnSplashScreen.BackColor = System.Drawing.Color.MidnightBlue;
            btnSplashScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSplashScreen.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSplashScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSplashScreen.Location = new System.Drawing.Point(71, 968);
            btnSplashScreen.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            btnSplashScreen.Name = "btnSplashScreen";
            btnSplashScreen.Size = new System.Drawing.Size(279, 82);
            btnSplashScreen.TabIndex = 3;
            btnSplashScreen.Text = "&Splash Screen";
            btnSplashScreen.UseVisualStyleBackColor = false;
            btnSplashScreen.Click += btnSplashScreen_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator3, tsbSplashScreen, toolStripSeparator2, tsbMainPage, toolStripSeparator1, tsbContact, toolStripSeparator5, tsbExit, toolStripSeparator4 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            toolStrip1.Size = new System.Drawing.Size(1284, 34);
            toolStrip1.TabIndex = 24;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // tsbSplashScreen
            // 
            tsbSplashScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbSplashScreen.Image = (System.Drawing.Image)resources.GetObject("tsbSplashScreen.Image");
            tsbSplashScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSplashScreen.Name = "tsbSplashScreen";
            tsbSplashScreen.Size = new System.Drawing.Size(125, 29);
            tsbSplashScreen.Text = "&Splash Screen";
            tsbSplashScreen.Click += btnSplashScreen_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // tsbMainPage
            // 
            tsbMainPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbMainPage.Image = (System.Drawing.Image)resources.GetObject("tsbMainPage.Image");
            tsbMainPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbMainPage.Name = "tsbMainPage";
            tsbMainPage.Size = new System.Drawing.Size(98, 29);
            tsbMainPage.Text = "&Main Page";
            tsbMainPage.Click += btnMainPage_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tsbContact
            // 
            tsbContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbContact.Image = (System.Drawing.Image)resources.GetObject("tsbContact.Image");
            tsbContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbContact.Name = "tsbContact";
            tsbContact.Size = new System.Drawing.Size(77, 29);
            tsbContact.Text = "&Contact";
            tsbContact.Click += btnContact_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 34);
            // 
            // tsbExit
            // 
            tsbExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbExit.Image = (System.Drawing.Image)resources.GetObject("tsbExit.Image");
            tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbExit.Name = "tsbExit";
            tsbExit.Size = new System.Drawing.Size(43, 29);
            tsbExit.Text = "&Exit";
            tsbExit.Click += btnExit_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // btnMainPage
            // 
            btnMainPage.BackColor = System.Drawing.Color.MidnightBlue;
            btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMainPage.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMainPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnMainPage.Location = new System.Drawing.Point(441, 968);
            btnMainPage.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new System.Drawing.Size(230, 82);
            btnMainPage.TabIndex = 4;
            btnMainPage.Text = "&Main Page";
            btnMainPage.UseVisualStyleBackColor = false;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // lblSearch
            // 
            lblSearch.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblSearch.Location = new System.Drawing.Point(21, 63);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(380, 67);
            lblSearch.TabIndex = 25;
            lblSearch.Text = "Search Isbn/Author's' Books:";
            lblSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // frmSearchBooks
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.SlateGray;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(1284, 702);
            Controls.Add(lblSearch);
            Controls.Add(btnMainPage);
            Controls.Add(toolStrip1);
            Controls.Add(btnExit);
            Controls.Add(btnContact);
            Controls.Add(btnSplashScreen);
            Controls.Add(btnDetails);
            Controls.Add(cbAuthors);
            Controls.Add(dgvSearchResult);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchByISBN);
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MinimumSize = new System.Drawing.Size(1298, 729);
            Name = "frmSearchBooks";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Search Books";
            Load += frmSearchBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSearchResult).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchByISBN;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.ComboBox cbAuthors;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnSplashScreen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbSplashScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbMainPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbContact;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Label lblSearch;
    }
}
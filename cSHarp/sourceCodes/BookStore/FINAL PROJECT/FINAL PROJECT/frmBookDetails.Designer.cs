namespace FINAL_PROJECT
{
    partial class frmBookDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookDetails));
            btnExit = new System.Windows.Forms.Button();
            btnMainPage = new System.Windows.Forms.Button();
            btnSplashScreen = new System.Windows.Forms.Button();
            btnContact = new System.Windows.Forms.Button();
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
            pbBook = new System.Windows.Forms.PictureBox();
            lblBookName = new System.Windows.Forms.Label();
            lblIsbn = new System.Windows.Forms.Label();
            lblYear = new System.Windows.Forms.Label();
            lblPastReviewText = new System.Windows.Forms.Label();
            lblPastReviewList = new System.Windows.Forms.Label();
            txtWrittenRev = new System.Windows.Forms.TextBox();
            btnSubmit = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            lblWriteRev = new System.Windows.Forms.Label();
            lblAuthorName = new System.Windows.Forms.Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBook).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnExit.Location = new System.Drawing.Point(772, 592);
            btnExit.Margin = new System.Windows.Forms.Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(161, 49);
            btnExit.TabIndex = 13;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMainPage
            // 
            btnMainPage.BackColor = System.Drawing.Color.MidnightBlue;
            btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMainPage.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMainPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnMainPage.Location = new System.Drawing.Point(304, 592);
            btnMainPage.Margin = new System.Windows.Forms.Padding(2);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new System.Drawing.Size(161, 49);
            btnMainPage.TabIndex = 12;
            btnMainPage.Text = "&Main Page";
            btnMainPage.UseVisualStyleBackColor = false;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // btnSplashScreen
            // 
            btnSplashScreen.BackColor = System.Drawing.Color.MidnightBlue;
            btnSplashScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSplashScreen.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSplashScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSplashScreen.Location = new System.Drawing.Point(37, 592);
            btnSplashScreen.Margin = new System.Windows.Forms.Padding(2);
            btnSplashScreen.Name = "btnSplashScreen";
            btnSplashScreen.Size = new System.Drawing.Size(194, 49);
            btnSplashScreen.TabIndex = 11;
            btnSplashScreen.Text = "&Splash Screen";
            btnSplashScreen.UseVisualStyleBackColor = false;
            btnSplashScreen.Click += btnSplashScreen_Click;
            // 
            // btnContact
            // 
            btnContact.BackColor = System.Drawing.Color.MidnightBlue;
            btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            btnContact.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnContact.Location = new System.Drawing.Point(538, 592);
            btnContact.Margin = new System.Windows.Forms.Padding(2);
            btnContact.Name = "btnContact";
            btnContact.Size = new System.Drawing.Size(161, 49);
            btnContact.TabIndex = 14;
            btnContact.Text = "&Contact";
            btnContact.UseVisualStyleBackColor = false;
            btnContact.Click += btnContact_Click;
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
            toolStrip1.Size = new System.Drawing.Size(1020, 25);
            toolStrip1.TabIndex = 25;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSplashScreen
            // 
            tsbSplashScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbSplashScreen.Image = (System.Drawing.Image)resources.GetObject("tsbSplashScreen.Image");
            tsbSplashScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSplashScreen.Name = "tsbSplashScreen";
            tsbSplashScreen.Size = new System.Drawing.Size(83, 22);
            tsbSplashScreen.Text = "&Splash Screen";
            tsbSplashScreen.Click += btnSplashScreen_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbMainPage
            // 
            tsbMainPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbMainPage.Image = (System.Drawing.Image)resources.GetObject("tsbMainPage.Image");
            tsbMainPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbMainPage.Name = "tsbMainPage";
            tsbMainPage.Size = new System.Drawing.Size(67, 22);
            tsbMainPage.Text = "&Main Page";
            tsbMainPage.Click += btnMainPage_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbContact
            // 
            tsbContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbContact.Image = (System.Drawing.Image)resources.GetObject("tsbContact.Image");
            tsbContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbContact.Name = "tsbContact";
            tsbContact.Size = new System.Drawing.Size(53, 22);
            tsbContact.Text = "&Contact";
            tsbContact.Click += btnContact_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExit
            // 
            tsbExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbExit.Image = (System.Drawing.Image)resources.GetObject("tsbExit.Image");
            tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbExit.Name = "tsbExit";
            tsbExit.Size = new System.Drawing.Size(30, 22);
            tsbExit.Text = "&Exit";
            tsbExit.Click += btnExit_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // pbBook
            // 
            pbBook.Enabled = false;
            pbBook.Location = new System.Drawing.Point(12, 56);
            pbBook.Name = "pbBook";
            pbBook.Size = new System.Drawing.Size(245, 258);
            pbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbBook.TabIndex = 26;
            pbBook.TabStop = false;
            // 
            // lblBookName
            // 
            lblBookName.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblBookName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblBookName.Location = new System.Drawing.Point(263, 56);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new System.Drawing.Size(653, 44);
            lblBookName.TabIndex = 27;
            lblBookName.Text = "label1";
            lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIsbn
            // 
            lblIsbn.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIsbn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblIsbn.Location = new System.Drawing.Point(527, 144);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new System.Drawing.Size(258, 44);
            lblIsbn.TabIndex = 28;
            lblIsbn.Text = "label2";
            lblIsbn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            lblYear.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblYear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblYear.Location = new System.Drawing.Point(263, 144);
            lblYear.Name = "lblYear";
            lblYear.Size = new System.Drawing.Size(258, 44);
            lblYear.TabIndex = 29;
            lblYear.Text = "label3";
            lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPastReviewText
            // 
            lblPastReviewText.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPastReviewText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblPastReviewText.Location = new System.Drawing.Point(263, 195);
            lblPastReviewText.Name = "lblPastReviewText";
            lblPastReviewText.Size = new System.Drawing.Size(209, 30);
            lblPastReviewText.TabIndex = 30;
            lblPastReviewText.Text = "label4";
            lblPastReviewText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPastReviewList
            // 
            lblPastReviewList.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPastReviewList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblPastReviewList.Location = new System.Drawing.Point(263, 225);
            lblPastReviewList.Name = "lblPastReviewList";
            lblPastReviewList.Size = new System.Drawing.Size(643, 128);
            lblPastReviewList.TabIndex = 2;
            lblPastReviewList.Text = "label5";
            lblPastReviewList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWrittenRev
            // 
            txtWrittenRev.BackColor = System.Drawing.SystemColors.InactiveCaption;
            txtWrittenRev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtWrittenRev.Location = new System.Drawing.Point(263, 356);
            txtWrittenRev.Multiline = true;
            txtWrittenRev.Name = "txtWrittenRev";
            txtWrittenRev.Size = new System.Drawing.Size(505, 135);
            txtWrittenRev.TabIndex = 32;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 11.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSubmit.Location = new System.Drawing.Point(772, 453);
            btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(161, 38);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit Review";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnBack.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnBack.Location = new System.Drawing.Point(772, 531);
            btnBack.Margin = new System.Windows.Forms.Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(161, 49);
            btnBack.TabIndex = 34;
            btnBack.Text = "&Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblWriteRev
            // 
            lblWriteRev.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblWriteRev.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblWriteRev.Location = new System.Drawing.Point(48, 356);
            lblWriteRev.Name = "lblWriteRev";
            lblWriteRev.Size = new System.Drawing.Size(209, 30);
            lblWriteRev.TabIndex = 35;
            lblWriteRev.Text = "label4";
            lblWriteRev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAuthorName
            // 
            lblAuthorName.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAuthorName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblAuthorName.Location = new System.Drawing.Point(263, 100);
            lblAuthorName.Name = "lblAuthorName";
            lblAuthorName.Size = new System.Drawing.Size(258, 44);
            lblAuthorName.TabIndex = 36;
            lblAuthorName.Text = "label2";
            lblAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBookDetails
            // 
            AcceptButton = btnBack;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.SlateGray;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            CancelButton = btnBack;
            ClientSize = new System.Drawing.Size(1020, 701);
            Controls.Add(lblAuthorName);
            Controls.Add(lblWriteRev);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(txtWrittenRev);
            Controls.Add(lblPastReviewList);
            Controls.Add(lblPastReviewText);
            Controls.Add(lblYear);
            Controls.Add(lblIsbn);
            Controls.Add(lblBookName);
            Controls.Add(pbBook);
            Controls.Add(toolStrip1);
            Controls.Add(btnContact);
            Controls.Add(btnExit);
            Controls.Add(btnMainPage);
            Controls.Add(btnSplashScreen);
            MinimumSize = new System.Drawing.Size(899, 418);
            Name = "frmBookDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Book Details";
            Load += frmBookDetails_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnSplashScreen;
        private System.Windows.Forms.Button btnContact;
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
        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPastReviewText;
        private System.Windows.Forms.Label lblPastReviewList;
        private System.Windows.Forms.TextBox txtWrittenRev;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblWriteRev;
        private System.Windows.Forms.Label lblAuthorName;
    }
}
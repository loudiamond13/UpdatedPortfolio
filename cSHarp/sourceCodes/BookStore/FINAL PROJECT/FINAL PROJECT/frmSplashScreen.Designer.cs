namespace FINAL_PROJECT
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            btnMainPage = new System.Windows.Forms.Button();
            btnContact = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lblBookStoreName = new System.Windows.Forms.Label();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            tsbMainPage = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbSearch = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsbContact = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            tsbExit = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            lblJeffArch = new System.Windows.Forms.Label();
            lblPauloC = new System.Windows.Forms.Label();
            lblStephK = new System.Windows.Forms.Label();
            pbStephK = new System.Windows.Forms.PictureBox();
            pbPauloC = new System.Windows.Forms.PictureBox();
            pbJeffArch = new System.Windows.Forms.PictureBox();
            pbAuthor1 = new System.Windows.Forms.PictureBox();
            pbAuthor2 = new System.Windows.Forms.PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStephK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPauloC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbJeffArch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAuthor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAuthor2).BeginInit();
            SuspendLayout();
            // 
            // btnMainPage
            // 
            btnMainPage.BackColor = System.Drawing.Color.MidnightBlue;
            btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMainPage.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMainPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnMainPage.Location = new System.Drawing.Point(53, 571);
            btnMainPage.Margin = new System.Windows.Forms.Padding(2);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new System.Drawing.Size(161, 48);
            btnMainPage.TabIndex = 0;
            btnMainPage.Text = "&Main Page";
            btnMainPage.UseVisualStyleBackColor = false;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // btnContact
            // 
            btnContact.BackColor = System.Drawing.Color.MidnightBlue;
            btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            btnContact.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnContact.Location = new System.Drawing.Point(404, 571);
            btnContact.Margin = new System.Windows.Forms.Padding(2);
            btnContact.Name = "btnContact";
            btnContact.Size = new System.Drawing.Size(161, 48);
            btnContact.TabIndex = 1;
            btnContact.Text = "&Contact";
            btnContact.UseVisualStyleBackColor = false;
            btnContact.Click += btnContact_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnExit.Location = new System.Drawing.Point(759, 571);
            btnExit.Margin = new System.Windows.Forms.Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(161, 48);
            btnExit.TabIndex = 2;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblBookStoreName
            // 
            lblBookStoreName.BackColor = System.Drawing.Color.MidnightBlue;
            lblBookStoreName.Font = new System.Drawing.Font("Old English Text MT", 28.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblBookStoreName.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblBookStoreName.Location = new System.Drawing.Point(100, 46);
            lblBookStoreName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBookStoreName.Name = "lblBookStoreName";
            lblBookStoreName.Size = new System.Drawing.Size(743, 118);
            lblBookStoreName.TabIndex = 7;
            lblBookStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator3, tsbMainPage, toolStripSeparator2, tsbSearch, toolStripSeparator1, tsbContact, toolStripSeparator5, tsbExit, toolStripSeparator4 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            toolStrip1.Size = new System.Drawing.Size(969, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSearch
            // 
            tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbSearch.Image = (System.Drawing.Image)resources.GetObject("tsbSearch.Image");
            tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSearch.Name = "tsbSearch";
            tsbSearch.Size = new System.Drawing.Size(46, 22);
            tsbSearch.Text = "&Search";
            tsbSearch.Click += tsbSearch_Click_1;
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
            // lblJeffArch
            // 
            lblJeffArch.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblJeffArch.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblJeffArch.Location = new System.Drawing.Point(26, 387);
            lblJeffArch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblJeffArch.Name = "lblJeffArch";
            lblJeffArch.Size = new System.Drawing.Size(240, 38);
            lblJeffArch.TabIndex = 4;
            lblJeffArch.Text = "Jeffrey Archer";
            lblJeffArch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPauloC
            // 
            lblPauloC.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblPauloC.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblPauloC.Location = new System.Drawing.Point(358, 387);
            lblPauloC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPauloC.Name = "lblPauloC";
            lblPauloC.Size = new System.Drawing.Size(240, 38);
            lblPauloC.TabIndex = 5;
            lblPauloC.Text = "Paulo Coelho";
            lblPauloC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStephK
            // 
            lblStephK.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblStephK.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblStephK.Location = new System.Drawing.Point(680, 387);
            lblStephK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblStephK.Name = "lblStephK";
            lblStephK.Size = new System.Drawing.Size(240, 38);
            lblStephK.TabIndex = 6;
            lblStephK.Text = "Stephen King";
            lblStephK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbStephK
            // 
            pbStephK.Image = Properties.Resources.stephenKing;
            pbStephK.ImageLocation = "";
            pbStephK.Location = new System.Drawing.Point(657, 193);
            pbStephK.Margin = new System.Windows.Forms.Padding(2);
            pbStephK.Name = "pbStephK";
            pbStephK.Size = new System.Drawing.Size(280, 192);
            pbStephK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbStephK.TabIndex = 7;
            pbStephK.TabStop = false;
            // 
            // pbPauloC
            // 
            pbPauloC.Image = Properties.Resources.pauloCoelho;
            pbPauloC.ImageLocation = "";
            pbPauloC.Location = new System.Drawing.Point(343, 193);
            pbPauloC.Margin = new System.Windows.Forms.Padding(2);
            pbPauloC.Name = "pbPauloC";
            pbPauloC.Size = new System.Drawing.Size(280, 192);
            pbPauloC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbPauloC.TabIndex = 6;
            pbPauloC.TabStop = false;
            // 
            // pbJeffArch
            // 
            pbJeffArch.Image = Properties.Resources.jeffreyArcher;
            pbJeffArch.ImageLocation = "";
            pbJeffArch.Location = new System.Drawing.Point(9, 193);
            pbJeffArch.Margin = new System.Windows.Forms.Padding(2);
            pbJeffArch.Name = "pbJeffArch";
            pbJeffArch.Size = new System.Drawing.Size(280, 192);
            pbJeffArch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbJeffArch.TabIndex = 0;
            pbJeffArch.TabStop = false;
            // 
            // pbAuthor1
            // 
            pbAuthor1.ImageLocation = "";
            pbAuthor1.Location = new System.Drawing.Point(8, 167);
            pbAuthor1.Margin = new System.Windows.Forms.Padding(2);
            pbAuthor1.Name = "pbAuthor1";
            pbAuthor1.Size = new System.Drawing.Size(240, 166);
            pbAuthor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbAuthor1.TabIndex = 0;
            pbAuthor1.TabStop = false;
            // 
            // pbAuthor2
            // 
            pbAuthor2.ImageLocation = "";
            pbAuthor2.Location = new System.Drawing.Point(294, 167);
            pbAuthor2.Margin = new System.Windows.Forms.Padding(2);
            pbAuthor2.Name = "pbAuthor2";
            pbAuthor2.Size = new System.Drawing.Size(240, 166);
            pbAuthor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbAuthor2.TabIndex = 6;
            pbAuthor2.TabStop = false;
            // 
            // frmSplashScreen
            // 
            AcceptButton = btnMainPage;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.SlateGray;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(969, 643);
            Controls.Add(lblStephK);
            Controls.Add(lblPauloC);
            Controls.Add(lblJeffArch);
            Controls.Add(lblBookStoreName);
            Controls.Add(pbStephK);
            Controls.Add(pbPauloC);
            Controls.Add(btnExit);
            Controls.Add(btnContact);
            Controls.Add(btnMainPage);
            Controls.Add(pbJeffArch);
            Controls.Add(toolStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(2);
            MinimumSize = new System.Drawing.Size(850, 600);
            Name = "frmSplashScreen";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Danielle's Book Store";
            Load += frmSplashScreen_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbStephK).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPauloC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbJeffArch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAuthor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAuthor2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbJeffArch;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbPauloC;
        private System.Windows.Forms.PictureBox pbStephK;
        private System.Windows.Forms.Label lblBookStoreName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbMainPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbContact;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label lblJeffArch;
        private System.Windows.Forms.Label lblPauloC;
        private System.Windows.Forms.Label lblStephK;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.PictureBox pbAuthor1;
        private System.Windows.Forms.PictureBox pbAuthor2;
    }
}


namespace CardDesignerGUI
{
    partial class frmWelcomeGUI
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
            this.picbHomeImage = new System.Windows.Forms.PictureBox();
            this.btnCardDesigner = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbHomeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picbHomeImage
            // 
            this.picbHomeImage.ImageLocation = "C:\\Users\\diamo\\Desktop\\C#_SUMMER_SEM\\AWD1100-Summer2023-LouDiamondLoyloy-master\\H" +
    "OT\\HOT04CardStoreGUI\\CardDesignerGUI\\Images\\HomeImage\\homeWelcome.jpg";
            this.picbHomeImage.Location = new System.Drawing.Point(15, 14);
            this.picbHomeImage.Name = "picbHomeImage";
            this.picbHomeImage.Size = new System.Drawing.Size(966, 479);
            this.picbHomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbHomeImage.TabIndex = 0;
            this.picbHomeImage.TabStop = false;
            this.picbHomeImage.Click += new System.EventHandler(this.picbHomeImage_Click);
            // 
            // btnCardDesigner
            // 
            this.btnCardDesigner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCardDesigner.Location = new System.Drawing.Point(67, 523);
            this.btnCardDesigner.Name = "btnCardDesigner";
            this.btnCardDesigner.Size = new System.Drawing.Size(249, 55);
            this.btnCardDesigner.TabIndex = 0;
            this.btnCardDesigner.Text = "Card Designer";
            this.btnCardDesigner.UseVisualStyleBackColor = true;
            this.btnCardDesigner.Click += new System.EventHandler(this.btnCardDesigner_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(685, 523);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(249, 55);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWelcomeGUI
            // 
            this.AcceptButton = this.btnCardDesigner;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(992, 590);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCardDesigner);
            this.Controls.Add(this.picbHomeImage);
            this.Name = "frmWelcomeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.picbHomeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbHomeImage;
        private System.Windows.Forms.Button btnCardDesigner;
        private System.Windows.Forms.Button btnExit;
    }
}
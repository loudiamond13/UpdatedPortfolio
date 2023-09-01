namespace LengthConversions
{
    partial class frmLengthConversion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cboConversions = new ComboBox();
            lblFromLength = new Label();
            txtLength = new TextBox();
            txtCalculatedLength = new TextBox();
            lblToLength = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "Conversion:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboConversions
            // 
            cboConversions.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConversions.FormattingEnabled = true;
            cboConversions.Location = new Point(201, 36);
            cboConversions.Margin = new Padding(4);
            cboConversions.Name = "cboConversions";
            cboConversions.Size = new Size(301, 40);
            cboConversions.TabIndex = 1;
            cboConversions.SelectedIndexChanged += cboConversions_SelectedIndexChanged;
            // 
            // lblFromLength
            // 
            lblFromLength.AutoSize = true;
            lblFromLength.Location = new Point(41, 113);
            lblFromLength.Margin = new Padding(4, 0, 4, 0);
            lblFromLength.Name = "lblFromLength";
            lblFromLength.Size = new Size(76, 32);
            lblFromLength.TabIndex = 2;
            lblFromLength.Text = "Miles:";
            lblFromLength.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(201, 109);
            txtLength.Margin = new Padding(4);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(193, 39);
            txtLength.TabIndex = 3;
            // 
            // txtCalculatedLength
            // 
            txtCalculatedLength.Location = new Point(201, 177);
            txtCalculatedLength.Margin = new Padding(4);
            txtCalculatedLength.Name = "txtCalculatedLength";
            txtCalculatedLength.ReadOnly = true;
            txtCalculatedLength.Size = new Size(193, 39);
            txtCalculatedLength.TabIndex = 5;
            txtCalculatedLength.TabStop = false;
            // 
            // lblToLength
            // 
            lblToLength.AutoSize = true;
            lblToLength.Location = new Point(41, 181);
            lblToLength.Margin = new Padding(4, 0, 4, 0);
            lblToLength.Name = "lblToLength";
            lblToLength.Size = new Size(132, 32);
            lblToLength.TabIndex = 4;
            lblToLength.Text = "Kilometers:";
            lblToLength.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(41, 260);
            btnCalculate.Margin = new Padding(4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(139, 49);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(366, 260);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 49);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmLengthConversion
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(553, 341);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtCalculatedLength);
            Controls.Add(lblToLength);
            Controls.Add(txtLength);
            Controls.Add(lblFromLength);
            Controls.Add(cboConversions);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "frmLengthConversion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversions";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboConversions;
        private Label lblFromLength;
        private TextBox txtLength;
        private TextBox txtCalculatedLength;
        private Label lblToLength;
        private Button btnCalculate;
        private Button btnExit;
    }
}
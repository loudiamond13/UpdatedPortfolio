namespace CardDesignerGUI
{
    partial class frmCardDesignerGUI
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
            this.picbEnvelopeDesign = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCustomMessage = new System.Windows.Forms.TextBox();
            this.ckEnvelope = new System.Windows.Forms.CheckBox();
            this.ckCustomMessage = new System.Windows.Forms.CheckBox();
            this.ckStamp = new System.Windows.Forms.CheckBox();
            this.lblOccasion = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.cboOccasion = new System.Windows.Forms.ComboBox();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCustomMessage = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMainForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbEnvelopeDesign)).BeginInit();
            this.SuspendLayout();
            // 
            // picbEnvelopeDesign
            // 
            this.picbEnvelopeDesign.Location = new System.Drawing.Point(517, 28);
            this.picbEnvelopeDesign.Name = "picbEnvelopeDesign";
            this.picbEnvelopeDesign.Size = new System.Drawing.Size(567, 491);
            this.picbEnvelopeDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbEnvelopeDesign.TabIndex = 0;
            this.picbEnvelopeDesign.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(29, 700);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(292, 65);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCost
            // 
            this.lblCost.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(29, 576);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(297, 70);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost : $00.00";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomMessage
            // 
            this.txtCustomMessage.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomMessage.Location = new System.Drawing.Point(34, 286);
            this.txtCustomMessage.Multiline = true;
            this.txtCustomMessage.Name = "txtCustomMessage";
            this.txtCustomMessage.Size = new System.Drawing.Size(400, 189);
            this.txtCustomMessage.TabIndex = 5;
            // 
            // ckEnvelope
            // 
            this.ckEnvelope.AutoSize = true;
            this.ckEnvelope.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckEnvelope.Location = new System.Drawing.Point(34, 141);
            this.ckEnvelope.Name = "ckEnvelope";
            this.ckEnvelope.Size = new System.Drawing.Size(251, 34);
            this.ckEnvelope.TabIndex = 2;
            this.ckEnvelope.Text = "Envelope ($0.25)";
            this.ckEnvelope.UseVisualStyleBackColor = true;
            // 
            // ckCustomMessage
            // 
            this.ckCustomMessage.AutoSize = true;
            this.ckCustomMessage.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCustomMessage.Location = new System.Drawing.Point(34, 237);
            this.ckCustomMessage.Name = "ckCustomMessage";
            this.ckCustomMessage.Size = new System.Drawing.Size(339, 34);
            this.ckCustomMessage.TabIndex = 4;
            this.ckCustomMessage.Text = "Custom Message ($0.30)";
            this.ckCustomMessage.UseVisualStyleBackColor = true;
            this.ckCustomMessage.CheckedChanged += new System.EventHandler(this.ckCustomMessage_CheckedChanged);
            // 
            // ckStamp
            // 
            this.ckStamp.AutoSize = true;
            this.ckStamp.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckStamp.Location = new System.Drawing.Point(34, 189);
            this.ckStamp.Name = "ckStamp";
            this.ckStamp.Size = new System.Drawing.Size(214, 34);
            this.ckStamp.TabIndex = 3;
            this.ckStamp.Text = "Stamp ($0.50)";
            this.ckStamp.UseVisualStyleBackColor = true;
            // 
            // lblOccasion
            // 
            this.lblOccasion.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccasion.Location = new System.Drawing.Point(29, 21);
            this.lblOccasion.Name = "lblOccasion";
            this.lblOccasion.Size = new System.Drawing.Size(137, 45);
            this.lblOccasion.TabIndex = 8;
            this.lblOccasion.Text = "Occasion";
            this.lblOccasion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStyle
            // 
            this.lblStyle.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.Location = new System.Drawing.Point(29, 66);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(137, 45);
            this.lblStyle.TabIndex = 9;
            this.lblStyle.Text = "Style";
            this.lblStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboOccasion
            // 
            this.cboOccasion.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOccasion.FormattingEnabled = true;
            this.cboOccasion.Location = new System.Drawing.Point(172, 28);
            this.cboOccasion.Name = "cboOccasion";
            this.cboOccasion.Size = new System.Drawing.Size(262, 38);
            this.cboOccasion.TabIndex = 0;
            this.cboOccasion.SelectedIndexChanged += new System.EventHandler(this.cboOccasion_SelectedIndexChanged);
            // 
            // cboStyle
            // 
            this.cboStyle.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(172, 78);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(262, 38);
            this.cboStyle.TabIndex = 1;
            this.cboStyle.SelectedIndexChanged += new System.EventHandler(this.cboStyle_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(791, 700);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(292, 65);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCustomMessage
            // 
            this.lblCustomMessage.Location = new System.Drawing.Point(512, 555);
            this.lblCustomMessage.Name = "lblCustomMessage";
            this.lblCustomMessage.Size = new System.Drawing.Size(572, 128);
            this.lblCustomMessage.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(410, 700);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(292, 65);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMainForm
            // 
            this.btnMainForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainForm.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainForm.Location = new System.Drawing.Point(410, 780);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(292, 65);
            this.btnMainForm.TabIndex = 13;
            this.btnMainForm.Text = "Main Form";
            this.btnMainForm.UseVisualStyleBackColor = true;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // frmCardDesignerGUI
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1115, 866);
            this.Controls.Add(this.btnMainForm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCustomMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.cboOccasion);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblOccasion);
            this.Controls.Add(this.ckStamp);
            this.Controls.Add(this.ckCustomMessage);
            this.Controls.Add(this.ckEnvelope);
            this.Controls.Add(this.txtCustomMessage);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.picbEnvelopeDesign);
            this.Name = "frmCardDesignerGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Designer";
            this.Load += new System.EventHandler(this.frmCardDesignerGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbEnvelopeDesign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbEnvelopeDesign;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCustomMessage;
        private System.Windows.Forms.CheckBox ckEnvelope;
        private System.Windows.Forms.CheckBox ckCustomMessage;
        private System.Windows.Forms.CheckBox ckStamp;
        private System.Windows.Forms.Label lblOccasion;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.ComboBox cboOccasion;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustomMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMainForm;
    }
}


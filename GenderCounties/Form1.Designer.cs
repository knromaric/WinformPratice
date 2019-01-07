namespace GenderCounties
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkActivate = new System.Windows.Forms.CheckBox();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.btnCheckGender = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Controls.Add(this.btnCheckGender);
            this.groupBox1.Controls.Add(this.rbnFemale);
            this.groupBox1.Controls.Add(this.rbnMale);
            this.groupBox1.Controls.Add(this.chkActivate);
            this.groupBox1.Location = new System.Drawing.Point(32, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkActivate
            // 
            this.chkActivate.AutoSize = true;
            this.chkActivate.Location = new System.Drawing.Point(6, 0);
            this.chkActivate.Name = "chkActivate";
            this.chkActivate.Size = new System.Drawing.Size(106, 17);
            this.chkActivate.TabIndex = 0;
            this.chkActivate.Text = "Activate Controls";
            this.chkActivate.UseVisualStyleBackColor = true;
            this.chkActivate.CheckStateChanged += new System.EventHandler(this.chkActivate_CheckStateChanged);
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Enabled = false;
            this.rbnMale.Location = new System.Drawing.Point(41, 24);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(48, 17);
            this.rbnMale.TabIndex = 1;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Enabled = false;
            this.rbnFemale.Location = new System.Drawing.Point(41, 59);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbnFemale.TabIndex = 2;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // btnCheckGender
            // 
            this.btnCheckGender.Enabled = false;
            this.btnCheckGender.Location = new System.Drawing.Point(41, 104);
            this.btnCheckGender.Name = "btnCheckGender";
            this.btnCheckGender.Size = new System.Drawing.Size(97, 23);
            this.btnCheckGender.TabIndex = 3;
            this.btnCheckGender.Text = "Check Gender";
            this.btnCheckGender.UseVisualStyleBackColor = true;
            this.btnCheckGender.Click += new System.EventHandler(this.btnCheckGender_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(24, 156);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(114, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Message Place Holder";
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(287, 45);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(121, 21);
            this.cboCountry.TabIndex = 1;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(284, 90);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(86, 13);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "Select A Country";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 283);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCheckGender;
        private System.Windows.Forms.RadioButton rbnFemale;
        private System.Windows.Forms.RadioButton rbnMale;
        private System.Windows.Forms.CheckBox chkActivate;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lblLanguage;
    }
}


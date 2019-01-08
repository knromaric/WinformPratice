namespace CarSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.btnMoveFor = new System.Windows.Forms.Button();
            this.btnMoveWhile = new System.Windows.Forms.Button();
            this.lstSelectedCars = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Car";
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.Location = new System.Drawing.Point(17, 49);
            this.lstCars.Name = "lstCars";
            this.lstCars.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCars.Size = new System.Drawing.Size(120, 160);
            this.lstCars.TabIndex = 1;
            // 
            // btnMoveFor
            // 
            this.btnMoveFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveFor.Location = new System.Drawing.Point(17, 239);
            this.btnMoveFor.Name = "btnMoveFor";
            this.btnMoveFor.Size = new System.Drawing.Size(120, 35);
            this.btnMoveFor.TabIndex = 3;
            this.btnMoveFor.Text = "Move(For)";
            this.btnMoveFor.UseVisualStyleBackColor = true;
            this.btnMoveFor.Click += new System.EventHandler(this.btnMoveFor_Click);
            // 
            // btnMoveWhile
            // 
            this.btnMoveWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveWhile.Location = new System.Drawing.Point(158, 239);
            this.btnMoveWhile.Name = "btnMoveWhile";
            this.btnMoveWhile.Size = new System.Drawing.Size(120, 35);
            this.btnMoveWhile.TabIndex = 3;
            this.btnMoveWhile.Text = "Move(While)";
            this.btnMoveWhile.UseVisualStyleBackColor = true;
            this.btnMoveWhile.Click += new System.EventHandler(this.btnMoveWhile_Click);
            // 
            // lstSelectedCars
            // 
            this.lstSelectedCars.FormattingEnabled = true;
            this.lstSelectedCars.Location = new System.Drawing.Point(158, 49);
            this.lstSelectedCars.Name = "lstSelectedCars";
            this.lstSelectedCars.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelectedCars.Size = new System.Drawing.Size(120, 160);
            this.lstSelectedCars.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 377);
            this.Controls.Add(this.btnMoveWhile);
            this.Controls.Add(this.btnMoveFor);
            this.Controls.Add(this.lstSelectedCars);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Button btnMoveFor;
        private System.Windows.Forms.Button btnMoveWhile;
        private System.Windows.Forms.ListBox lstSelectedCars;
    }
}


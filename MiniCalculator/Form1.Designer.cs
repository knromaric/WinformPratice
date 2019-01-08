namespace MiniCalculator
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFirstValue = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblMathFunction = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMem = new System.Windows.Forms.Button();
            this.btnMemRec = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(20, 94);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 44);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "←";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblFirstValue
            // 
            this.lblFirstValue.BackColor = System.Drawing.Color.White;
            this.lblFirstValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstValue.Location = new System.Drawing.Point(20, 11);
            this.lblFirstValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstValue.Name = "lblFirstValue";
            this.lblFirstValue.Size = new System.Drawing.Size(404, 23);
            this.lblFirstValue.TabIndex = 1;
            this.lblFirstValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.White;
            this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(20, 34);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(404, 44);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "0";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblMathFunction
            // 
            this.lblMathFunction.BackColor = System.Drawing.Color.Blue;
            this.lblMathFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMathFunction.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathFunction.ForeColor = System.Drawing.Color.White;
            this.lblMathFunction.Location = new System.Drawing.Point(351, 94);
            this.lblMathFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMathFunction.Name = "lblMathFunction";
            this.lblMathFunction.Size = new System.Drawing.Size(71, 44);
            this.lblMathFunction.TabIndex = 3;
            this.lblMathFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(102, 94);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 44);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMem
            // 
            this.btnMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMem.Location = new System.Drawing.Point(184, 94);
            this.btnMem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMem.Name = "btnMem";
            this.btnMem.Size = new System.Drawing.Size(74, 44);
            this.btnMem.TabIndex = 0;
            this.btnMem.Text = "M";
            this.btnMem.UseVisualStyleBackColor = true;
            this.btnMem.Click += new System.EventHandler(this.btnMem_Click);
            // 
            // btnMemRec
            // 
            this.btnMemRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemRec.Location = new System.Drawing.Point(267, 94);
            this.btnMemRec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMemRec.Name = "btnMemRec";
            this.btnMemRec.Size = new System.Drawing.Size(74, 44);
            this.btnMemRec.TabIndex = 0;
            this.btnMemRec.Text = "MR";
            this.btnMemRec.UseVisualStyleBackColor = true;
            this.btnMemRec.Click += new System.EventHandler(this.btnMemRec_Click);
            // 
            // btnNumber7
            // 
            this.btnNumber7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber7.Location = new System.Drawing.Point(20, 142);
            this.btnNumber7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(74, 44);
            this.btnNumber7.TabIndex = 0;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = true;
            this.btnNumber7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber8
            // 
            this.btnNumber8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber8.Location = new System.Drawing.Point(102, 142);
            this.btnNumber8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(74, 44);
            this.btnNumber8.TabIndex = 0;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = true;
            this.btnNumber8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber9
            // 
            this.btnNumber9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber9.Location = new System.Drawing.Point(184, 142);
            this.btnNumber9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(74, 44);
            this.btnNumber9.TabIndex = 0;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = true;
            this.btnNumber9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(267, 142);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(74, 44);
            this.btnDivide.TabIndex = 0;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(350, 142);
            this.btnSign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(74, 44);
            this.btnSign.TabIndex = 0;
            this.btnSign.Text = "±";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnNumber4
            // 
            this.btnNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber4.Location = new System.Drawing.Point(20, 193);
            this.btnNumber4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(74, 44);
            this.btnNumber4.TabIndex = 0;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = true;
            this.btnNumber4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber5
            // 
            this.btnNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber5.Location = new System.Drawing.Point(102, 193);
            this.btnNumber5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(74, 44);
            this.btnNumber5.TabIndex = 0;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = true;
            this.btnNumber5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber6
            // 
            this.btnNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber6.Location = new System.Drawing.Point(184, 193);
            this.btnNumber6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(74, 44);
            this.btnNumber6.TabIndex = 0;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = true;
            this.btnNumber6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(267, 193);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(74, 44);
            this.btnMultiply.TabIndex = 0;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(350, 193);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(74, 44);
            this.btnSqrt.TabIndex = 0;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnNumber1
            // 
            this.btnNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber1.Location = new System.Drawing.Point(20, 245);
            this.btnNumber1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(74, 44);
            this.btnNumber1.TabIndex = 0;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = true;
            this.btnNumber1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber2
            // 
            this.btnNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber2.Location = new System.Drawing.Point(102, 245);
            this.btnNumber2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(74, 44);
            this.btnNumber2.TabIndex = 0;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = true;
            this.btnNumber2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNumber3
            // 
            this.btnNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber3.Location = new System.Drawing.Point(184, 245);
            this.btnNumber3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(74, 44);
            this.btnNumber3.TabIndex = 0;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = true;
            this.btnNumber3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstract.Location = new System.Drawing.Point(267, 245);
            this.btnSubstract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(74, 44);
            this.btnSubstract.TabIndex = 0;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(20, 297);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(156, 44);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(267, 297);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnComma
            // 
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.Location = new System.Drawing.Point(184, 297);
            this.btnComma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(74, 44);
            this.btnComma.TabIndex = 0;
            this.btnComma.Text = "‚";
            this.btnComma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComma.UseVisualStyleBackColor = true;
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(350, 245);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(74, 96);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 358);
            this.Controls.Add(this.lblMathFunction);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblFirstValue);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMemRec);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnNumber3);
            this.Controls.Add(this.btnNumber6);
            this.Controls.Add(this.btnNumber9);
            this.Controls.Add(this.btnMem);
            this.Controls.Add(this.btnNumber2);
            this.Controls.Add(this.btnNumber5);
            this.Controls.Add(this.btnNumber8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNumber1);
            this.Controls.Add(this.btnNumber4);
            this.Controls.Add(this.btnNumber7);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFirstValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblMathFunction;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMem;
        private System.Windows.Forms.Button btnMemRec;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnEqual;
    }
}


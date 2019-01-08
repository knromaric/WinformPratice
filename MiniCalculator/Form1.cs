using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalculator
{
    public partial class Form1 : Form
    {
        const string NOVALUE = "0";
        const string MINUSSIGN = "-";
        const string DECIMALSIGN = ".";
        const string PLUSSIGN = "+";
        const string DIVISIONSIGN = "/";
        const string MULTIPLICATIONSIGN = "X";

        private string _memory = string.Empty;


        public Form1()
        {
            InitializeComponent();
        }


        private void btnNumber_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (lblValue.Text == NOVALUE)
                lblValue.Text = string.Empty;
            lblValue.Text += btn.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string newValue = NOVALUE;
            int length = Convert.ToInt32(lblValue.Text.Length);

            if(length > 1)
            {
                newValue = lblValue.Text.Substring(0, length - 1);
            }

            if(newValue == MINUSSIGN)
            {
                newValue = NOVALUE;
            }

            lblValue.Text = newValue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblValue.Text = NOVALUE;
            lblValue.Text = string.Empty;
            lblMathFunction.Text = string.Empty;
        }

        private void btnMem_Click(object sender, EventArgs e)
        {
            _memory = lblValue.Text;
            lblValue.Text = NOVALUE;
        }

        private void btnMemRec_Click(object sender, EventArgs e)
        {
            lblValue.Text = _memory;
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            bool hasDecimal = lblValue.Text.Contains(DECIMALSIGN);
            if (!hasDecimal)
                lblValue.Text += DECIMALSIGN;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            lblMathFunction.Text = btn.Text;
            lblFirstValue.Text = lblValue.Text;
            lblValue.Text = NOVALUE;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            bool hasSign = lblValue.Text.Contains(MINUSSIGN);

            if (hasSign)
            {
                lblValue.Text = lblValue.Text.Replace(MINUSSIGN, String.Empty);
            }
            else if(lblValue.Text != NOVALUE)
            {
                lblValue.Text = lblValue.Text.Insert(0, MINUSSIGN);
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            bool hasSign = lblValue.Text.Contains(MINUSSIGN);
            bool endWithDecimal = lblValue.Text.EndsWith(DECIMALSIGN);
            int length = lblValue.Text.Length;

            if (hasSign)
            {
                MessageBox.Show("Cannot calculate the square root of a negative number");
                return;
            }

            if (endWithDecimal)
            {
                lblValue.Text.Substring(0, length - 1);
            }

            var value = Convert.ToDouble(lblValue.Text);
            var result = Math.Sqrt(value);
            lblValue.Text = result.ToString();

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            if(lblFirstValue.Text.Equals(string.Empty) || 
                lblMathFunction.Text.Equals(string.Empty) ||
                lblValue.Text.Equals(string.Empty) ||
                lblValue.Text.Equals(NOVALUE))
            {
                return;
            }

            bool endWithDecimal = lblFirstValue.Text.EndsWith(DECIMALSIGN);
            int length = Convert.ToInt32(lblFirstValue.Text.Length);

            if (endWithDecimal)
            {
                lblFirstValue.Text = lblFirstValue.Text.Substring(0, length - 1);
            }

            length = Convert.ToInt32(lblValue.Text.Length);
            endWithDecimal = lblValue.Text.EndsWith(DECIMALSIGN);

            if (endWithDecimal)
            {
                lblValue.Text = lblValue.Text.Substring(0, length - 1);
            }

            var value1 = Convert.ToDouble(lblFirstValue.Text);
            var value2 = Convert.ToDouble(lblValue.Text);
            var mathFunction = lblMathFunction.Text;
            var result = 0d;

            switch (mathFunction)
            {
                case PLUSSIGN:
                    result = value1 + value2;
                    break;
                case MINUSSIGN:
                    result = value1 - value2;
                    break;
                case MULTIPLICATIONSIGN:
                    result = value1 * value2;
                    break;
                case DIVISIONSIGN:
                    if(value2 == 0d)
                    {
                        MessageBox.Show("Cannot divide a number by zero...");
                    }

                    result = value1 / value2;
                    break;
            }

            lblMathFunction.Text = string.Empty;
            lblFirstValue.Text = string.Empty;
            lblValue.Text = result.ToString("F3");
        }
    }
}

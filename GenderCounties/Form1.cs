using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenderCounties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkActivate_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkActivate.Checked)
            {
                EnableControls(true);
            }
            else
            {
                EnableControls(false);
                lblMessage.Text = "Message Place Holder"; 
            }
        }

        private void EnableControls(bool isEnabled)
        {
            btnCheckGender.Enabled = isEnabled;
            rbnFemale.Enabled = isEnabled;
            rbnMale.Enabled = isEnabled;
        }

        private void btnCheckGender_Click(object sender, EventArgs e)
        {
            if (rbnMale.Checked)
            {
                lblMessage.Text = "Selected Value: Male";
            }
            else if (rbnFemale.Checked)
            {
                lblMessage.Text = "Selected Value: Female";
            }
            else
            {
                lblMessage.Text = "No Gender Selected";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCountry.Items.Add("Unknown");
            cboCountry.Items.Add("Sweden");
            cboCountry.Items.Add("Norway");
            cboCountry.Items.Add("Finland");
            cboCountry.Items.Add("Great Britain");


        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboCountry.SelectedIndex)
            {
                case 1:
                    lblLanguage.Text = "Language: Swedish";
                    lblLanguage.BackColor = Color.LightGreen;
                    break;
                case 2:
                    lblLanguage.Text = "Language: Norwegian";
                    lblLanguage.BackColor = Color.LightSkyBlue;
                    break;
                case 3:
                    lblLanguage.Text = "Language: Finnish";
                    lblLanguage.BackColor = Color.LightYellow;
                    break;
                case 4:
                    lblLanguage.Text = "Language: English";
                    lblLanguage.BackColor = Color.LightSalmon;
                    break;
                default:
                    lblLanguage.Text = "Language: unspecified";
                    lblLanguage.BackColor = Color.LightPink;
                    break;
            }
        }
    }
}

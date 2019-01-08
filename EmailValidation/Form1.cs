using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmailValidation
{
    public partial class Form1 : Form
    {
        private readonly string emailRegex;
        StringBuilder emailAddress = new StringBuilder();

        public Form1()
        {
            
            emailRegex = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]" +

                        @"+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@" +

                        @"(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)" +

                        @"+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            var result = Regex.IsMatch(txtEmail.Text, emailRegex);

            if (result)
            {
                txtEmail.BackColor = Color.White;
                if (!emailAddress.ToString().Contains(txtEmail.Text))
                    emailAddress.Append(txtEmail.Text + "\n");

                DisplayEmails();
            }
            else
            {
                txtEmail.BackColor = Color.Pink;
                txtEmailList.Text = emailAddress.ToString();
                DisplayEmails();
            }
        }

        private void DisplayEmails()
        {
            txtEmailList.Text = emailAddress.ToString();
        }
    }
}

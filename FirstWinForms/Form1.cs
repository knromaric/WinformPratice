using System;
using System.Windows.Forms;

namespace FirstWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string age = txtBoxAge.Text;
            string message = $"{name} is {age}";
            MessageBox.Show(message);
        }
    }
}

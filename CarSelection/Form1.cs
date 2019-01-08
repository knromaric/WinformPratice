using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSelection
{
    public partial class Form1 : Form
    {
        private string[] cars = { "Volvo", "Saab", "Corvette", "Mustang", "Honda" };

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                lstCars.Items.Add(cars[i]);
            }
        }

        private void btnMoveFor_Click(object sender, EventArgs e)
        {
            lstSelectedCars.Items.Clear();

            foreach(string car in lstCars.SelectedItems)
            {
                lstSelectedCars.Items.Add(car);
            }
        }

        private void btnMoveWhile_Click(object sender, EventArgs e)
        {
            int index = lstCars.SelectedItems.Count; 

            while( index > 0)
            {
                var car = lstCars.SelectedItems[index-1];
                lstSelectedCars.Items.Add(car);
                index--;
            }
        }
    }
}

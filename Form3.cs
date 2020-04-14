using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class DrinkPage : Form
    {
        public DrinkPage()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FoodPage myForm = new FoodPage();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "10 Pesos";
            MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "15 Pesos";
            MessageBox.Show(message);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = "15 Pesos";
            MessageBox.Show(message);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string message = "15 Pesos";
            MessageBox.Show(message);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string message = "15 Pesos";
            MessageBox.Show(message);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string message = "15 Pesos";
            MessageBox.Show(message);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string message = "15 Pesos";
            MessageBox.Show(message);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string message = "15 Pesos";
            MessageBox.Show(message);
        }
    }
}

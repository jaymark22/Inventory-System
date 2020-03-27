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
    public partial class FoodPage : Form
    {
        public FoodPage()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogInPage myForm = new LogInPage();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrinkPage myForm = new DrinkPage();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Bangsilog Details: \n Bangsilog Plain Rice  = 58 \n Bangsilog Fried Rice = 60 \n With out Egg: -10 \n P.Rice = 10 \n F.Rice = 12";
            MessageBox.Show(message);       
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = "Chicksilog Details: \n Chicksilog Plain Rice  = 70 \n Chicksilog Fried Rice = 72 \n With out Egg: -P10 \n P.Rice = P10 \n F.Rice = P12";
            MessageBox.Show(message);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string message = "Hamsilog Details: \n Hamsilog Plain Rice  = 48 \n Hamsilog Fried Rice = 50 \n With out Egg: -P10 \n P.Rice = P10 \n F.Rice = P12";
            MessageBox.Show(message);
        }

        private void Hotdog_Click(object sender, EventArgs e)
        {
            string message = "Hotsilog Details: \n Hotsilog Plain Rice  = 48 \n Hotsilog Fried Rice = 50 \n With out Egg: -P10 \n P.Rice = P10 \n F.Rice = P12";
            MessageBox.Show(message);
        }

        private void Liempo_Click(object sender, EventArgs e)
        {
            string message = "Liemposilog Details: \n Liemposilog Plain Rice  = 68 \n Liemposilog Fried Rice = 70 \n With out Egg: -P10 \n P.Rice = P10 \n F.Rice = P12";
            MessageBox.Show(message);
        }

        private void Tocino_Click(object sender, EventArgs e)
        {
            string message = "Tocilog Details: \n Tocilog Plain Rice  = 50 \n Tocilog Fried Rice = 52 \n With out Egg: -P10 \n P.Rice = P10 \n F.Rice = P12";
            MessageBox.Show(message);
        }

        private void Tapa_Click(object sender, EventArgs e)
        {
            string message = "Tapsilog Details: \n Tapsilog Plain Rice  = 65 \n Tapsilog Fried Rice = 67 \n With out Egg: -P10 \n P.Rice = P10 \n F.Rice = P12";
            MessageBox.Show(message);
        }

        private void Silog_Click(object sender, EventArgs e)
        {
            string message = "Silog Details: \n Silog Plain Rice  = 20 \n Longsilog Fried Rice = 22 \n P.Rice = P10 \n F.Rice = P12";
            MessageBox.Show(message);
        }

        private void Porkchop_Click(object sender, EventArgs e)
        {
            string message = "Porksilog Details: \n Porksilog Plain Rice  = 62 \n Porksilog Fried Rice = 64 \n With out Egg: -P10 \n P.Rice = P10 \n F.Rice = P12";
            MessageBox.Show(message);
        }

        private void Longanis_Click(object sender, EventArgs e)
        {
            string message = "Longsilog Details: \n Longsilog Plain Rice  = 50 \n Longsilog Fried Rice = 52 \n With out Egg: -P10 \n P.Rice = P10 \n F.Rice = P12";
            MessageBox.Show(message);
        }
    }
}

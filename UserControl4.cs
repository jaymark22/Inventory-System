using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BossSilog
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void Bangus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bangsilog = P58 \t Fried Rice: P60 + \t Plain Rice: P10 \t Fried Rice: 12 \t Egg: 10");
        }

        private void Chicken_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chicksilog = P70 \t Fried Rice: P72 + \t Plain Rice: P10 \t Fried Rice: 12 \t Egg: 10");
        }

        private void Ham_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hamsilog = P48 \t Fried Rice: P50 + \t Plain Rice: P10 \t Fried Rice: 12 \t Egg: 10");
        }

        private void Liempo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liemposilog = P68 \t Fried Rice: P70 + \t Plain Rice: P10 \t Fried Rice: 12 \t Egg: 10");
        }

        private void Hotdog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hotsilog = P48 \t Fried Rice: P50 + \t Plain Rice: P10 \t Fried Rice: 12 \t Egg: 10");
        }

        private void Porkchop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Porksilog = P62 \t Fried Rice: P64 + \t Plain Rice: P10 \t Fried Rice: 12 \t Egg: 10");
        }

        private void Silog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silog = P20 \t Fried Rice: P22 + \t Plain Rice: P10 \t Fried Rice: 12 \t Egg: 10");
        }

        private void Tocino_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tocilog = P50 \t Fried Rice: P52 + \t Plain Rice: P10 \t Fried Rice: 12 \t Egg: 10");
        }

        private void Tapa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tapsilog = P65 \t Fried Rice: P67 + \t Plain Rice: P10 \t Fried Rice: 12 \t Egg: 10");
        }

        private void Longanis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Longsilog = P50 \t Fried Rice: P52 + \t Plain Rice: P10 \t Fried Rice: 12 \t Egg: 10");
        }
    }
}

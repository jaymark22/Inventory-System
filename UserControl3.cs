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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bottled Water 350 mL: P10");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bottled Water 500 mL: P15");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bottled Coke: P15");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kopiko Timplado, any variance: P15");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Milo Timplado: P15");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mountain Dew P15");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bottled Royal: P15");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bottled Sprite: P15");
        }
    }
}

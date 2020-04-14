using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BossSilog
{
    public partial class FoodPage : Form
    {
        static FoodPage _obj;

        public static FoodPage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FoodPage();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panel2; }
            set { panel2 = value; }
        }

        public Button Food
        {
            get { return FoodButton; }
            set { FoodButton = value; }
        }
        public Button button
        {
            get { return DrinkButton; }
            set { DrinkButton = value; }
        }

        public Button Items {
            get { return Inventory; }
            set { Inventory = value; }
        }
        public FoodPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FoodButton.Visible = false;
            _obj = this;

            UserControl4 uc = new UserControl4();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);

            UserControl5 uc1 = new UserControl5();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FoodButton.Visible = true;
            DrinkButton.Visible = false;
            Inventory.Visible = true;
            _obj = this;


            if (FoodPage.Instance.panel2.Controls.ContainsKey("UserControl4"))
            {
                panel2.Controls["UserControl4"].SendToBack();
            }
            else
            {
                panel2.Controls["UserControl8"].SendToBack();
            }
            UserControl3 uc = new UserControl3();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
            panel2.Controls["UserControl3"].BringToFront();

            if (FoodPage.Instance.panel3.Controls.ContainsKey("UserControl5"))
            {
                panel3.Controls["UserControl5"].SendToBack();
            }
            else
            {
                panel3.Controls["UserControl7"].SendToBack();
            }
            UserControl6 uc1 = new UserControl6();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc1);
            panel3.Controls["UserControl6"].BringToFront();
        }

 
        private void button3_Click_1(object sender, EventArgs e)
        {
  
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            FoodButton.Visible = false;
            DrinkButton.Visible = true;
            Inventory.Visible = true;
            _obj = this;
            if (FoodPage.Instance.panel2.Controls.ContainsKey("UserControl3"))
            {
                panel2.Controls["UserControl3"].SendToBack();
            }
            else
            {
                panel2.Controls["UserControl8"].SendToBack();
            }
            UserControl4 uc = new UserControl4();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
            panel2.Controls["UserControl4"].BringToFront();

            if (FoodPage.Instance.panel3.Controls.ContainsKey("UserControl6"))
            {
                panel3.Controls["UserControl6"].SendToBack();
            }
            else
            {
                panel3.Controls["UserControl7"].SendToBack();
            }
            UserControl5 uc1 = new UserControl5();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc1);
            panel3.Controls["UserControl5"].BringToFront();
 
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            DrinkButton.Visible = true;
            FoodButton.Visible = true;
            Inventory.Visible = false;
            _obj = this;
            if (FoodPage.Instance.panel2.Controls.ContainsKey("UserControl3"))
            {
                panel2.Controls["UserControl3"].SendToBack();
            }
            else 
            {
                panel2.Controls["UserControl4"].SendToBack();
            }
            UserControl8 uc = new UserControl8();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
            panel2.Controls["UserControl8"].BringToFront();

            if (FoodPage.Instance.panel3.Controls.ContainsKey("UserControl6"))
            {
                panel3.Controls["UserControl6"].SendToBack();
            }
            else
            {
                panel3.Controls["UserControl5"].SendToBack();
            }
            UserControl7 uc1 = new UserControl7();
            uc1.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc1);
            panel3.Controls["UserControl7"].BringToFront();
        }
    }
}

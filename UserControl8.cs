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
    public partial class UserControl8 : UserControl
    {
        static UserControl8 _obj;
        public static UserControl8 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UserControl8();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panel1; }
            set { panel1 = value; }
        }

        public Button ShowButton
        {
            get { return button1; }
            set { button1 = value; }
        }
        public Button AddButton
        {
            get { return button2; }
            set { button2 = value; }
        }

        public Button GenerateReport 
        { 
            get { return button3; }
            set { button3 = value; }
        }
        public UserControl8()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            _obj = this;

            if (UserControl8.Instance.panel1.Controls.ContainsKey("AddItems"))
            {
                panel1.Controls["AddItems"].SendToBack();
            }
            else 
            {
                panel1.Controls["GenerateReport"].SendToBack();
            }
            ShowItems uc = new ShowItems();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
            panel1.Controls["ShowItems"].BringToFront();

        }

        private void UserControl8_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            _obj = this;

            ShowItems uc = new ShowItems();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
            _obj = this;

            if (UserControl8.Instance.panel1.Controls.ContainsKey("ShowItems"))
            {
                panel1.Controls["ShowItems"].SendToBack();
            }
            else 
            {
                panel1.Controls["GenerateReport"].SendToBack();
            }
            AddItems uc = new AddItems();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
            panel1.Controls["AddItems"].BringToFront();
        }
  

        private void button3_Click_1(object sender, EventArgs e)
        {
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                _obj = this;


                if (UserControl8.Instance.panel1.Controls.ContainsKey("ShowItems"))
                {
                    panel1.Controls["ShowItems"].SendToBack();
                }
                else
                {
                    panel1.Controls["AddItems"].SendToBack();
                }

                GenerateReport uc = new GenerateReport();
                uc.Dock = DockStyle.Fill;
                panel1.Controls.Add(uc);
                panel1.Controls["GenerateReport"].BringToFront();
            }
        }
    }
}

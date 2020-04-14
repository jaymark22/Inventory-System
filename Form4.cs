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
    public partial class Form4 : Form
    {
        static Form4 _obj;

        public static Form4 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form4();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panel2; }
            set { panel2 = value; }
        }

        public Button Employee
        {
            get { return EmployeeButton; }
            set { EmployeeButton = value; }
        }
        public Button Admin
        {
            get { return AdminButton; }
            set { AdminButton = value; }
        }

        public Button Items
        {
            get { return Inventory; }
            set { Inventory = value; }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            EmployeeButton.Visible = false;
            _obj = this;

            UserControl1 uc = new UserControl1();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            EmployeeButton.Visible = true;
            AdminButton.Visible = false;
            Inventory.Visible = true;
            _obj = this;

            if (Form4.Instance.panel2.Controls.ContainsKey("UserControl1"))
            {
                panel2.Controls["UserControl1"].SendToBack();
            }
            else
            {
                panel2.Controls["UserControl8"].SendToBack();
            }

            UserControl2 uc = new UserControl2();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
            panel2.Controls["UserContro2"].BringToFront();


        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeButton.Visible = false;
            AdminButton.Visible = true;
            Inventory.Visible = true;
            _obj = this;

            if (Form4.Instance.panel2.Controls.ContainsKey("UserControl2"))
            {
                panel2.Controls["UserControl2"].SendToBack();
            }
            else
            {
                panel2.Controls["UserControl8"].SendToBack();
            }
            UserControl1 uc = new UserControl1();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
            panel2.Controls["UserContro1"].BringToFront();

        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeButton.Visible = true;
            AdminButton.Visible = true;
            Inventory.Visible = false;
            _obj = this;

            if (Form4.Instance.panel2.Controls.ContainsKey("UserControl2"))
            {
                panel2.Controls["UserControl2"].SendToBack();
            }
            else
            {
                panel2.Controls["UserControl1"].SendToBack();
            }
            UserControl8 uc = new UserControl8();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
            panel2.Controls["UserControl8"].BringToFront();
        }
    }
}

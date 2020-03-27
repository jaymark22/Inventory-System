using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddEmployee : UserControl
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("Project");
        static IMongoCollection<Employee> collection = db.GetCollection<Employee>("Cashier");
        public void ReadAllDocuments()
        {
            List<Employee> list = collection.AsQueryable().ToList<Employee>();
            dataGridView1.DataSource = list;
            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
        }
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee s = new Employee(textBox2.Text, textBox3.Text,textBox4.Text);
            collection.InsertOne(s);
            ReadAllDocuments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<Employee>.Update.Set("Name", textBox2.Text).Set("Email", textBox3.Text).Set("Gender", textBox4.Text);
            collection.UpdateOne(s => s.Id == ObjectId.Parse(textBox1.Text), updateDef);
            ReadAllDocuments();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(s => s.Id == ObjectId.Parse(textBox1.Text));
            ReadAllDocuments();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using MongoDB.Driver;
using MongoDB.Bson;
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
    public partial class Form8 : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("Project");
        static IMongoCollection<Inventory> collection = db.GetCollection<Inventory>("Inventory");
        public void ReadAllDocuments()
        {
            List<Inventory> list = collection.AsQueryable().ToList<Inventory>();
            dataGridView1.DataSource = list;
            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
        }
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Inventory s = new Inventory(textBox2.Text, Int32.Parse(textBox3.Text), Double.Parse(textBox4.Text), 
Int32.Parse(textBox5.Text), Double.Parse(textBox6.Text),Double.Parse(textBox7.Text), Double.Parse(textBox8.Text));
            collection.InsertOne(s);
            ReadAllDocuments();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<Inventory>.Update.Set("Products", textBox2.Text).Set("Quantity", textBox3.Text).Set("Original Products' Price", textBox4.Text).Set("Sold Products", textBox5.Text)
                .Set("Sell Price", textBox6.Text).Set("Total of Sell Products", textBox7.Text).Set("Total Products' Cost", textBox8.Text);
            collection.UpdateOne(s => s.Id == ObjectId.Parse(textBox1.Text), updateDef);
            ReadAllDocuments();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(s => s.Id == ObjectId.Parse(textBox1.Text));
            ReadAllDocuments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 myForm = new Form7();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}

﻿using MongoDB.Driver;
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
    public partial class Form6 : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("studentDB");
        static IMongoCollection<Student> collection = db.GetCollection<Student>("students");

        public void ReadAllDocuments() {
            List<Student> list = collection.AsQueryable().ToList<Student>();
            dataGridView1.DataSource = list;
            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Student s = new Student(textBox2.Text, Double.Parse(textBox3.Text));
            collection.InsertOne(s);
            ReadAllDocuments();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var updateDef = Builders<Student>.Update.Set("name", textBox2.Text).Set("gpa", textBox3.Text);
            collection.UpdateOne(s=>s.Id == ObjectId.Parse(textBox1.Text), updateDef);
            ReadAllDocuments();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(s => s.Id == ObjectId.Parse(textBox1.Text));
            ReadAllDocuments();
        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        ws28Entities conn = new ws28Entities();
        public Form4()
        {
            InitializeComponent();
            dataGridView1.DataSource = conn.tv.ToList();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.tv.Where(c => c.Nazv.ToString().Contains(textBox3.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null && textBox4.Text != null && textBox5.Text != null && textBox6.Text != null && textBox7.Text != null && textBox8.Text != null && textBox9.Text != null && textBox10.Text != null);
            { 
                tv add = new tv();
                add.Id_t = Convert.ToInt32(textBox9.Text);
                add.Nazv = textBox1.Text;
                add.Cena = textBox2.Text;
                add.Brend = textBox4.Text;
                add.Harki = textBox5.Text;
                add.Visota = textBox6.Text;
                add.Shirina = textBox7.Text;
                add.Glubina = textBox8.Text;
                add.Id_Type= Convert.ToInt32(textBox10.Text);
                //add.Id_Ya = Convert.ToInt32(textBox11.Text);
                conn.tv.Add(add);
                conn.SaveChanges();
                dataGridView1.DataSource = conn.tv.ToList();
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                //textBox11.Clear();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            tv dele = conn.tv.Where(c => c.Id_t == id ).FirstOrDefault();
            if (dele != null)
            {
                conn.tv.Remove(dele);
                conn.SaveChanges();
                dataGridView1.DataSource = conn.tv.ToList();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

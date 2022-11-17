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
    public partial class Form2 : Form
    {
        ws28Entities conn = new ws28Entities();

        public Form2()
        {

            InitializeComponent();
            dataGridView1.DataSource = conn.Vxod.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null && comboBox1.Text != null)
            {
                Vxod add = new Vxod();
                add.Login = textBox1.Text;
                add.Password = textBox2.Text;
                add.Role = Convert.ToInt32(comboBox1.Text);
                conn.Vxod.Add(add);
                conn.SaveChanges();
                dataGridView1.DataSource = conn.Vxod.ToList();
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].Value.ToString();
            Vxod del = conn.Vxod.Where(c => c.Login == id && c.Role != 1 ).FirstOrDefault();
            if (del != null)
            {
                conn.Vxod.Remove(del);
                conn.SaveChanges();
                dataGridView1.DataSource = conn.Vxod.ToList();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.Vxod.Where(c => c.Login.ToString().Contains(textBox3.Text)).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.SaveChanges();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string password = dataGridView1.SelectedCells[1].Value.ToString();
            int role = Convert.ToInt32(dataGridView1.SelectedCells[2].Value);
            Form3 f = new Form3(password,role);
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

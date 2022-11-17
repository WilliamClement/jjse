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
    public partial class Form5 : Form
    {
        ws28Entities conn = new ws28Entities();
        public Form5()
        {
            InitializeComponent();
            var
            content = conn.Yac.ToList();
            foreach (Yac item in content)
            {
                comboBox1.Items.Add(item.ID_Ya);
            }
            var
            content1 = conn.tv.ToList();
            foreach(tv item in content1)
            {               
                comboBox2.Items.Add(item.Nazv +"");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.Yac.ToList();
            dataGridView2.DataSource = conn.tv.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null && comboBox2.Text != null)
            {
                Yac add1 = new Yac();
                tv add = new tv();
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    
    public partial class Form3 : Form
    {
        ws28Entities conn = new ws28Entities();
        public Form3(string password, int role)
        {
            InitializeComponent();
            Vxod select = conn.Vxod.Where(c => c.Password == password).FirstOrDefault();
            if(select != null)
            {
                textBox1.Text = select.Password;
            }
            Vxod Rselect = conn.Vxod.Where(c => c.Role == role).FirstOrDefault();
            if (select != null)
            {
                textBox3.Text = Rselect.Role.ToString();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectrole = Convert.ToInt32(textBox3.Text);
            Vxod select = conn.Vxod.Where(c => c.Password == textBox1.Text).FirstOrDefault();
            Vxod rselect = conn.Vxod.Where(c => c.Role == selectrole).FirstOrDefault();
            int newrole = Convert.ToInt32(comboBox1.SelectedItem);
            rselect.Role = newrole;
            select.Password = textBox2.Text;
            conn.SaveChanges();
            this.Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

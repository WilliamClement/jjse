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
    public partial class Form1 : Form
    {
        ws28Entities conn = new ws28Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vxod select = conn.Vxod.Where(c => c.Login == textBox1.Text && c.Password == textBox2.Text).FirstOrDefault();
            if (select != null)
            {
                Stuff.Role = select.Role.ToString();
                switch (Stuff.Role)
                {
                    case "1":
                        {
                            MessageBox.Show(" Добро пожаловать Администратор");
                            Form2 f = new Form2();
                            f.ShowDialog();
                            break;
                        }
                    case "2":
                        {
                            MessageBox.Show(" Добро пожаловать Кладовщик");
                            Form4 f = new Form4();
                            f.ShowDialog();
                            break;
                        }
                    case "3":
                        {
                            MessageBox.Show(" Добро пожаловать Ящечник");
                            Form5 f = new Form5();
                            f.ShowDialog();
                            break;
                        }
                }
            }
            else MessageBox.Show(" Данные не верные ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

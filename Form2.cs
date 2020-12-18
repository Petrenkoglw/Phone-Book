using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhoneBook
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Заполните оба поля", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string m = textBox1.Text;
                string text = File.ReadAllText("base.txt");
                using(StreamReader sr = new StreamReader("base.txt")) 
                {
                    if (text.Contains(m))
                    {
                        MessageBox.Show("Контакт уже существует");
                    }
                    else
                    {
                         sr.Close();
                        System.IO.StreamWriter writer = new System.IO.StreamWriter("base.txt", true);
 
                            writer.WriteLine(textBox1.Text);
                            writer.WriteLine(textBox2.Text);
                            writer.Close();
                            textBox1.Text = "";
                            textBox2.Text = "";
                            MessageBox.Show("Контакт сохранен");
                        Close();


                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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

    public struct people
    {
        public string name;
        public string number;
    }


    public partial class Form1 : Form
    {
        List<people> l = new List<people>();



        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("base.txt");
            string m;
            while ((m = sr.ReadLine()) != null)
            {
                people A;
                A.name = m;
                A.number = sr.ReadLine();
                l.Add(A);

            }
            sr.Close();


            string s = textBox1.Text;
            int x = find(s);
            if (x != -1)
                textBox2.Text = l[x].number;
            else
                MessageBox.Show("Контакт не найен");
        }



        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        int find(string s)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].name.Equals(s))
                {
                    return i;
                }
            }
            return -1;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jisuanqi2
{
    public partial class Form1 : Form
    {
        double num1, num2, result;
        int x;
        public Form1()
        {
            InitializeComponent();
        }
        

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            num1 = Convert.ToInt64(s1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s2 = textBox2.Text;
            num2 = Convert.ToInt64(s2);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            x = 0;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            x = 1;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            x = 2;
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            x = 3;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case 0: result = num1 + num2; break;
                case 1: result = num1 - num2; break;
                case 2: result = num1 * num2; break;
                case 3: result = num1 / num2; break;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

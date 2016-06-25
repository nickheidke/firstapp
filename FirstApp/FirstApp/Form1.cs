using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        int count = 1;

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = int.Parse(textBox1.Text);

            count = count + 1;

            textBox1.Text = count.ToString();

            ColorChange();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ColorChange();
        }

        private void ColorChange()
        {
            if (textBox1.Text == "")
            {
                count = 0;
            }
            else
            {
                count = int.Parse(textBox1.Text);
            }

            //if 0
            if (count == 0)
            {
                textBox1.BackColor = Color.Black;
                textBox1.ForeColor = Color.White;
            } 
            //if even
            else if(count % 2 == 0)
            {
                textBox1.BackColor = Color.HotPink;
                textBox1.ForeColor = Color.Black;
            }
            //if odd
            else
            {
                textBox1.BackColor = Color.Indigo;
                textBox1.ForeColor = Color.White;
            }
        }
    }
}

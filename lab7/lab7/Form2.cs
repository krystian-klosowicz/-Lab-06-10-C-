using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) textBox1.Font = new Font("Microsoft Sans Serif", 8);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) textBox1.Font = new Font("Microsoft Sans Serif", 16);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) textBox1.Font = new Font("Microsoft Sans Serif", 24);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox1.ForeColor = Color.Green;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
            }
            if (checkBox1.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Underline);
            }

            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
            }

            if (checkBox2.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic | FontStyle.Underline);
            }
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }
            if (checkBox2.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic | FontStyle.Underline);
            }
            if (checkBox1.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Underline);
            }
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
        }
    }
}

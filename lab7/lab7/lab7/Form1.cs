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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) checkBox2.Checked = false;
                else checkBox2.Checked = true;  
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) checkBox1.Checked = false;
            else checkBox1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!textBox1.Equals("") && (radioButton1.Checked || radioButton2.Checked))
            {
                if(checkBox1.Checked)
                {
                    int wynik = int.Parse(textBox1.Text)-100;
                    textBox2.Text = wynik.ToString();
                }else
                {
                    if(radioButton1.Checked)
                    {
                        double wynik = Double.Parse(textBox1.Text) - 100;
                        wynik = wynik * 0.85;
                        textBox2.Text = wynik.ToString();
                    }else
                    {
                        double wynik = Double.Parse(textBox1.Text) - 100;
                        wynik = wynik * 0.9;
                        textBox2.Text = wynik.ToString();
                    }
                }
            }
        }
    }
}

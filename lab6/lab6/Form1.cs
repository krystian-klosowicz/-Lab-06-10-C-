using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float wynik = float.Parse(textBox1.Text) + float.Parse(textBox2.Text) + float.Parse(textBox3.Text);
                textBox4.Text = wynik.ToString();
            }catch(Exception)
            {
                MessageBox.Show("Bledne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float wynik = float.Parse(textBox1.Text) * float.Parse(textBox2.Text) * float.Parse(textBox3.Text);
                textBox4.Text = wynik.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Bledne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

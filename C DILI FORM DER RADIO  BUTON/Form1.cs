using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_DILI_FORM_DER_RADIO__BUTON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int number1, number2;
        int divide, collectıon, extractıon, ımpact;

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            divide = number1 / number2;
            label4.Text = divide.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            ımpact = number1 * number2;
            label4.Text = ımpact.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            extractıon = number1 - number2;
            label4.Text = extractıon.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            collectıon = number1 + number2;
            label4.Text = collectıon.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

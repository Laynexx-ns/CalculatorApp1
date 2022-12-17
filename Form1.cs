using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp1
{
    public partial class bttminus : Form
    {
        public bttminus()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bttsum_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int.TryParse(textBox1.Text, out num1);
            int num2 = int.Parse(textBox2.Text);

            int ressum = num1 + num2;
            res.Text = ressum.ToString();
            resinf.Text = num1.ToString() + " + " + num2.ToString() + " = " + ressum.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int resdiv = num1 - num2;
            res.Text = resdiv.ToString();
            resinf.Text = num1.ToString() + " - " + num2.ToString() + " = " + resdiv.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int resdel = num1 % num2;
            res.Text = resdel.ToString();
            resinf.Text = num1.ToString() + " % " + num2.ToString() + " = " + resdel.ToString();
        }
    }
}

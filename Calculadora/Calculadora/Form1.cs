using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
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

        private void button1_Click(object sender, EventArgs e)
        {
            int Valor1, Valor2, Result;

            Valor1 = Convert.ToInt16(textBox1.Text);
            Valor2 = Convert.ToInt16(textBox2.Text);

            Result = Valor1 + Valor2;

            label4.Text = Convert.ToString(Result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Valor1, Valor2, Result;

            Valor1 = Convert.ToInt16(textBox1.Text);
            Valor2 = Convert.ToInt16(textBox2.Text);

            Result = Valor1 - Valor2;

            label4.Text = Convert.ToString(Result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Valor1, Valor2, Result;

            Valor1 = Convert.ToInt16(textBox1.Text);
            Valor2 = Convert.ToInt16(textBox2.Text);

            Result = Valor1 * Valor2;

            label4.Text = Convert.ToString(Result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float Valor1, Valor2, Result;

            Valor1 = Convert.ToInt16(textBox1.Text);
            Valor2 = Convert.ToInt16(textBox2.Text);

            Result = Valor1 / Valor2;

            label4.Text = Convert.ToString(Result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = (" ");
        }
    }
}

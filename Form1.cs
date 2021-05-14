using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value;
        string ooperator;
        bool mem;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number(object sender, EventArgs e)
        {
            if (ooperator == "+" || ooperator == "-" || ooperator == "/" || ooperator == "*")
            {
                if (mem)
                {
                    mem = false;
                    textBox1.Text = "0";
                }
          } 
            Button button = sender as Button;
            if (textBox1.Text == "0")
            {
                textBox1.Text = button.Text;
            }
            else { textBox1.Text += button.Text; }
        }
        private void Operator(object sender, EventArgs e)
        {
            Button button = sender as Button;
            value = double.Parse(textBox1.Text);
            ooperator = button.Text;
            textBox1.Text += button.Text;
            mem = true;
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void ResultBox_Click(object sender, EventArgs e)
        {
            switch (ooperator)
            {
                case "+":textBox1.Text = (value + double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (value - double.Parse(textBox1.Text)).ToString(); break;
                case "*": textBox1.Text = (value * double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (value / double.Parse(textBox1.Text)).ToString(); break;
                case "Root": textBox1.Text = (System.Math.Sqrt(value)).ToString(); break;
            }
        }
    }
}

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
        string input = string.Empty;
        string operation1 = string.Empty;
        string operation2 = string.Empty;
        char calculation;
        double answer = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "+";
            this.textBox1.Text += input;

            operation1 = input;
            calculation = '+';
            input = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "-";
            this.textBox1.Text += input;

            operation1 = input;
            calculation = '-';
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "*";
            this.textBox1.Text += input;

            operation1 = input;
            calculation = '*';
            input = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "/";
            this.textBox1.Text += input;

            operation1 = input;
            calculation = '/';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operation1 = string.Empty;
            this.operation2 = string.Empty;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "=";
            this.textBox1.Text += input;

            operation2 = input;
            double num1, num2;
            double TryParse(operation1, out num1);
            double.TryParse(operation2, out num2);

            if(calculation == '+')
            {
                answer = num1 + num2;
                textBox1.Text = answer.ToString();          
            }
            if(calculation == '-')
            {
                answer = num1 - num2;
                textBox1.Text = answer.ToString();          
            }
            if(calculation == '*')
            {
                answer = num1 * num2;
                textBox1.Text = answer.ToString();          
            }
            if(calculation == '/')
            {
                if(num2 != 0)
                {
                answer = num1 / num2;
                textBox1.Text = answer.ToString();          
                }  
                else
                {
                    textBox1.Text = "Can't divide by 0";
                }
            }
        }
    }
}

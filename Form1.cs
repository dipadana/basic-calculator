using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Dipadana
{
    public partial class Form_Dipadana : Form
    {
        string calculate = "";

        public Form_Dipadana()
        {
            InitializeComponent();
        }

        private void Form_Dipadana_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length -1);
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calculate = "/";
            textBox1.Text = textBox1.Text + "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calculate = "x";
            textBox1.Text = textBox1.Text + "x";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calculate = "-";
            textBox1.Text = textBox1.Text + "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate = "+";
            textBox1.Text = textBox1.Text + "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (calculate == "+")
            {
                string[] splitString = textBox1.Text.Split('+');
                textBox1.Text = (Int32.Parse(splitString[0]) + Int32.Parse(splitString[1])).ToString();
            }
            else if (calculate == "-") {
                string[] splitString = textBox1.Text.Split('-');
                textBox1.Text = (Int32.Parse(splitString[0]) - Int32.Parse(splitString[1])).ToString();
            }
            else if (calculate == "/")
            {
                string[] splitString = textBox1.Text.Split('/');
                textBox1.Text = (Int32.Parse(splitString[0]) / Int32.Parse(splitString[1])).ToString();
            }
            else if (calculate == "x")
            {
                string[] splitString = textBox1.Text.Split('x');
                textBox1.Text = (Int32.Parse(splitString[0]) * Int32.Parse(splitString[1])).ToString();
            }
            System.Diagnostics.Debug.WriteLine(textBox1.Text);
        }
    }
}

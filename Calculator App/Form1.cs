using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // declaring variables 

        string calTotal;
        int num1;
        int num2;
        int calResult;
        string calOperation;

        // clear textbox

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button9.Text;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button0.Text;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            calOperation = "+";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
            calOperation = "-";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }
        private void buttonMul_Click(object sender, EventArgs e)
        {
            calOperation = "*";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            calOperation = "/";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textTotal.Text);

            if (calOperation.Equals("+"))
                // add numbers
                calResult = num1 + num2;
            if (calOperation.Equals("="))
                // minus numbers
                calResult = num1 - num2;
            if (calOperation.Equals("*"))
                // multiply numbers
                calResult = num1 * num2;
            if (calOperation.Equals("/"))
                // divide numbers
                calResult = num1 / num2;

            // display the result - sum is finished
            textTotal.Text = calResult + "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textTotal.Clear();
            calResult = 0;
            num1 = 0;
            num2 = 0;
            calOperation = "";
        }
    }
}

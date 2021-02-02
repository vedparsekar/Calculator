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
    public partial class Calculator : Form
    {
        string exp = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exp = exp + '1';
            
            dis_clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exp = exp + '2';
            dis_clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exp = exp + '3';
            dis_clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            exp = exp + '4';
            dis_clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            exp = exp + '5';
            dis_clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            exp = exp + '6';
            dis_clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            exp = exp + '7';
            dis_clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            exp = exp + '8';
            dis_clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            exp = exp + '9';
            dis_clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            exp = exp + '0';
            dis_clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            exp = exp + '+';
            dis_clear();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            double result=0;
            string s = Display.Text;
            try
            {
                result = Convert.ToDouble(new DataTable().Compute(s, null));
            }
            catch
            {
                Display.Text += "Error";
            } 
            finally
            {
                Display.Clear();
                Display.Text += result.ToString();
                exp = result.ToString();
            }
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        void dis_clear()
        {
            Display.Clear();
            Display.Text += exp;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Display.Clear();
            exp = "";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            exp = exp + '/';
            dis_clear();
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            exp = exp + '*';
            dis_clear();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            exp = exp + '-';
            dis_clear();
        }

        private void dot_Click(object sender, EventArgs e)
        {
            exp = exp + '.';
            dis_clear();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (exp.Length != 0)
            {
                exp = exp.Substring(0, exp.Length - 1);
            }
            dis_clear();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            if (obj == null)
            {
                //obj.Parent = this;
            }
            obj.Show();
        }
    }
}

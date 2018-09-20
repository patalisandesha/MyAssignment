using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int DotCnt = 0;
        public bool isOperationPerformed = false;
        private string operation;
        private double Value;
        private Label TotalValue;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" || (isOperationPerformed)))
                
            {
                textBox1.Clear();
            }
            Button btn = (Button)sender;
            //if(textBox1.Text == "." )
            //{
            //    textBox1.Text = textBox1.Text+ "0" + ".";
            //}

            //if (btn.Text == "." && DotCnt < 1)
            //{
            //    DotCnt++;
            //    textBox1.Text += btn.Text;
            //}
            //else if(btn.Text != ".")
            //{
            //    textBox1.Text += btn.Text;
            //}
            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += btn.Text;
                }
            }

            else
            {
                textBox1.Text += btn.Text;
            } 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void operation_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                Value += Double.Parse(textBox1.Text);
                isOperationPerformed = true;
                label2.Text += Value + " " + operation;
                TotalValue = label2;
                // textBox1.Text = Value + " " + operation;
            }
            catch
            {
                MessageBox.Show("Please enter Currect values");
            }
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "";
                switch (operation)
                {

                    case "+": textBox1.Text = (Value + double.Parse(textBox1.Text)).ToString(); break;
                    case "-": textBox1.Text = (Value - double.Parse(textBox1.Text)).ToString(); break;
                    case "*": textBox1.Text = (Value * double.Parse(textBox1.Text)).ToString(); break;
                    case "/":
                        if (Double.Parse(textBox1.Text) == 0) MessageBox.Show("Trying to devide by 0. ", "math error");
                        else
                            textBox1.Text = (Value / double.Parse(textBox1.Text)).ToString(); break;
                    case "%": textBox1.Text = (Value % double.Parse(textBox1.Text)).ToString(); break;
                    case "Squrt": textBox1.Text = (Math.Sqrt(Value).ToString()); break;
                    case "1/x": textBox1.Text = (1/Value).ToString(); break;

                    default: break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("unexpected error" + ex.Message, "Math error");
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label2.Text = "";
            DotCnt = 0;
            Value = 0;
            isOperationPerformed = false;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            textBox1.Text = (textBox1.Text.Substring(0,textBox1.Text.Length - 1));
        }

        private void modulebtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void offBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

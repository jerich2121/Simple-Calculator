using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Holds first number clicked
        double firstValue = 0;

        // Holds the operator (+, -, *, /)
        string operation = "";

        // Tracks when to clear screen
        bool isOperationClicked = false;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || isOperationClicked)
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }

            isOperationClicked = false;
        }


        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || isOperationClicked)
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }

            isOperationClicked = false;
        }


        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || isOperationClicked)
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }

            isOperationClicked = false;
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || isOperationClicked)
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }

            isOperationClicked = false;
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || isOperationClicked)
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }

            isOperationClicked = false;
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || isOperationClicked)
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }

            isOperationClicked = false;
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || isOperationClicked)
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }

            isOperationClicked = false;
        }


        private void btn7_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || isOperationClicked)
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }

            isOperationClicked = false;
        }


        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || isOperationClicked)
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }

            isOperationClicked = false;
        }


        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || isOperationClicked)
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }

            isOperationClicked = false;
        }


        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            firstValue = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isOperationClicked = true;
        }


        private void btnMul_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            firstValue = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isOperationClicked = true;
        }


        private void btnSub_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            firstValue = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isOperationClicked = true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            firstValue = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isOperationClicked = true;
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondValue = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    {
                        result = firstValue + secondValue;
                        break;
                    }

                case "-":
                    {
                        result = firstValue - secondValue;
                        break;
                    }

                case "*":
                    {
                        result = firstValue * secondValue;
                        break;
                    }

                case "/":
                    {
                        if (secondValue == 0)
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        else
                        {
                            result = firstValue / secondValue;
                        }
                        break;
                    }
            }

            txtDisplay.Text = result.ToString();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstValue = 0;
            operation = "";
            isOperationClicked = false;
        }


        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }
    }
}

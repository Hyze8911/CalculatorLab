using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        string value1;
        string value2;
        char operation;
        bool OPercent = false;
        float result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "0";
            }
            else if (lblDisplay.Text.Length == 8)
            {

            }
            else
            {
                lblDisplay.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "1";
            }
            else if (lblDisplay.Text.Length == 8)
            {

            }
            else
            {
                lblDisplay.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "2";
            }
            else if (lblDisplay.Text.Length == 8)
            {

            }
            else
            {
                lblDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "3";
            }
            else if (lblDisplay.Text.Length == 8)
            {

            }
            else
            {
                lblDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "4";
            }
            else if (lblDisplay.Text.Length == 8)
            {

            }
            else
            {
                lblDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "5";
            }
            else if (lblDisplay.Text.Length == 8)
            {

            }
            else
            {
                lblDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "6";
            }
            else if (lblDisplay.Text.Length == 8)
            {

            }
            else
            {
                lblDisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "7";
            }
            else if (lblDisplay.Text.Length == 8)
            {

            }
            else
            {
                lblDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "8";
            }
            else if (lblDisplay.Text.Length == 8)
            {

            }
            else
            {
                lblDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "9";
            }
            else if (lblDisplay.Text.Length == 8)
            {

            }
            else
            {
                lblDisplay.Text += "9";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text.Contains(".") == false)
                {
                    lblDisplay.Text += ".";
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            value1 = lblDisplay.Text;
            operation = '+';
            lblDisplay.Text = string.Empty;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            value1 = lblDisplay.Text;
            operation = '-';
            lblDisplay.Text = string.Empty;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            value1 = lblDisplay.Text;
            operation = '*';
            lblDisplay.Text = string.Empty;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            value1 = lblDisplay.Text;
            operation = '/';
            lblDisplay.Text = string.Empty;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(value1))
            {
                value1 = lblDisplay.Text;
            }
            OPercent = true;
//            btnEqual_Click(sender, e);            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            value2 = lblDisplay.Text;
            float tmpValue1, tmpValue2;
            tmpValue1 = float.Parse(value1);
            tmpValue2 = float.Parse(value2);
            if (OPercent == true)
            {
                float percentage = tmpValue2 / 100;
                if (operation == '+')
                {
                    result = tmpValue1 + (tmpValue1 * percentage);
                }
                else if (operation == '-')
                {
                    result = tmpValue1 - (tmpValue1 * percentage);
                }
                else if (operation == '*')
                {
                    result = tmpValue1 * tmpValue1 * percentage;
                }
                else if (operation == '/')
                {
                    
                    result = tmpValue1 / (tmpValue1 * percentage);
                }
                else
                {
                    result = tmpValue1;
                }
                OPercent = false;            
            }
            else
            {
                if (operation == '+')
                {
                    result = tmpValue1 + tmpValue2;
                }
                else if (operation == '-')
                {
                    result = tmpValue1 - tmpValue2;
                }
                else if (operation == '*')
                {
                    result = tmpValue1 * tmpValue2;
                }
                else if (operation == '/')
                {
                    result = tmpValue1 / tmpValue2;
                }
                else
                {
                    result = tmpValue1;
                }
            }            
            lblDisplay.Text = Convert.ToString(result);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {            
            if (lblDisplay.Text == "0")
            {
                
            }
            else if (lblDisplay.Text == "-0")
            {
                btnSign_Click(sender, e);
            }
            else if (lblDisplay.Text.Length == 1)
            {
                lblDisplay.Text = "0";
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            result = 0;
            value1 = string.Empty;
            value2 = string.Empty;
            lblDisplay.Text = "0";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains("-") == true)
            {
                lblDisplay.Text = lblDisplay.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(lblDisplay.Text) && decimal.Parse(lblDisplay.Text) != 0)
            {
                lblDisplay.Text = "-" + lblDisplay.Text;
            }
        }
        
    }
}

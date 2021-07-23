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
        public Form1()
        {
            InitializeComponent();
        }

        int clicked_last = -1;
        decimal prev_val = 0;

        bool too_large(decimal val)
        {
            decimal max_val = 999999999;
            return val > max_val || val < -max_val;
        }

        private void add(decimal num)
        {
            decimal val = System.Math.Abs(numTextBox.Value);
            bool negative_num = numTextBox.Value < 0;
            if (!too_large(val * 10))
            {
                if(negative_num)
                {
                    numTextBox.Value = -(val * 10 + num);
                }
                else
                {
                    numTextBox.Value = val * 10 + num;
                }
            }
        }

        private void addition(decimal a, decimal b)
        {
            if(too_large(a + b))
            {
                numTextBox.Value = 0;
            }
            else
            {
                numTextBox.Value = a + b;
            }
        }

        private void subtraction(decimal a, decimal b)
        {
            if (too_large(a - b))
            {
                numTextBox.Value = 0;
            }
            else
            {
                numTextBox.Value = a - b;
            }
        }

        private void multiplication(decimal a, decimal b)
        {
            if (too_large(a * b))
            {
                numTextBox.Value = 0;
            }
            else
            {
                numTextBox.Value = a * b;
            }
        }

        private void division(decimal a, decimal b)
        {
            if(b == 0)
            {
                numTextBox.Value = 0;
                return;
            }
            decimal val = System.Math.Round(a / b);
            if (too_large(val))
            {
                numTextBox.Value = 0;
            }
            else
            {
                numTextBox.Value = val;
            }
        }

        private void clear()
        {
            prev_val = numTextBox.Value;
            numTextBox.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numTextBox.Controls[0].Visible = false;
        }

        private void num00Button_Click(object sender, EventArgs e)
        {
            add(0);
            add(0);
        }

        private void num0Button_Click(object sender, EventArgs e)
        {
            add(0);
        }

        private void num1Button_Click(object sender, EventArgs e)
        {
            add(1);
        }

        private void num2Button_Click(object sender, EventArgs e)
        {
            add(2);
        }

        private void num3Button_Click(object sender, EventArgs e)
        {
            add(3);
        }

        private void num4Button_Click(object sender, EventArgs e)
        {
            add(4);
        }

        private void num5Button_Click(object sender, EventArgs e)
        {
            add(5);
        }

        private void num6Button_Click(object sender, EventArgs e)
        {
            add(6);
        }

        private void num7Button_Click(object sender, EventArgs e)
        {
            add(7);
        }

        private void num8Button_Click(object sender, EventArgs e)
        {
            add(8);
        }

        private void num9Button_Click(object sender, EventArgs e)
        {
            add(9);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void changeSignButton_Click(object sender, EventArgs e)
        {
            numTextBox.Value *= -1;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if(clicked_last == additionButton.TabIndex)
            {
                addition(prev_val, numTextBox.Value);
            }
            else if(clicked_last == subtractionButton.TabIndex)
            {
                subtraction(prev_val, numTextBox.Value);
            }
            else if (clicked_last == multiplicationButton.TabIndex)
            {
                multiplication(prev_val, numTextBox.Value);
            }
            else if (clicked_last == divisionButton.TabIndex)
            {
                division(prev_val, numTextBox.Value);
            }
            clicked_last = equalsButton.TabIndex;
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            clear();
            clicked_last = additionButton.TabIndex;
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            clear();
            clicked_last = subtractionButton.TabIndex;
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            clear();
            clicked_last = multiplicationButton.TabIndex;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            clear();
            clicked_last = divisionButton.TabIndex;
        }

        private void removeCharButton_Click(object sender, EventArgs e)
        {
            decimal val = System.Math.Abs(numTextBox.Value);
            bool negative_num = numTextBox.Value < 0;
            decimal num = System.Math.Floor(val / 10);
            if (negative_num)
            {
                numTextBox.Value = -num;
            }
            else
            {
                numTextBox.Value = num;
            }
        }
    }
}

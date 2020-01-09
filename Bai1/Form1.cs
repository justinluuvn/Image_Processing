using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        double value1 = 0, value2 = 4, value3 = 0, answer = 0, check = 0, count = 0; 
        string text="";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void add_Click(object sender, EventArgs e)
        {            
            if (check == 0)
            {
                value2 = 0;
                check = 1;
                text = text.Insert(text.Length, "+");
            }
            else
            {
                if (value2 == 0)
                    answer = value1 + value3;
                else if (value2 == 1)
                    answer = value1 - value3;
                else if (value2 == 2)
                    answer = value1 * value3;
                else if (value2 == 3)
                    answer = value1 / value3;
                value1 = answer;
                text = answer.ToString();
                text = text.Insert(text.Length, "+");
                value3 = 0;
            }
            count = 0; 
            Answer.Text = text;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            text = "";
            value1 = 0;
            value2 = 4;
            value3 = 0;
            answer = 0;
            count = 0;
            Answer.Text = text;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if(text!="0")
                text=text.Insert(text.Length,"0");
            if (check == 0)
            {
                if(count==0)
                    value1 = value1 * 10;
                else
                    count++;
            }
            else
            {
                if (count == 0)
                {
                    value3 = value3 * 10;
                    check = 2;
                }
                else
                    count++;
            }
            Answer.Text = text;
        }
        
        private void Calculate_Click(object sender, EventArgs e)
        {
            if (check != 0)
            {
                if (value2 == 0)
                    answer = value1 + value3;
                else if (value2 == 1)
                    answer = value1 - value3;
                else if (value2 == 2)
                    answer = value1 * value3;
                else
                    answer = value1 / value3;
                value1 = answer;
                text = answer.ToString();
                value2 = 4;
                value3 = 0;
                check = 0;
            }
            count = 0;
            Answer.Text = text;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            text=text.Insert(text.Length, "1");
            if (check == 0)
            {
                if(count==0)
                    value1 = value1 * 10 + 1;
                else
                {
                    value1 += 1 / Math.Pow(10, count);
                    count++;
                }
            }
            else
            {
                if (count == 0)
                {
                    value3 = value3 * 10 + 1;
                    check = 2;
                }
                else
                {
                    value3 += 1 / Math.Pow(10, count);
                    count++;
                }
            }
            Answer.Text = text;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            text = text.Insert(text.Length, "2");
            if (check == 0)
            {
                if (count == 0)
                    value1 = value1 * 10 + 2;
                else
                {
                    value1 += 2 / Math.Pow(10, count);
                    count++;
                }
            }
            else
            {
                if (count == 0)
                {
                    value3 = value3 * 10 + 2;
                    check = 2;
                }
                else
                {
                    value3 += 2 / Math.Pow(10, count);
                    count++;
                }
            }
            Answer.Text = text;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            text = text.Insert(text.Length, "3");
            if (check == 0)
            {
                if (count == 0)
                    value1 = value1 * 10 + 3;
                else
                {
                    value1 += 3 / Math.Pow(10, count);
                    count++;
                }
            }
            else
            {
                if (count == 0)
                {
                    value3 = value3 * 10 + 3;
                    check = 2;
                }
                else
                {
                    value3 += 3 / Math.Pow(10, count);
                    count++;
                }
            }
            Answer.Text = text;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            text = text.Insert(text.Length, "4");
            if (check == 0)
            {
                if (count == 0)
                    value1 = value1 * 10 + 4;
                else
                {
                    value1 += 4 / Math.Pow(10, count);
                    count++;
                }
            }
            else
            {
                if (count == 0)
                {
                    value3 = value3 * 10 + 4;
                    check = 2;
                }
                else
                {
                    value3 += 4 / Math.Pow(10, count);
                    count++;
                }
            }
            Answer.Text = text;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            text = text.Insert(text.Length, "5");
            if (check == 0)
            {
                if (count == 0)
                    value1 = value1 * 10 + 5;
                else
                {
                    value1 += 5 / Math.Pow(10, count);
                    count++;
                }
            }
            else
            {
                if (count == 0)
                {
                    value3 = value3 * 10 + 5;
                    check = 2;
                }
                else
                {
                    value3 += 5 / Math.Pow(10, count);
                    count++;
                }
            }
            Answer.Text = text;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            text = text.Insert(text.Length, "6");
            if (check == 0)
            {
                if (count == 0)
                    value1 = value1 * 10 + 6;
                else
                {
                    value1 += 6 / Math.Pow(10, count);
                    count++;
                }
            }
            else
            {
                if (count == 0)
                {
                    value3 = value3 * 10 + 6;
                    check = 2;
                }
                else
                {
                    value3 += 6 / Math.Pow(10, count);
                    count++;
                }
            }
            Answer.Text = text;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            text = text.Insert(text.Length, "7");
            if (check == 0)
            {
                if (count == 0)
                    value1 = value1 * 10 + 7;
                else
                {
                    value1 += 7 / Math.Pow(10, count);
                    count++;
                }
            }
            else
            {
                if (count == 0)
                {
                    value3 = value3 * 10 + 7;
                    check = 2;
                }
                else
                {
                    value3 += 7 / Math.Pow(10, count);
                    count++;
                }
            }
            Answer.Text = text;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            text = text.Insert(text.Length, "8");
            if (check == 0)
            {
                if (count == 0)
                    value1 = value1 * 10 + 8;
                else
                {
                    value1 += 8 / Math.Pow(10, count);
                    count++;
                }
            }
            else
            {
                if (count == 0)
                {
                    value3 = value3 * 10 + 8;
                    check = 2;
                }
                else
                {
                    value3 += 8 / Math.Pow(10, count);
                    count++;
                }
            }
            Answer.Text = text;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            text = text.Insert(text.Length, "9");
            if (check == 0)
            {
                if (count == 0)
                    value1 = value1 * 10 + 9;
                else
                {
                    value1 += 9 / Math.Pow(10, count);
                    count++;
                }
            }
            else
            {
                if (count == 0)
                {
                    value3 = value3 * 10 + 9;
                    check = 2;
                }
                else
                {
                    value3 += 9 / Math.Pow(10,count);
                    count++;
                }
            }
            Answer.Text = text;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                value2 = 1;
                check = 1;
                text = text.Insert(text.Length, "-");
            }
            else
            {
                if (value2 == 0)
                    answer = value1 + value3;
                else if (value2 == 1)
                    answer = value1 - value3;
                else if (value2 == 2)
                    answer = value1 * value3;
                else if (value2 == 3)
                    answer = value1 / value3;
                value1 = answer;
                text = answer.ToString();
                text = text.Insert(text.Length, "-");
                value3 = 0;
            }
            count = 0;
            Answer.Text = text;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                value2 = 2;
                check = 1;
                text = text.Insert(text.Length, "x");
            }
            else
            {
                if (value2 == 0)
                    answer = value1 + value3;
                else if (value2 == 1)
                    answer = value1 - value3;
                else if (value2 == 2)
                    answer = value1 * value3;
                else if (value2 == 3)
                    answer = value1 / value3;
                value1 = answer;
                text = answer.ToString();
                text = text.Insert(text.Length, "x");
                value3 = 0;
            }
            count = 0;
            Answer.Text = text;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                value2 = 3;
                check = 1;
                text = text.Insert(text.Length, ":");
            }
            else
            {
                if (value2 == 0)
                    answer = value1 + value3;
                else if (value2 == 1)
                    answer = value1 - value3;
                else if (value2 == 2)
                    answer = value1 * value3;
                else if (value2 == 3)
                    answer = value1 / value3;
                value1 = answer;
                text = answer.ToString();
                text = text.Insert(text.Length, ":");
                value3 = 0;
            }
            count = 0;
            Answer.Text = text;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (text.Length != 0)
            {
                if (check == 0)
                {
                    text = text.Remove(text.Length - 1);
                    value1 = double.Parse(text);
                }
                else if (check == 1)
                {
                    check--;
                    text = text.Remove(text.Length - 1);
                }
                else
                {
                    text = text.Remove(text.Length - 1);
                    if (count == 0)
                        value3 = (value3 - value3 % 10) / 10;
                    else if (count > 1)
                    {
                        count--;
                        value3 = value3 * Math.Pow(10, count);
                        value3 = (value3 - value3 % 10) / Math.Pow(10, count);
                    }
                }
            }
            Answer.Text = text;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            text = text.Insert(text.Length, ".");
            count = 1;
            Answer.Text = text;
        }
        
    }
}

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
    public partial class Form2 : Form
    {
        long number=0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Enable_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                Enable.Text = "Disable";
            }
            else
            {
                timer1.Enabled = false;
                Enable.Text = "Enable";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (number < 256)
            {
                number = number + 1;
                string text = Convert.ToString(number, 2);
                int length = 8 - text.Length;
                for (int i = 0; i < length; i++)
                {
                    text = text.Insert(0, "0");
                }
                timer.Text = text;
            }
            else
                number = 0;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer.Text = "00000000";
            number = 0;
        }
    }
}

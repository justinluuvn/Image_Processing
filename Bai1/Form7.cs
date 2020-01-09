using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form7 : Form
    {
        Bitmap temp0, temp1;
        public Form7(Bitmap image)
        {
            InitializeComponent();
            temp0 = (Bitmap)image.Clone();
            temp1 = new Bitmap(image, new Size(873, 485));
            pictureBox1.Image = temp1;
        }

        public Bitmap result { get; set; }

        int x, y, y1, x1;

        private void button1_Click(object sender, EventArgs e)
        {
            long x2 = x * temp0.Width / 873;
            long y2 = y * temp0.Height / 485;
            long x3 = x1 * temp0.Width / 873;
            long y3 = y1 * temp0.Height / 485;
            Bitmap bmap = (Bitmap)temp0.Clone();
            long width = x3-x2, height = y3-y2;
            Rectangle rect = new Rectangle(Convert.ToInt16(x2), Convert.ToInt16(y2), Convert.ToInt16(width), Convert.ToInt16(height));
            result = bmap.Clone(rect, bmap.PixelFormat);
            //result = a;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool crop = false;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (crop == true)
            {
                Bitmap temp = (Bitmap)temp1.Clone();
                Graphics gr = Graphics.FromImage(temp);
                Brush cBrush = new Pen(Color.FromArgb(150, Color.White)).Brush;
                Rectangle rect1 = new Rectangle(0, 0, pictureBox1.Image.Width, y);
                Rectangle rect2 = new Rectangle(0, y, x, Math.Abs(y - e.Y));
                Rectangle rect3 = new Rectangle(0, e.Y, pictureBox1.Image.Width, pictureBox1.Image.Height);
                Rectangle rect4 = new Rectangle(e.X, y, (pictureBox1.Image.Width - e.X), Math.Abs(y - e.Y));
                gr.FillRectangle(cBrush, rect1);
                gr.FillRectangle(cBrush, rect2);
                gr.FillRectangle(cBrush, rect3);
                gr.FillRectangle(cBrush, rect4);
                pictureBox1.Image = temp;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (crop == false)
            {
                x = e.X;
                y = e.Y;
                crop = true;
            }
            else
            {
                x1 = e.X;
                y1 = e.Y;
                crop = false;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form4 : Form
    {
        string dirName;
        bool init = false, crop=false;
        Bitmap c;
        Bitmap mybm;
        Bitmap u;
        Image temporary0;
        Image temporary;
        int x, y;
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Search for Pictures";
            fdlg.InitialDirectory = @"C:\Users\User\Pictures";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                dirName =  System.IO.Path.GetFullPath(fdlg.FileName);
                mybm = (Bitmap)Image.FromFile(dirName);
                original.Image = mybm;
                temporary = mybm;
            }
        }

        public static Bitmap resizeImage(Bitmap imgToResize, Size size)
        {
            return (Bitmap)(new Bitmap(imgToResize, size));
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            try
            {
                c = (Bitmap)original.Image;
                original.Image = c;
                int x, y;
                if (Scale.SelectedIndex == 0)
                {
                    for (x = 0; x < c.Width; x++)
                    {
                        for (y = 0; y < c.Height; y++)
                        {
                            Color pixelColor = c.GetPixel(x, y);
                            Color newColor = Color.FromArgb((pixelColor.R + pixelColor.G + pixelColor.B) / 3, (pixelColor.R + pixelColor.G + pixelColor.B) / 3, (pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                            c.SetPixel(x, y, newColor);
                        }
                    }
                    converted.Image = c;
                    //mybm = (Bitmap)Image.FromFile(dirName);
                }
                else if (Scale.SelectedIndex == 1)
                {
                    for (x = 0; x < c.Width; x++)
                    {
                        for (y = 0; y < c.Height; y++)
                        {
                            Color pixelColor = c.GetPixel(x, y);
                            Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                            c.SetPixel(x, y, newColor);
                        }
                    }
                    converted.Image = c;
                   // mybm = (Bitmap)Image.FromFile(dirName);
                }
                else if (Scale.SelectedIndex == 2)
                {
                    for (x = 0; x < c.Width; x++)
                    {
                        for (y = 0; y < c.Height; y++)
                        {
                            Color pixelColor = c.GetPixel(x, y);
                            Color newColor = Color.FromArgb(0, pixelColor.G, 0);
                            c.SetPixel(x, y, newColor);
                        }
                    }
                    converted.Image = c;
                   // mybm = (Bitmap)Image.FromFile(dirName);
                }
                else if (Scale.SelectedIndex == 3)
                {
                    for (x = 0; x < c.Width; x++)
                    {
                        for (y = 0; y < c.Height; y++)
                        {
                            Color pixelColor = c.GetPixel(x, y);
                            Color newColor = Color.FromArgb(0, 0, pixelColor.B);
                            c.SetPixel(x, y, newColor);
                        }
                    }
                    converted.Image = c;
                    //mybm = (Bitmap)Image.FromFile(dirName);
                }
                else if (Scale.SelectedIndex == 4)
                {
                    Bitmap temp = (Bitmap)mybm;
                    Bitmap bmap = (Bitmap)temp.Clone();
                    Color c;
                    for (int i = 0; i < bmap.Width; i++)
                    {
                        for (int j = 0; j < bmap.Height; j++)
                        {
                            c = bmap.GetPixel(i, j);
                            bmap.SetPixel(i, j,
                            Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                        }
                    }
                    converted.Image = (Bitmap)bmap.Clone();
                }
                else
                    converted.Image = original.Image;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please load an image", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            temporary = (Bitmap)Image.FromFile(dirName);
            original.Image = temporary;
            temporary0 = converted.Image;
        }        

        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {            
            if(comboBox1.SelectedIndex==1)
            {
                int b = 50 + trackBar1.Value * 5;
                textBox1.Text = b.ToString() + "%";
            }
            if(comboBox1.SelectedIndex==0)
            {
                switch(trackBar1.Value)
                {
                    case 0:
                        textBox1.Text = "25%";
                        break;
                    case 1:
                        textBox1.Text = "50%";
                        break;
                    case 2:
                        textBox1.Text = "75%";
                        break;
                    case 3:
                        textBox1.Text = "100%";
                        break;
                    case 4:
                        textBox1.Text = "150%";
                        break;
                    case 5:
                        textBox1.Text = "200%";
                        break;
                    case 6:
                        textBox1.Text = "400%";
                        break;
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                switch (trackBar1.Value)
                {
                    case 0:
                        textBox1.Text = "Original";
                        break;
                    case 1:
                        textBox1.Text = "3x3 filter";
                        break;
                    case 2:
                        textBox1.Text = "5x5 filter";
                        break;
                    case 3:
                        textBox1.Text = "7x7 filter";
                        break;
                    case 4:
                        textBox1.Text = "9x9 filter";
                        break;
                    case 5:
                        textBox1.Text = "11x11 filter";
                        break;
                    case 6:
                        textBox1.Text = "13x13 filter";
                        break;
                }
            }
            if(comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = trackBar1.Value.ToString();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                double b = 0.2 + trackBar1.Value * 0.2;
                textBox1.Text = b.ToString();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                double b = trackBar1.Value * 90;
                textBox1.Text = b.ToString() + " Degrees";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (init == true)
            {
                using (var form = new Form5())
                {
                    form.ShowDialog();
                    if (form.result == 2)
                    {
                        if (first.Checked == true)
                            original.Image = temporary;
                        else
                            converted.Image = temporary0;
                    }
                    else
                    {
                        if (first.Checked == true)
                            temporary = original.Image;
                        else
                            temporary0 = converted.Image;
                    }
                }
            }
            //init = true;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        trackBar1.Maximum = 6;
                        textBox1.Text = "100%";
                        trackBar1.Value = 3;
                        break;
                    }
                case 1:
                    {
                        trackBar1.Maximum = 30;
                        textBox1.Text = "100%";
                        trackBar1.Value = 10;
                        break;
                    }
                case 2:
                    {
                        trackBar1.Maximum = 6;
                        textBox1.Text = "Original";
                        trackBar1.Value = 0;
                        break;
                    }
                case 3:
                    {
                        trackBar1.Maximum = 255;
                        textBox1.Text = "0";
                        trackBar1.Value = 0;
                        break;
                    }
                case 4:
                    {
                        trackBar1.Maximum = 24;
                        textBox1.Text = "0.2";
                        trackBar1.Value = 0;
                        break;
                    }
                case 5:
                    {
                        trackBar1.Maximum = 3;
                        textBox1.Text = "0 Degree";
                        trackBar1.Value = 0;
                        break;
                    }
                case 6:
                    {
                        try
                        {
                            if (first.Checked == true)
                            {
                                using (var formx = new Form7((Bitmap)original.Image))
                                {
                                    formx.ShowDialog(this);
                                    try
                                    {
                                        if (formx.result != null)
                                            original.Image = formx.result;
                                    }
                                    catch (System.NullReferenceException)
                                    {
                                        MessageBox.Show("Please choose your image first", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                using (var formx = new Form7((Bitmap)converted.Image))
                                {
                                    formx.ShowDialog(this);
                                    try
                                    {
                                        if (formx.result != null)
                                            converted.Image = formx.result;
                                    }
                                    catch (System.NullReferenceException)
                                    {
                                        MessageBox.Show("Please choose your image first", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        catch (System.NullReferenceException)
                        {
                            MessageBox.Show("Please choose your image first", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
            }
            first.Visible = true;
            second.Visible = true;         
        }

        public static Bitmap AdjustBrightness(Bitmap Image, int Value)
        {
            System.Drawing.Bitmap TempBitmap = Image;
            float FinalValue = (float)Value / 255.0f;
            System.Drawing.Bitmap NewBitmap = new System.Drawing.Bitmap(TempBitmap.Width, TempBitmap.Height);
            System.Drawing.Graphics NewGraphics = System.Drawing.Graphics.FromImage(NewBitmap);
            float[][] FloatColorMatrix ={
                      new float[] {1, 0, 0, 0, 0},
                      new float[] {0, 1, 0, 0, 0},
                      new float[] {0, 0, 1, 0, 0},
                      new float[] {0, 0, 0, 1, 0},
                      new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                 };

            System.Drawing.Imaging.ColorMatrix NewColorMatrix = new System.Drawing.Imaging.ColorMatrix(FloatColorMatrix);
            System.Drawing.Imaging.ImageAttributes Attributes = new System.Drawing.Imaging.ImageAttributes();
            Attributes.SetColorMatrix(NewColorMatrix);
            NewGraphics.DrawImage(TempBitmap, new System.Drawing.Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, System.Drawing.GraphicsUnit.Pixel, Attributes);
            Attributes.Dispose();
            NewGraphics.Dispose();
            return NewBitmap;
        }

        public Bitmap MedianFilter(Bitmap sourceBitmap,
                                            int matrixSize,
                                            int bias = 0,
                                    bool grayscale = false)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);


            byte[] pixelBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];


            byte[] resultBuffer = new byte[sourceData.Stride *
                                           sourceData.Height];


            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                                       pixelBuffer.Length);


            sourceBitmap.UnlockBits(sourceData);


            if (grayscale == true)
            {
                float rgb = 0;


                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;


                    pixelBuffer[k] = (byte)rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }


            int filterOffset = (matrixSize - 1) / 2;
            int calcOffset = 0;


            int byteOffset = 0;

            List<int> neighbourPixels = new List<int>();
            byte[] middlePixel;


            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;


                    neighbourPixels.Clear();


                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {


                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                (filterY * sourceData.Stride);


                            neighbourPixels.Add(BitConverter.ToInt32(
                                             pixelBuffer, calcOffset));
                        }
                    }


                    neighbourPixels.Sort();

                    middlePixel = BitConverter.GetBytes(
                                       neighbourPixels[filterOffset]);


                    resultBuffer[byteOffset] = middlePixel[0];
                    resultBuffer[byteOffset + 1] = middlePixel[1];
                    resultBuffer[byteOffset + 2] = middlePixel[2];
                    resultBuffer[byteOffset + 3] = middlePixel[3];
                }
            }


            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                                             sourceBitmap.Height);


            BitmapData resultData =
                       resultBitmap.LockBits(new Rectangle(0, 0,
                       resultBitmap.Width, resultBitmap.Height),
                       ImageLockMode.WriteOnly,
                       PixelFormat.Format32bppArgb);


            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                                       resultBuffer.Length);


            resultBitmap.UnlockBits(resultData);


            return resultBitmap;
        }

        private Bitmap changecontrast (Bitmap img, int value)
        {
            BitmapData sourceData = img.LockBits(new Rectangle(0, 0,
                                img.Width, img.Height),
                                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);


            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];


            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);


            img.UnlockBits(sourceData);


            double contrastLevel = Math.Pow((50 + value) / 100.0, 2);


            double blue = 0;
            double green = 0;
            double red = 0;


            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                blue = ((((pixelBuffer[k] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0;


                green = ((((pixelBuffer[k + 1] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0;


                red = ((((pixelBuffer[k + 2] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0;


                blue = (blue > 255) ? 255 : (blue < 0) ? 0 : blue;


                green = (green > 255) ? 255 : (green < 0) ? 0 : green;


                red = (red > 255) ? 255 : (red < 0) ? 0 : red;


                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }


            Bitmap resultBitmap = new Bitmap(img.Width, img.Height);


            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);


            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);


            return resultBitmap; 
        }

        private byte[] CreateGammaArray(double color)
        {
            byte[] gammaArray = new byte[256];
            for (int i = 0; i < 256; ++i)
            {
                gammaArray[i] = (byte)Math.Min(255,
        (int)((255.0 * Math.Pow(i / 255.0, 1.0 / color)) + 0.5));
            }
            return gammaArray;
        }

        public Bitmap SetGamma(Bitmap _currentBitmap ,double value)
        {
            Bitmap temp = (Bitmap)_currentBitmap;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            byte[] redGamma = CreateGammaArray(value);
            byte[] greenGamma = CreateGammaArray(value);
            byte[] blueGamma = CreateGammaArray(value);
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j, Color.FromArgb(redGamma[c.R],
                       greenGamma[c.G], blueGamma[c.B]));
                }
            }
            return (Bitmap)bmap.Clone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (first.Checked == true)
                {
                    try
                    {
                        original.Image = changecontrast((Bitmap)temporary, trackBar1.Value * 5);
                    }
                    catch (System.NullReferenceException)
                    {
                        MessageBox.Show("Please load an image", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        converted.Image = changecontrast((Bitmap)temporary0, trackBar1.Value * 5);
                    }
                    catch (System.NullReferenceException)
                    {
                        MessageBox.Show("Please load an image", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    if (first.Checked == true)
                    {
                        //temporary = original.Image;
                        switch (trackBar1.Value)
                        {
                            case 0:
                                u = resizeImage(new Bitmap(temporary), new Size(new Bitmap(temporary).Width / 4, mybm.Height / 4));
                                break;
                            case 1:
                                u = resizeImage(new Bitmap(temporary), new Size(new Bitmap(temporary).Width / 2, mybm.Height / 2));
                                break;
                            case 2:
                                u = resizeImage(new Bitmap(temporary), new Size(new Bitmap(temporary).Width * 3 / 4, mybm.Height * 3 / 4));
                                break;
                            case 3:
                                u = resizeImage(new Bitmap(temporary), new Size(new Bitmap(temporary).Width, mybm.Height));
                                break;
                            case 4:
                                u = resizeImage(new Bitmap(temporary), new Size(new Bitmap(temporary).Width * 3 / 2, mybm.Height * 3 / 2));
                                break;
                            case 5:
                                u = resizeImage(new Bitmap(temporary), new Size(new Bitmap(temporary).Width * 2, mybm.Height * 2));
                                break;
                            case 6:
                                u = resizeImage(new Bitmap(temporary), new Size(new Bitmap(temporary).Width * 4, mybm.Height * 4));
                                break;                    
                        }
                        original.Image = u;
                    }
                    else
                    {
                        //temporary0 = converted.Image;
                        switch (trackBar1.Value)
                        {
                            case 0:
                                u = resizeImage(new Bitmap(temporary0), new Size(new Bitmap(temporary0).Width / 4, mybm.Height / 4));
                                break;
                            case 1:
                                u = resizeImage(new Bitmap(temporary0), new Size(new Bitmap(temporary0).Width / 2, mybm.Height / 2));
                                break;
                            case 2:
                                u = resizeImage(new Bitmap(temporary0), new Size(new Bitmap(temporary0).Width * 3 / 4, mybm.Height * 3 / 4));
                                break;
                            case 3:
                                u = resizeImage(new Bitmap(temporary0), new Size(new Bitmap(temporary0).Width, mybm.Height));
                                break;
                            case 4:
                                u = resizeImage(new Bitmap(temporary0), new Size(new Bitmap(temporary0).Width * 3 / 2, mybm.Height * 3 / 2));
                                break;
                            case 5:
                                u = resizeImage(new Bitmap(temporary0), new Size(new Bitmap(temporary0).Width * 2, mybm.Height * 2));
                                break;
                            case 6:
                                u = resizeImage(new Bitmap(temporary0), new Size(new Bitmap(temporary0).Width * 4, mybm.Height * 4));
                                break;            
                        }
                        converted.Image = u;
                    }
                }
                catch(System.NullReferenceException)
                {
                    MessageBox.Show("Please load an image", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(comboBox1.SelectedIndex == 2)
            {
                try
                {
                    if(first.Checked == true)
                    {
                        original.Image = MedianFilter((Bitmap) temporary, (trackBar1.Value+1)*2+1, 0, false);
                    }
                    else
                    {
                        converted.Image = MedianFilter((Bitmap) temporary0, (trackBar1.Value + 1) * 2 + 1, 0, false);
                    }
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Please load an image", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(comboBox1.SelectedIndex == 3)
            {
                try
                {
                    if (first.Checked == true)
                        original.Image = AdjustBrightness((Bitmap)temporary, trackBar1.Value);
                    else
                        converted.Image = AdjustBrightness((Bitmap)temporary0, trackBar1.Value);
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Please load an image", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                try
                {
                    if (first.Checked == true)
                        original.Image = SetGamma((Bitmap)temporary, 0.2 + trackBar1.Value * 0.2);
                    else
                        converted.Image = SetGamma((Bitmap)temporary0, 0.2 + trackBar1.Value * 0.2);
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Please load an image", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBox1.SelectedIndex == 5)
            {
                try
                {
                    if (first.Checked == true)
                    {
                        switch (trackBar1.Value)
                        {
                            case 0:
                                original.Image = temporary;
                                break;
                            case 1:
                                original.Image = (Bitmap)temporary.Clone();
                                original.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                break;
                            case 2:
                                original.Image = (Bitmap)temporary.Clone();
                                original.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                break;
                            case 3:
                                original.Image = (Bitmap)temporary.Clone();
                                original.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                break;
                        }
                    }
                    else
                    {
                        switch (trackBar1.Value)
                        {
                            case 0:
                                converted.Image = temporary0;
                                break;
                            case 1:
                                converted.Image = (Bitmap) temporary0.Clone();
                                converted.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                break;
                            case 2:
                                converted.Image = (Bitmap)temporary0.Clone();
                                converted.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                break;
                            case 3:
                                converted.Image = (Bitmap)temporary0.Clone();
                                converted.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                break;
                        }
                    }
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Please load an image", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(comboBox1.SelectedIndex==6)
            {
                try
                {
                    if (first.Checked == true)
                    {
                        using (var formx = new Form7((Bitmap)original.Image))
                        {
                            formx.ShowDialog(this);
                            try
                            {
                                if (formx.result != null)
                                    original.Image = formx.result;
                            }
                            catch (System.NullReferenceException)
                            {
                                MessageBox.Show("Please choose your image first", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        using (var formx = new Form7((Bitmap)converted.Image))
                        {
                            formx.ShowDialog(this);
                            try
                            {
                                if (formx.result != null)
                                    converted.Image = formx.result;
                            }
                            catch (System.NullReferenceException)
                            {
                                MessageBox.Show("Please choose your image first", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Please choose your image first", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            init = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (checkBox1.Visible == false)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

            checkBox1.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Visible = false;
            checkBox2.Checked = false;
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    original.Image.Save(dialog.FileName + ".jpg", ImageFormat.Jpeg);
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please make change to your image first", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Visible = false;
            checkBox2.Checked = false;
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    converted.Image.Save(dialog.FileName + ".jpg", ImageFormat.Jpeg);
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please convert an image first", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void first_CheckedChanged(object sender, EventArgs e)
        {
            if(init==true)
            {
                init = false;
                if(first.Checked==true)
                {
                    if(temporary0!=converted.Image)
                    {
                        using(var formx = new Form6())
                        {
                            formx.ShowDialog(this);
                            if (formx.result == 2)
                                converted.Image = temporary0;
                            else
                            {
                                try
                                {
                                    SaveFileDialog dialog = new SaveFileDialog();
                                    if (dialog.ShowDialog() == DialogResult.OK)
                                    {
                                        converted.Image.Save(dialog.FileName + ".jpg", ImageFormat.Jpeg);
                                    }
                                }
                                catch (System.NullReferenceException)
                                {
                                    MessageBox.Show("Please make change to your image first", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if(temporary!=original.Image)
                    {
                        using (var formx = new Form6())
                        {
                            formx.ShowDialog(this);
                            if (formx.result == 2)
                                original.Image = temporary;
                            else
                            {
                                try
                                {
                                    SaveFileDialog dialog = new SaveFileDialog();
                                    if (dialog.ShowDialog() == DialogResult.OK)
                                    {
                                        original.Image.Save(dialog.FileName + ".jpg", ImageFormat.Jpeg);
                                    }
                                }
                                catch (System.NullReferenceException)
                                {
                                    MessageBox.Show("Please make change to your image first", "No Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void second_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void original_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void original_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Rev(object sender, EventArgs e)
        {

        }

        private void original_Click(object sender, EventArgs e)
        {
            
        }
    }
}

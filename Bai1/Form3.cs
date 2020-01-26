using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                int s = listBox1.SelectedItems.Count;
                while (s != 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    s--;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count != 0)
            {
                int s = listBox2.SelectedItems.Count;
                while (s != 0)
                {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                    s--;
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox2.Items.Count!=0)
            {
                int s = listBox2.Items.Count-1;
                while(s>=0)
                {
                    listBox2.Items.Remove(listBox2.Items[s]);
                    s--;
                }
                int x = listBox1.Items.Count - 1;
                while(x>=0)
                {
                    listBox1.Items.Remove(listBox1.Items[x]);
                    x--;
                }
                listBox1.Items.Add("Computer Structures");
                listBox1.Items.Add("Computer Networks");
                listBox1.Items.Add("Communicational Systems");
                listBox1.Items.Add("Digital Signal Processing");
                listBox1.Items.Add("Matlab");
                listBox1.Items.Add("VLSI");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex=0;
            maskedTextBox1.Text = "(084) ___-___-____";
            dateTimePicker1.Value = DateTime.Today;
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            int y = 0;
            while(y<checkedListBox1.Items.Count)
            {
                checkedListBox1.SetItemChecked(y, false);
                y++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_2(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"E:\";
            path = path + comboBox1.Text.ToString() + ".txt";
            if (!File.Exists(path))
            {
                var myFile = File.Create(path);
                myFile.Close();
            }
            File.WriteAllText(path, String.Empty);
            TextWriter tw = new StreamWriter(path, true);
            string gender;
            if(radioButton1.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            tw.WriteLine("ID number: " + comboBox1.Text.ToString()+"             Gender: "+gender);
            string space="";
            for (int i = 0; i < 18 - textBox2.Text.Length; i++) 
                space = space + " ";
            tw.WriteLine("Name: " + textBox2.Text.ToString() + space + "   Phone number: " + maskedTextBox1.Text.ToString());
            tw.Write("Date of Birth: ");
            tw.Write(dateTimePicker1.Value.ToShortDateString());
            tw.WriteLine("   Email address: " + textBox1.Text.ToString());
            tw.WriteLine("Foreign languages: ");
            for (int i = 0; i <= checkedListBox1.CheckedItems.Count-1; i++)
                tw.WriteLine("    " + checkedListBox1.CheckedItems[i].ToString());
            tw.WriteLine("List of teaching subjects:");
            for (int i = 0; i <= listBox2.Items.Count - 1; i++)
                tw.WriteLine("    " + listBox2.Items[i].ToString());
            tw.Close(); 
        }
    }
}

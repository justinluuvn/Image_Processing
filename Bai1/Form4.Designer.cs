namespace Bai1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Load = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.Scale = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.RadioButton();
            this.second = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.original = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.converted = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.original)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.converted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(12, 347);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 2;
            this.Load.Text = "Load Image";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(398, 100);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 23);
            this.Convert.TabIndex = 3;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Scale
            // 
            this.Scale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Scale.FormattingEnabled = true;
            this.Scale.Items.AddRange(new object[] {
            "Gray",
            "Red",
            "Green",
            "Blue",
            "Invert"});
            this.Scale.Location = new System.Drawing.Point(398, 162);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(75, 21);
            this.Scale.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scale";
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Checked = true;
            this.first.Location = new System.Drawing.Point(682, 350);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(60, 17);
            this.first.TabIndex = 18;
            this.first.TabStop = true;
            this.first.Text = "Original";
            this.first.UseVisualStyleBackColor = true;
            this.first.Visible = false;
            this.first.CheckedChanged += new System.EventHandler(this.first_CheckedChanged);
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Location = new System.Drawing.Point(775, 350);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(74, 17);
            this.second.TabIndex = 19;
            this.second.Text = "Converted";
            this.second.UseVisualStyleBackColor = true;
            this.second.Visible = false;
            this.second.CheckedChanged += new System.EventHandler(this.second_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.original);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 306);
            this.panel1.TabIndex = 22;
            // 
            // original
            // 
            this.original.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.original.Location = new System.Drawing.Point(1, 3);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(300, 300);
            this.original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.original.TabIndex = 0;
            this.original.TabStop = false;
            this.original.Click += new System.EventHandler(this.original_Click);
            this.original.MouseClick += new System.Windows.Forms.MouseEventHandler(this.original_MouseClick);
            this.original.MouseMove += new System.Windows.Forms.MouseEventHandler(this.original_MouseMove);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.converted);
            this.panel2.Location = new System.Drawing.Point(542, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 306);
            this.panel2.TabIndex = 23;
            // 
            // converted
            // 
            this.converted.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.converted.Location = new System.Drawing.Point(3, 3);
            this.converted.Name = "converted";
            this.converted.Size = new System.Drawing.Size(300, 300);
            this.converted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.converted.TabIndex = 0;
            this.converted.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Resize",
            "Contrast",
            "Noise Filter",
            "Brightness",
            "Gamma",
            "Rotate",
            "Crop"});
            this.comboBox1.Location = new System.Drawing.Point(296, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(511, 346);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(162, 45);
            this.trackBar1.TabIndex = 26;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "0%";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(398, 216);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 29;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(398, 255);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Original";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(398, 287);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "Converted";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 392);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scale);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Load);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Image Manipulation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.original)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.converted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.ComboBox Scale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton first;
        private System.Windows.Forms.RadioButton second;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox original;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox converted;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
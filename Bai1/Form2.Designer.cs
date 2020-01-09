namespace Bai1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.Enable = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Enable
            // 
            this.Enable.Location = new System.Drawing.Point(19, 44);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(75, 23);
            this.Enable.TabIndex = 0;
            this.Enable.Text = "Enable";
            this.Enable.UseVisualStyleBackColor = true;
            this.Enable.Click += new System.EventHandler(this.Enable_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(19, 116);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // timer
            // 
            this.timer.Location = new System.Drawing.Point(160, 83);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(55, 20);
            this.timer.TabIndex = 2;
            this.timer.Text = "00000000";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 189);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Enable);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enable;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox timer;
        private System.Windows.Forms.Timer timer1;
    }
}
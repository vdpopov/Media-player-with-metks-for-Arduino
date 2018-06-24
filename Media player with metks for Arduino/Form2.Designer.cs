namespace MP3_Player
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.MaximumSize = new System.Drawing.Size(1920, 0);
            this.trackBar1.MinimumSize = new System.Drawing.Size(334, 0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(613, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.MouseCaptureChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(140, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(613, 203);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(398, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назначить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Пуск 1",
            "Пуск 2",
            "Пуск 3",
            "Пуск 4",
            "Пуск 5",
            "Пуск 6",
            "Пуск 7",
            "Пуск 8"});
            this.comboBox1.Location = new System.Drawing.Point(212, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(404, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Применить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(120, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Воспроизвести с метками";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Location = new System.Drawing.Point(212, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Воспроизвести без меток";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Location = new System.Drawing.Point(307, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "Пауза";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.Location = new System.Drawing.Point(404, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 40);
            this.button6.TabIndex = 9;
            this.button6.Text = "Стоп";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Left;
            this.button7.Location = new System.Drawing.Point(212, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 49);
            this.button7.TabIndex = 10;
            this.button7.Text = "Удалить метку";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Left;
            this.button8.Location = new System.Drawing.Point(110, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 49);
            this.button8.TabIndex = 11;
            this.button8.Text = "Сохранить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.Location = new System.Drawing.Point(307, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 49);
            this.button9.TabIndex = 12;
            this.button9.Text = "Восстановить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(375, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 120, 0);
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Метки не применены!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(120, 0, 120, 0);
            this.panel1.Size = new System.Drawing.Size(613, 40);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(140, 5, 140, 5);
            this.panel2.Size = new System.Drawing.Size(613, 32);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 117);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(110, 0, 110, 0);
            this.panel3.Size = new System.Drawing.Size(613, 49);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 29);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(613, 203);
            this.panel5.TabIndex = 20;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gainsboro;
            this.button10.Location = new System.Drawing.Point(174, 406);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(17, 16);
            this.button10.TabIndex = 21;
            this.button10.Tag = "1";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.Location = new System.Drawing.Point(206, 406);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(17, 16);
            this.button11.TabIndex = 22;
            this.button11.Tag = "2";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button12.Location = new System.Drawing.Point(237, 406);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(17, 16);
            this.button12.TabIndex = 23;
            this.button12.Tag = "3";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button13.Location = new System.Drawing.Point(269, 406);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(17, 16);
            this.button13.TabIndex = 24;
            this.button13.Tag = "4";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button14.Location = new System.Drawing.Point(299, 406);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(17, 16);
            this.button14.TabIndex = 25;
            this.button14.Tag = "5";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button15.Location = new System.Drawing.Point(333, 406);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(17, 16);
            this.button15.TabIndex = 26;
            this.button15.Tag = "6";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button16.Location = new System.Drawing.Point(366, 406);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(17, 16);
            this.button16.TabIndex = 27;
            this.button16.Tag = "7";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button17.Location = new System.Drawing.Point(399, 406);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(17, 16);
            this.button17.TabIndex = 28;
            this.button17.Tag = "8";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(613, 430);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar1);
            this.MinimumSize = new System.Drawing.Size(428, 441);
            this.Name = "Form2";
            this.Text = "Назначение меток";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Timer timer1;
    }
}
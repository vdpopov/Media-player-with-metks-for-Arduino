using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MP3_Player
{
    
    public partial class Form2 : Form
    {
        bool control_mouse = false;
        public Form2()
        {
            InitializeComponent();
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            label1.Text = "0";
            trackBar1.Maximum = Var1.duration * 10;

            Var1.start = false;
            call.form = this;

            listView1.View = View.Details;

            listView1.Columns.Add("Time", 100);
            listView1.Columns.Add("Port", 100);
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (Var1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Form2 fc = Application.OpenForms["Form2"] != null ? (Form2)Application.OpenForms["Form2"] : null;
                if (fc != null)
                {
                    if(Var1.start == false)
                    {
                        led_off("0");
                        led_off("1");
                        led_off("2");
                        led_off("3");
                        led_off("4");
                        led_off("5");
                        led_off("6");
                        led_off("7");
                        timer1.Enabled = false;
                    }


                }
                

            }
            

        }


        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = ((decimal)trackBar1.Value / 10).ToString();
                Var1.time = trackBar1.Value / 10;
                apply.form1.set_time();
            }
            catch (Exception ex){
                MessageBox.Show("Произошла ошибка в изменении значения. " + ex.Message);
            }
            
        }

        public void check()
        {
            
            if (Var1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                
                if(control_mouse == false)
                {
                    label1.Text = (Math.Round(Var1.value, 1)).ToString();
                    trackBar1.Value = (int)Var1.value * 10;
                }
                
            }
            

        }
        public void close()
        {
            
                Close();

        }
        public void led_off(string o)
        {
            var name = "button1" + o;
            if (this.Controls.ContainsKey(name))
            {
                var textBox = this.Controls[name];
                textBox.BackColor = Color.FromName("GrainsBoro");
            }
        }
        public void led(string o)
        {
            timer1.Enabled = true;
            var name = "button1" + o;
            if (this.Controls.ContainsKey(name))
            {
                var textBox = this.Controls[name];
                textBox.BackColor = Color.FromName("Red");
            }
        }
        public void activate()
        {
            
            Activate();
                
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Значение порта пустое!");
            }
            else
            {

            ListViewItem item1 = new ListViewItem(label1.Text, 0);
            item1.SubItems.Add(comboBox1.Text);
            

            listView1.Items.Add(item1);
            label2.Visible = true;
            button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Var1.Counter = listView1;
            apply.form1.apply_data(); //Для синхронизации точек с FORM1
            button3.Enabled = true;
            label2.Visible = false;

        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            
            control_mouse = true;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            
            control_mouse = false;
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            label1.Text = ((decimal)trackBar1.Value / 10).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Var1.start = true;
            actions.form2.start_without();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            actions.form2.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label1.Text = "0";
            Var1.time = 0;
            apply.form1.set_time();

            Var1.start = false;
            actions.form2.start_without();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            actions.form2.stops();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            while (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            label2.Visible = true;
            button3.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "fire files (*.fire)|*.fire";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                using (FileStream fs = File.Create(saveFileDialog1.FileName))
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        string Name = listView1.Items[i].Text;
                        string IDPT = listView1.Items[i].SubItems[1].Text;
                        

                        Encoding temp = Encoding.GetEncoding(1251);

                        string text = "Name=" + Name + "IDPT=" + IDPT;
                        //text = text.Replace(Convert.ToChar(0x0).ToString(), "");
                        Byte[] info = temp.GetBytes(text);
                        fs.Write(info, 0, info.Length);



                    }

                }
            }
        }
        string file = "";
        
        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //   openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "fire files (*.fire)|*.fire";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;


           



            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                file = openFileDialog1.FileName;
                string name1 = System.IO.Path.GetFileNameWithoutExtension(@file);
                string filename = System.IO.Path.GetFileName(@file);
                int dotIndex = filename.IndexOf('.');
                string ext = filename.Substring(dotIndex + 1, filename.Length - dotIndex - 1);

                

                


                try
                {
                    using (FileStream fs = File.Open(openFileDialog1.FileName, FileMode.Open))
                    {

                        file = openFileDialog1.FileName;


                        
                        byte[] b = new byte[sizeof(char) * fs.Length];
                        Encoding temp = Encoding.GetEncoding(1251);
                        while (fs.Read(b, 0, b.Length) > 0)
                        {
                            listView1.View = View.Details;
                            
                            //listView1.Columns.Add("Time", 100);
                            //listView1.Columns.Add("Port", 100);

                            //    MessageBox.Show(temp.GetString(b));
                            var splits = Regex.Split(temp.GetString(b), @"(?:Name=)");
                            //   String[] words = temp.GetString(b).Split(new char[] { 'N' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (string k in splits)
                            {

                                if (!string.IsNullOrEmpty(k))
                                {
                                    //ListViewItem item1 = new ListViewItem("123", 0);
                                    // Place a check mark next to the item.
                                    //  item1.Checked = true;
                                    //item1.SubItems.Add("12345");
                                    // listView1.Items.Add(item1);

                                    var name = k.Remove(k.IndexOf('I'), k.Length - k.IndexOf('I'));
                                    ListViewItem newitem = new ListViewItem(name, 0);
                                    var splits3 = Regex.Split(k, @"(?:IDPT=)");
                                    //var add2 = splits3[1].Remove(splits3[1].IndexOf('N'), splits3[1].Length - splits3[1].IndexOf('N'));


                                    Regex rgx = new Regex("[^а-яА-Я0-9 -]");
                                    var add2 = rgx.Replace(splits3[1], "");
                                    newitem.SubItems.Add(add2);
                                    listView1.Items.Add(newitem);
                                    label2.Visible = true;
                                    button3.Enabled = false;




                                }


                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        
    }
}

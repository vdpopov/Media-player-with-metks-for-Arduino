using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;


namespace MP3_Player
{
    
    public partial class Form1 : Form
    {
        bool start = false;
        bool first = true;
        
        int end = 0;

        List<List<string>> apply_datas = new List<List<string>>();
        private SerialPort portr;
        System.Threading.Timer timer;
        

        public Form1()
        {
            InitializeComponent();
            
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Threading.Timer(new TimerCallback(timer1_Tick), null, 0, 50);
            foreach (string portname in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(portname); //добавить порт в список    
            }

            
            apply.form1 = this;
            actions.form2 = this;
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
           

            //media player control's playstate change event handler
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                label1.Text = axWindowsMediaPlayer1.currentMedia.durationString;
                progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                
                if (first == true)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    first = false;
                    toolStripStatusLabel1.Text = "Стоп";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Воспроизведение";
                    //timer1.Start();
                    timer.Change(0, 50); //enable
                    
                }
                
                
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                
                //timer1.Stop();
                timer.Change(Timeout.Infinite, Timeout.Infinite); //disable
                toolStripStatusLabel1.Text = "Пауза";
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer.Change(Timeout.Infinite, Timeout.Infinite); //disable
                //timer1.Stop();
                progressBar1.Value = 0;
                toolStripStatusLabel1.Text = "Стоп";

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {


                    
                    axWindowsMediaPlayer1.URL = openFileDialog1.FileName; // Play the song  
                    first = true;
                    toolStripStatusLabel1.Text = "Файл загружен";
                    apply_datas.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка с открытием файла. " + ex.Message);
            }
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Form2 f2 = new Form2();
        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                //frm.Show();
                if (label1.Text == "None" || comboBox1.Text == "")
                {
                    MessageBox.Show("Не выбран звуковой файл! Либо не выбран порт!", "Ошибка");
                }
                else
                {
                    Var1.duration = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                    Form2 fc = Application.OpenForms["Form2"] != null ? (Form2)Application.OpenForms["Form2"] : null;
                    if (fc != null)
                    {


                        //f2.Activate();
                        call.form.activate();
                    }
                    else
                    {
                        try
                        {
                            f2.Show();
                        }
                        catch
                        {
                            Form2 f2 = new Form2();
                            f2.Show();
                        }
                            
                        
                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Произошла ошибка с открытием формы. " + ex.Message);
            }

            
            
            
        }

        /*
       private void player_StatusChange(object sender,System.EventArgs e)
       {
           textBox1.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
           progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
       }
       */
        
        public delegate void AddDelegate();

        public void Timer_tck()
        {
            
            //timer 1 tick event handler
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                
                textBox1.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                Var1.value = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                Var1.playState = axWindowsMediaPlayer1.playState;

                Form2 fc = Application.OpenForms["Form2"] != null ? (Form2)Application.OpenForms["Form2"] : null;
                if (fc != null)
                {
                    call.form.check(); //Для синхронизации с FORM2
                }
                double time = Math.Round(axWindowsMediaPlayer1.Ctlcontrols.currentPosition, 1);

                string time_str = time.ToString();
                
                /*
                    call.form.led_off("0");
                    call.form.led_off("1");
                    call.form.led_off("2");
                    call.form.led_off("3");
                    call.form.led_off("4");
                    call.form.led_off("5");
                    call.form.led_off("6");
                    call.form.led_off("7");
                    */
                    foreach (List<string> ss in apply_datas)
                    {
                        
                        
                        
                            if (time_str == ss[0])
                            {
                                if (start == false)
                                {
                                    
                                    //Console.WriteLine("Запуск "+ss[0] + "/ " + ss[1]);
                                    toolStripStatusLabel1.Text = "Запущен в " + axWindowsMediaPlayer1.Ctlcontrols.currentPositionString + " На порту " + ss[1];
                                    start_COM(ss[1]);
                                }

                            }



                            
                            Console.WriteLine("/" + ss[0] + "/ " + ss[1] + "//" + time_str + "//");
                            
                        
                        
                    }
                    
                    
                

                Console.WriteLine(end);
               
            }
        }
        
        
        private void timer1_Tick(object sender)
        {
            try
            {
                Invoke(new AddDelegate(Timer_tck)); //работаем из другого потока
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка invoke " + ex.Message);
            }
               
            
            
           
            
        }
        private void start_COM(object sender)
        {

            
            Regex regex = new Regex(@"[^\d]");
            string message = sender.ToString();
            string port = regex.Replace(message, "");
            int port0 = Convert.ToInt32(port);
            int port1 = port0 - 1;

         
            try
            {
                portr.Write(port1.ToString());
                call.form.led(port1.ToString()); //Для синхронизации с FORM2
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка отправки на порт. " + ex.Message);
            }

            



                Console.WriteLine("Запуск " + port);
                //timer2.Start();
                //protect = false;
                
            
        }
        /*
        private void timer2_Tick(object sender, EventArgs e)
        {

            protect = true;
            timer2.Stop();
        }
        */
        public void apply_data()
        {

            if (Var1.Counter != null)
            {
                apply_datas.Clear();
                for (int i = 0; i < Var1.Counter.Items.Count; i++)
                {
                   // Console.WriteLine(Var1.Counter.Items[i].Text + " / " + Var1.Counter.Items[i].SubItems[1].Text);
                    
                    string one = Var1.Counter.Items[i].Text;
                    string two = Var1.Counter.Items[i].SubItems[1].Text;
                    

                    List<string> temp_list = new List<string> { one, two };

                    
                    apply_datas.Add(temp_list);
                }
            }

            

        }
      
        public void stop() //пауза
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    //timer1.Start();
                    //timer.Change(0, 500); //enable
                    toolStripStatusLabel1.Text = "Воспроизведение";
                    end = 0;
                    Var1.playState = axWindowsMediaPlayer1.playState;


            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                //timer1.Stop();
                //timer.Change(Timeout.Infinite, Timeout.Infinite); //disable
                toolStripStatusLabel1.Text = "Пауза";
                Var1.playState = axWindowsMediaPlayer1.playState;
            }
                
        }

        public void stops()
        {
            
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                //timer1.Stop();
                //timer.Change(Timeout.Infinite, Timeout.Infinite); //disable
                toolStripStatusLabel1.Text = "Стоп";
                end = 0;
                Var1.playState = axWindowsMediaPlayer1.playState;
        }


        public void start_without()
        {
        //    end = 0;
            start = Var1.start;
        //    axWindowsMediaPlayer1.Ctlcontrols.stop();
        //    //timer1.Stop();
        //    timer.Change(Timeout.Infinite, Timeout.Infinite); //disable
            //
            end = 1;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            //timer1.Start();
            //timer.Change(0, 500); //enable
            toolStripStatusLabel1.Text = "Воспроизведение";
            Var1.playState = axWindowsMediaPlayer1.playState;
        }

        public void set_time()
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Var1.time + 0.05;
        }
        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            textBox1.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            //progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex]; // Play the song  
            //axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            apply_datas.Clear();
            toolStripStatusLabel1.Text = "Метки сброшены";

            call.form.close(); //Для синхронизации с FORM2

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            try
            {
                portr = new SerialPort(comboBox1.Text);
                portr.Open();
                Console.WriteLine(comboBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не могу открыть порт. " + ex.Message);
            }



        }
        

        
    }
}

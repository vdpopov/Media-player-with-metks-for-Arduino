using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace MP3_Player
{
    
    class actions
    {
        public static Form1 form2;
    }
    class apply
    {
        public static Form1 form1;
    }
    class call
    {
        public static Form2 form;
    }
    public static class Var1
    {
        public static int duration { get; set; }
        public static double value { get; set; }
        public static WMPLib.WMPPlayState playState { get; set; }
        public static ListView Counter { get; set; }
        public static int time { get; set; }
        public static bool start { get; set; }


    }
    
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

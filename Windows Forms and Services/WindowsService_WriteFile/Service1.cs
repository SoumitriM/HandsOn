using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace WindowsService_WriteFile
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer();
        DateTime setTime = new DateTime(2021,03,03);
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //WriteToFile("Custom activity started at " + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 10000; //number in milisecinds  
            timer.Enabled = true;
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            if(Convert.ToInt32(timeNow.Subtract(setTime).Days)> 0)
            {
                WriteToFile("Custom activity started at " + DateTime.Now);
                timer.Enabled = false;
            }
            
        }
        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }

        protected override void OnStop()
        {
        }
    }
}

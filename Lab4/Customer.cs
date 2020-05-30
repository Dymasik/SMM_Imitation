using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Customer
    {
        private string message;

        const string path = @"C:\Users\Lenovo\Desktop\SmmLogs\messages\logs.csv";
        const string finalPath = @"C:\Users\Lenovo\Desktop\SmmLogs\finalMessages\finalLog.csv";

        static object locker = new object();
        
        public string Name { get; set; }
        public bool IsRejected { get; set; }


        public Dictionary<string, long> Timings { get; set; }
        public Stopwatch Stopwatch { get; }

        static Customer()
        {
            using (File.Create(path)) { }
            using (File.Create(finalPath)) { }
        }

        public Customer(string name)
        {
            Timings = new Dictionary<string, long>();
            Stopwatch = new Stopwatch();
            Name = name;
            IsRejected = false;
            message = $"{name}, ";
        }

        public void CreateMessage(string mes)
        {
            message += $"{mes}, ";
        }

        public void WriteToFile(string message)
        {
            lock (locker)
            {
                using(StreamWriter file = File.AppendText(path))
                {
                    var mes = $"{Name}, {message}";
                    file.WriteLine(mes);
                }
            }
        }

        public void WriteFinalMessage()
        {
            using (StreamWriter file = File.AppendText(finalPath))
            {
                message = message.Substring(0, message.Length - 2);
                file.WriteLine(message);
            }
        }
    }
}

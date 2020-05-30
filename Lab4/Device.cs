using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4
{
    public delegate void NextAction(Customer customer);

    public class Device : ControllerBase
    {
        private bool isBusy;


        private CustomQueue queue;

        private  double value;

        private WorkMode mode;

        public double DeviceLoading { get; private set; }

        public NextAction NextAction;

        public string Name { get; set; }

        public Device(string name, double value, CustomQueue queue, NextAction action, WorkMode mode) 
        {
            DeviceLoading = 0;
            isBusy = false;
            Name = name;
            NextAction = action;
            this.value = value;
            resetEvent = new AutoResetEvent(true);
            this.queue = queue;
            this.mode = mode;
        }

        private void Update(CancellationToken stoppingToken)
        {
            Thread.Sleep(Settings.StartMetricDelay);
            double loaded = 0;
            double time = 1;
            while (!stoppingToken.IsCancellationRequested)
            {
                Thread.Sleep(Settings.TimeMeasure);
                if (isBusy)
                {
                    loaded++;
                    DeviceLoading = loaded / time;
                }
                else
                {
                    DeviceLoading = loaded / time;
                }
                time++;
            }
        }

        public int Process() 
        {
            int time = 0;
            if(mode == WorkMode.Intensity)
            {
                time = (int)((1.0 / value) * Settings.TimeMeasure);
            }
            else if(mode == WorkMode.Time)
            {
                time = (int)value;
            }

            return time;
        }

        public void ExecuteAsync(CancellationToken stoppingToken)
        {
            new Thread(() => Update(stoppingToken)).Start();

            while (!stoppingToken.IsCancellationRequested)
            {
                var customer = queue.FirstCustomerOfQueue();
                isBusy = true;

                customer.CreateMessage($"Processed by {Name}");
                customer.WriteToFile($"Processed by, {Name}");

                int time = Process();
                Thread.Sleep(time);

                NextAction(customer);
                isBusy = false;
            }
        }

    }
}

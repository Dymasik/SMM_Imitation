using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Lab4
{
    public class CustomQueue : ControllerBase
    {
        private bool _reachedLimit;
        Queue<Customer> customersList;

        private bool HasLimit { get; }
        private int limit;

        public  double LengthOfQueuePerTime { get; private set; }
        public  double AverageLentgth { get; private set; }

        public int AllServed { get; private set; }
        public string Name { get; set; }

        public int Count => customersList.Count;

        static string path = @"C:\Users\Lenovo\Desktop\SmmLogs\QueueValues";

        static CustomQueue()
        {
            DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

        public CustomQueue(string name, CancellationToken token)
        {
            AllServed = 0;
            AverageLentgth = 0;
            Name = name;
            _reachedLimit = false;
            HasLimit = false;
            customersList = new Queue<Customer>();
            resetEvent = new System.Threading.AutoResetEvent(false);

            new Thread(() => UpdateAvrLength(token)).Start();
        }

        public CustomQueue(string name, int limit, CancellationToken token)
        {
            AllServed = 0;
            AverageLentgth = 0;
            Name = name;
            _reachedLimit = false;
            this.limit = limit;
            HasLimit = true;
            customersList = new Queue<Customer>();
            resetEvent = new System.Threading.AutoResetEvent(false);

            new Thread(() => UpdateAvrLength(token)).Start();
        }

        private void UpdateAvrLength(CancellationToken token)
        {
            Thread.Sleep(Settings.StartMetricDelay);
            double time = 1;
            LengthOfQueuePerTime = 0;

            while (!token.IsCancellationRequested)
            {
                Thread.Sleep(Settings.TimeMeasure);

                LengthOfQueuePerTime += customersList.Count;
                AverageLentgth = LengthOfQueuePerTime / time;
                var mes = AverageLentgth.ToString();
                using (StreamWriter file = File.AppendText($"{path}\\{Name}.txt"))
                {
                    file.WriteLine(mes);
                }
                time++;
            }

        }

        public Customer FirstCustomerOfQueue()
        {

            if (customersList.Count <= 0)
            {
                resetEvent.Reset();
                resetEvent.WaitOne();
            }

            if (_reachedLimit)
            {
                _reachedLimit = false;
                resetEvent.Set();
            }
            var customer = customersList.Dequeue();
            AllServed++;

            customer.Stopwatch.Stop();
            customer.Timings.Add(Name, (customer.Stopwatch.ElapsedMilliseconds / Settings.TimeMeasure));

            customer.CreateMessage($"Dequeue in queue {Name}");
            customer.WriteToFile($"Dequeue in queue, {Name}");
            return customer;
        }
        public void MoveToQueue(Customer customer)
        {
            if (HasLimit)
            {
                if (customersList.Count >= limit)
                {
                    _reachedLimit = true;
                    resetEvent.Reset();
                    resetEvent.WaitOne();
                }
            }

            customer.CreateMessage($"Enqueue in queue {Name}");
            customer.WriteToFile($"Enqueue in queue, {Name}");

            customer.Stopwatch.Start();

            customersList.Enqueue(customer);
            if (customersList.Count == 1)
            {
                resetEvent.Set();
            }
        }
    }
}

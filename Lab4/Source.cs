using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Lab4
{
    public class Source
    {
        private double customerCount;
        private double queue1Length;
        private double queue2Length;

        private CustomQueue queue1;
        private CustomQueue queue2;

        private Device device11;
        private Device device12;
        private Device device21;
        private Device device22;

        private List<Customer> servedCustomers;

        private CustomQueue helpQueue11;
        private CustomQueue helpQueue12;
        private Device helpDevice11;
        private Device helpDevice12;

        private object loker = new object();

        private string queue1Name = "Queue1";
        private string queue2Name = "Queue2";

        public Source()
        {
            customerCount = 0;
            queue1Length = 0;
            queue2Length = 0;
        }


        public void ExecuteAsync(CancellationToken stoppingToken)
        {
            void Init()
            {
                servedCustomers = new List<Customer>();

                queue1 = new CustomQueue(queue1Name, stoppingToken);
                queue2 = new CustomQueue(queue2Name, Settings.QUEUE_2_LIMIT, stoppingToken);

                helpQueue11 = new CustomQueue("HelpQueue1", 1, stoppingToken);
                helpQueue12 = new CustomQueue("HelpQueue2", 1, stoppingToken);

                device11 = new Device("Device1_1", Settings.DEVICE_1_MU, queue1, x => helpQueue11.MoveToQueue(x), WorkMode.Intensity);
                device12 = new Device("Device1_2", Settings.DEVICE_1_MU, queue1, x => helpQueue12.MoveToQueue(x), WorkMode.Intensity);
                device21 = new Device("Device2_1", Settings.DEVICE_2_MU, queue2, x => EndWork(x), WorkMode.Intensity);
                device22 = new Device("Device2_2", Settings.DEVICE_2_MU, queue2, x => EndWork(x), WorkMode.Intensity);

                helpDevice11 = new Device("HelpDevice", 0, helpQueue11, x => queue2.MoveToQueue(x), WorkMode.Time);
                helpDevice12 = new Device("HelpDevice", 0, helpQueue12, x => queue2.MoveToQueue(x), WorkMode.Time);
            }

            Init();

            var thread1 = new Thread(() => device11.ExecuteAsync(stoppingToken));
            thread1.Name = "Device11";

            var thread2 = new Thread(() => device12.ExecuteAsync(stoppingToken));
            thread2.Name = "Device12";

            var thread3 = new Thread(() => device21.ExecuteAsync(stoppingToken));
            thread3.Name = "Device21";

            var thread4 = new Thread(() => device22.ExecuteAsync(stoppingToken));
            thread4.Name = "Device22";

            var thread5 = new Thread(() => helpDevice11.ExecuteAsync(stoppingToken));
            thread5.Name = "HelpDevice11";
            var thread6 = new Thread(() => helpDevice12.ExecuteAsync(stoppingToken));
            thread6.Name = "HelpDevice12";

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();

            int delayTime = Settings.Delay;
            int count = 0;
            while (!stoppingToken.IsCancellationRequested)
            {
                Customer customer = new Customer($"Customer {count}");
                customerCount++;

                customer.WriteToFile("Has been created");
                customer.CreateMessage("Has been created");

                queue1.MoveToQueue(customer);

                Thread.Sleep(delayTime);
                count++;
            }
        }

        private void EndWork(Customer customer)
        {
            servedCustomers.Add(customer);
            customer.WriteToFile("End Work");
            customer.CreateMessage("End Work");

            lock (loker)
            {
                customer.WriteFinalMessage();
            }
        }

        public InformationDTO GetInformation()
        {
            double rejectionProcent = servedCustomers.Where(x => x.IsRejected).Count() / customerCount;
            queue1Length = queue1.AverageLentgth;
            queue2Length = queue2.AverageLentgth;

            var queue1AvrTimeAsReal = servedCustomers.Where(x => !x.IsRejected).Select(x => x.Timings[queue1Name]).Average();
            var queue2AvrTimeAsReal = servedCustomers.Where(x => !x.IsRejected).Select(x => x.Timings[queue2Name]).Average();

            var queue1AvrTime = queue1.LengthOfQueuePerTime / queue1.AllServed;
            var queue2AvrTime = queue2.LengthOfQueuePerTime / queue2.AllServed;

            var device11Loading = device11.DeviceLoading;
            var device12Loading = device12.DeviceLoading;
            var device21Loading = device21.DeviceLoading;
            var device22Loading = device22.DeviceLoading;

            return new InformationDTO()
            {
                RejectionProcent = rejectionProcent,
                Queue1AvrLength = queue1Length,
                Queue2AvrLength = queue2Length,
                Queue1AvrTime = queue1AvrTime,
                Queue2AvrTime = queue2AvrTime,
                Queue1AvrTimeAsReal = queue1AvrTimeAsReal,
                Queue2AvrTimeAsReal = queue2AvrTimeAsReal,
                Device11Loading = device11Loading,
                Device12Loading = device12Loading,
                Device21Loading = device21Loading,
                Device22Loading = device22Loading
            };
        }
    }
}

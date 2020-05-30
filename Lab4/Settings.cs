    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Settings
    {
        public const int StartMetricDelay = 5000;

        public const double DEVICE_1_MU = 5,
                            DEVICE_2_MU = 3;

        public const int QUEUE_2_LIMIT = 8;

        public const int TimeMeasure = 10;

        private const double inputLambda = 5;

        public const int Delay = (int)((1.0 / inputLambda) * TimeMeasure);
    }

    public enum WorkMode
    {
        Intensity = 1,
        Time = 2
    }
}

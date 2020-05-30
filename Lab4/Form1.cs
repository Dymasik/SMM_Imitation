using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Security.Permissions;

namespace Lab4
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public partial class Form1 : Form
    {
        int _timeSecond;
        int _timeMinute;
        int _timeHour;

        Source source;

        CancellationTokenSource tokenSource;
        public Form1()
        {
            InitializeComponent();

            // div by 100 because I take one tick equal 100 part of seconds
            timer1.Interval = (int)Settings.TimeMeasure;

            source = new Source();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            timer1.Start();
            new Thread(Start).Start();
        }

        private void Start()
        {
            tokenSource = new CancellationTokenSource();

            var token = tokenSource.Token;

            source.ExecuteAsync(token);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            timer1.Stop();

            var information = source.GetInformation();

            SetData(information);
        }

        private void SetData(InformationDTO information)
        {
            textBoxQueue1AvrLength.Text = information.Queue1AvrLength.ToString();
            textBoxQueue2AvrLength.Text = information.Queue2AvrLength.ToString();
            textBoxQueue1AvrTimeAsReal.Text = information.Queue1AvrTimeAsReal.ToString();
            textBoxQueue2AvrTimeAsReal.Text = information.Queue2AvrTimeAsReal.ToString();
            textBoxQueue1AvrTime.Text = information.Queue1AvrTime.ToString();
            textBoxQueue2AvrTime.Text = information.Queue2AvrTime.ToString();
            textBoxDevice1Loading.Text = (information.Device11Loading + information.Device12Loading).ToString();
            textBoxDevice2Loading.Text = (information.Device21Loading + information.Device22Loading).ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timeSecond += 1;

            if (_timeSecond >= 60)
            {
                _timeMinute++;
                _timeSecond = 0;
            }
            if (_timeMinute >= 60)
            {
                _timeHour++;
                _timeMinute = 0;
            }
            timeLabel.Text = $"{_timeHour} h, {_timeMinute} m, {_timeSecond} s";
        }

    }
}

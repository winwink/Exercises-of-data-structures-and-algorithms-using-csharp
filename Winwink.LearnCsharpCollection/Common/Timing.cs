using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.Common
{
    public class Timing
    {
        private TimeSpan _startTime;
        private TimeSpan _duraction;
        public Timing()
        {
            _startTime = new TimeSpan(0);
            _duraction = new TimeSpan(0);
        }

        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            _startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        }

        public void StopTime()
        {
            _duraction = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(_startTime); 
        }

        public TimeSpan Result()
        {
            return _duraction;
        }
    }
}

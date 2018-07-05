using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.Common
{
    public class Timing : ITiming
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

        public TimeSpan ShowResult(Action a)
        {
            StartTime();
            a();
            StopTime();
            var time = Result();
            Console.WriteLine("use time" + time.TotalSeconds.ToString());
            return time;
        }
    }

    public class StopWatchTiming : ITiming
    {
        private TimeSpan _startTime;
        private TimeSpan _duraction;
        private Stopwatch _stopWatch;
        public StopWatchTiming()
        {
            _startTime = new TimeSpan(0);
            _duraction = new TimeSpan(0);
            _stopWatch = new Stopwatch();
        }

        public void StartTime()
        {
            _stopWatch.Start();
        }

        public void StopTime()
        {
            _stopWatch.Stop();
            _duraction = _stopWatch.Elapsed;
        }

        public TimeSpan Result()
        {
            return _duraction;
        }

        public TimeSpan ShowResult(Action a)
        {
            StartTime();
            a();
            StopTime();
            var time = Result();
            Console.Write("use time" + time.TotalSeconds.ToString());
            return time;
        }
    }

    public interface ITiming
    {
        void StartTime();
        void StopTime();
        TimeSpan Result();

        TimeSpan ShowResult(Action a);
    }
}

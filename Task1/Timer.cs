using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Timer 
    {
        public event EventHandler TimerCounted;

        public void OnTimerCounted()
        {
            TimerCounted?.Invoke(this, new EventArgs());
        }

        public void Run(int milliseconds)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            while (true)
            {
                if (stopWatch.ElapsedMilliseconds > milliseconds)
                    break;
            }
            OnTimerCounted();
        }

    }
}

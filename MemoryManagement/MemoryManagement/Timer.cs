using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MemoryManagement
{
    class Timer : IDisposable
    {
      private Stopwatch timerStopwatch;

      public Timer()
        {
            timerStopwatch = new Stopwatch();
        }
      public void Dispose()
        {
            timerStopwatch.Stop();
        }
      public long ElapsedMilliseconds { get { return timerStopwatch.ElapsedMilliseconds; } }
      public Timer Start(){
            timerStopwatch.Reset();
            timerStopwatch.Start();
            return this;
        }
      public Timer Continue() {
            timerStopwatch.Start();
            return this;
        }
    }
}

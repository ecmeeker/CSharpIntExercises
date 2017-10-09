using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
  class Stopwatch
  {
    private DateTime _startTime;
    private DateTime _stopTime;

    public Stopwatch() { }

    public DateTime StartTime { get; set; }
    public DateTime StopTime { get; set; }
    public TimeSpan Duration
    {
      get
      {
        return StopTime - StartTime;
      }
    }
    public void Start()
    {
      if (StartTime > StopTime)
        throw new InvalidOperationException("Timer has already been started!");
      else
        StartTime = DateTime.Now;
      return;
    }
    public TimeSpan Stop()
    {
      StopTime = DateTime.Now;
      return Duration;
    }
    public void Reset()
    {
      StartTime = DateTime.MinValue;
      StopTime = DateTime.MinValue;
      return;
    }

  }
}

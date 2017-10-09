using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Creating Stopwatch:");
      Stopwatch watch = new Stopwatch();

      watch.Start();
      System.Threading.Thread.Sleep(8000);
      Console.WriteLine(watch.Stop());
      watch.Reset();

      watch.Start();
      System.Threading.Thread.Sleep(4000);
      Console.WriteLine(watch.Stop());
      watch.Start();
      System.Threading.Thread.Sleep(5000);
      Console.WriteLine(watch.Stop());
      watch.Start();
      System.Threading.Thread.Sleep(3000);
      Console.WriteLine(watch.Stop());

      watch.Start();
      System.Threading.Thread.Sleep(2000);
      watch.Start();
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine(watch.Stop());
      watch.Reset();

      System.Threading.Thread.Sleep(3000);

    }
  }
}

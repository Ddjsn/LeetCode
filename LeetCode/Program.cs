using System;
using System.Diagnostics;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            while(Console.Read() >= 0)
            {
                break;
            }
            sw.Start();
            var a = 0;
            for(var i = 0; i < 10000000; i++)
            {
                Guid.NewGuid();
                //a = i;
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine(ts.TotalMilliseconds);
            Console.ReadKey();
        }
        
    }
  
}

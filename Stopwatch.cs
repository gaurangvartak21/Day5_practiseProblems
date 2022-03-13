using System;
using System.Threading;

namespace StopWatch_elapsedtime
{
    internal class Stopwatch
    {
        static void Main(string[] args)
        {
                Stopwatch stopwatch = new Stopwatch();
                 int start;
                 int stop;
                 int Elapsed;

                for (int i = 0; i < 1000; i++)
                {
                    Thread.Sleep(1);
                }

                Elapsed = stopwatch.stop - stopwatch.start;

                Console.WriteLine("Time elapsed: {0}", Elapsed);
            }
        }
    }
    }
}

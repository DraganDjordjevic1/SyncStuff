using Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncSyncMulti
{
      class Multi
      {
            static void Main(string[] args)
            {

                  Thread thread1 = new Thread(new ThreadStart(Threads.FirstThread));

                  Thread thread2 = new Thread(new ThreadStart(Threads.SecondThread));

                  thread1.Start();

                  thread2.Start();

                  Console.ReadLine();
            }

            public class Threads
            {
                  public static void FirstThread()
                  {
                        Stopwatch StopWatch1 = new Stopwatch();

                        StopWatch1.Start();

                        Console.WriteLine("Thread1 {0}", Class1.Pnumber(250000));

                        StopWatch1.Stop();

                        Console.WriteLine(StopWatch1.Elapsed);
                  }

                  public static void SecondThread()
                  {
                        Stopwatch StopWatch2 = new Stopwatch();

                        StopWatch2.Start();

                        Console.WriteLine("Thread2 {0}", Class1.Pnumber(400000));

                        StopWatch2.Stop();

                        Console.WriteLine(StopWatch2.Elapsed);
                  }
            }
      }
}

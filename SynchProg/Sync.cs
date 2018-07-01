using Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynchProg
{
      class Sync
      {
            static void Main(string[] args)
            {
                  Stopwatch StopWatch1 = new Stopwatch();

                  Stopwatch StopWatch2 = new Stopwatch();

                  StopWatch1.Start();

                  StopWatch2.Start();

                  var FirstTask = Class1.Pnumber(250000);

                  Console.WriteLine(FirstTask);

                  StopWatch1.Stop();

                  Console.WriteLine(StopWatch1.Elapsed);

                  var SecondTask = Class1.Pnumber(400000);

                  Console.WriteLine(SecondTask);

                  StopWatch2.Stop();

                  Console.WriteLine(StopWatch2.Elapsed);

                  Console.ReadLine();
            }
      }
}

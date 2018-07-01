using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Async
{
      class Async
      {
            static void Main(string[] args)
            {
                  Console.WriteLine(DateTime.Now);

                  Class1.PrimeAsync(250000);

                  Class1.PrimeAsync(400000);

                  Console.ReadLine();
            }
      }
}

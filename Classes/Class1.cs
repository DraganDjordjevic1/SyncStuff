using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
      public class Class1
      {
            public static long Pnumber(int n)
            {
                  int count = 0;
                  long a = 2;
                  while (count < n)
                  {
                        long b = 2;
                        int prime = 1;

                        while (b * b <= a)
                        {
                              if (a % b == 0)
                              {
                                    prime = 0;
                                    break;
                              }
                              b++;
                        }
                        if (prime > 0)
                        {
                              count++;
                        }
                        a++;
                  }
                  return (--a);
            }


            public static async Task<long> AsyncWPF(int n)
            {
                  var task = await Task.Run(() => Pnumber(n));

                  return task;
            }


            public async static void PrimeAsync(int n)
            {
                  var task = await Task.Run(() => Pnumber(n));

                  Console.WriteLine(task);

                  Console.WriteLine(DateTime.Now);

            }


      }
}

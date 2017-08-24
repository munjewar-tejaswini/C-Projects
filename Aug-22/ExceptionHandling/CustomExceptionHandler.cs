using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class TempIsZeroException : Exception
        {
            public TempIsZeroException(string message) : base(message)
            {
            }
        }

        public class Temperature
        {
            int temperature = 0;
            public void ShowTemp()
            {
                if (temperature == 0)
                {
                    throw (new TempIsZeroException("Zero temperature Found"));
                }
                else
                {
                    Console.WriteLine("Temperature is: {0}", temperature);
                }
          }
     }
}

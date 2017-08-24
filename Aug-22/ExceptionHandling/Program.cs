using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            //System defined Exception Handler: 
            ExceptionHandler ex = new ExceptionHandler();
            ex.Division(4, 0);

            //Custom defined Exception Handler: 
            Temperature t = new Temperature();
            try
            {
                t.ShowTemp();
            }
            catch(TempIsZeroException temp)
            {
                Console.WriteLine("Exception Caught: {0}",temp.Message);
            }
            

            Console.ReadLine();
        }
    }

}

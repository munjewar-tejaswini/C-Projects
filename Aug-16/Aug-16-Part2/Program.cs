using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    class Program
    {
        public delegate void CalculateSimpleInterest(int p, int n, double r);

        public double getTotalInterest(int principle, int year, double rate)
        {
            return (principle * year * rate) / 100;
           
        }


        static void Main(string[] args)
        {
            Program interestObj = new Program();
            Console.WriteLine("Enter Principle Amount, no. of years, Rate per year: ");
            int principle = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());

            //Delegate by instance method: 
            double interest = interestObj.getTotalInterest(principle, year, rate);
            Console.Clear();
            Console.WriteLine("Delegate by instance Method: \n");
            Console.WriteLine("Principle amount: {0} \nNo. of Years: {1} \nRate per Year: {2} \nSimple Interest: {3}", principle, year, rate, interest);


           // Delegate using Anonymous Method
            CalculateSimpleInterest cObj1 = delegate (int _principle, int _year, double _rate)
             {
                 Console.WriteLine("\nDelegate using Anonymous Method: \n");
                 Console.WriteLine("Principle amount: {0} \nNo. of Years: {1} \nRate per Year: {2} \nSimple Interest: {3}", _principle, _year, _rate, (_principle * _year * _rate) / 100);
             };

            cObj1(principle, year, rate);

            //Delegates using Lambda Expression
            CalculateSimpleInterest cObj2 = (_principle, _year, _rate) =>
              {
                  Console.WriteLine("\nDelegate using Lambda Method: \n");
                  Console.WriteLine("Principle amount: {0} \nNo. of Years: {1} \nRate per Year: {2} \nSimple Interest: {3}", _principle, _year, _rate, (_principle * _year * _rate) / 100);
              };
            cObj2(principle, year, rate);


            Console.ReadLine();

           
        }

    }
}

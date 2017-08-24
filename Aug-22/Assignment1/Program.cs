using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, choice;

            Console.WriteLine("Enter two values: ");
            //num1 = int.Parse(Console.ReadLine());
            while(!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid Number..!\nEnter Again");
                }
              
            //num2 = int.Parse(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid Number..!\nEnter Again");
            }

 
            do
            {
                Console.WriteLine("\n1. Add \n2. Subtract \n3. Multiplication \n4. Divide");
                Console.WriteLine("Enter your choice");
                //choice = int.Parse(Console.ReadLine());
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice..!\nEnter Again");
                }
                

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("\nAddition: \n{0} + {1} ={2}", num1, num2, MathLib.Add(num1, num2));
                        break;

                    case 2:

                        Console.WriteLine("\nSubtraction: \n{0} - {1} ={2}", num1, num2, MathLib.Subtract(num1, num2));
                        break;

                    case 3:

                        Console.WriteLine("\nMultiplication:\n{0} * {1} ={2}", num1, num2, MathLib.Multiply(num1, num2));
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("\nDivision: \n{0} / {1} ={2}", num1, num2, MathLib.Divide(num1, num2));
                        }
                        catch(DivideByZeroException d)
                        {
                            Console.WriteLine("Exception Cought: {0}", d.Message);
                        }
                        break;

                    default:
                        break;

                }
               
            }while (choice!= 4);

            Console.ReadLine();
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1: 
            /*FlyingBirds fly=new FlyingBirds();
            Console.WriteLine("First Type of Birds\n");
            fly.Walk();
            fly.Fly();

            SingingBirds sing = new SingingBirds();
            Console.WriteLine("\nSecond Type of Birds\n");
            sing.Walk();
            sing.Sing();*/

            //Question 2:

            /* int []numbers = new int[4];
             Addition ads = new Addition();
             Console.WriteLine("Enter no. of Arguments: \n2\n3\n4 \n ");
             int choice= int.Parse(Console.ReadLine());

             Console.WriteLine("Enter {0} Values: \n", choice);
             for (int i=0; i<choice;i++)
             {
                 numbers[i] = int.Parse(Console.ReadLine());
             }

             switch (choice)
             {
                 case 2:
                     ads.Add(numbers[0],numbers[1]);
                     break;

                 case 3:
                     ads.Add(numbers[0], numbers[1],numbers[2]);
                     break;

                 case 4:
                     ads.Add(numbers[0], numbers[1], numbers[2],numbers[3]);
                     break;
                 default:
                     Console.WriteLine("Wrong Input");
                     break;
             }
             */

            //Question 3:

            Notification nt = null;

            Console.WriteLine("Enter your choice: \n 1: SMS\n 2:Email\n ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    nt = new SmsNotification();
                    nt.NotifyUser();
                    break;

                case 2:
                    nt = new EmailNotification();
                    nt.NotifyUser();
                    break;

                default:
                    nt = new Notification();
                    nt.NotifyUser();
                    break;
            }


            Console.ReadLine();

        }
    }
}

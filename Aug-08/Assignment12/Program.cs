using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Id, Name and No. of Units: ");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int unit = int.Parse(Console.ReadLine());

            ElectricityBill elObj = new ElectricityBill();

            Console.WriteLine("Customer IDNO: {0} \nCustomer Name: {1} \nUnit Consumed: {2}", id, name, unit);
            elObj.GetBill(id, name, unit);

            
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfNum
{
    class Program
    {
        static void Main(string[] args)
        {
        
            ClassGenerateTable clObj = new ClassGenerateTable();
            Console.WriteLine("Enter any Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Table of {0}", num);
            clObj.MethodGenerateTable(num);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandling file = new FileHandling();
            file.CreateFile();
            file.WriteToFile();
            file.ReadfromFile();
            Console.ReadLine();
        }
    }
}

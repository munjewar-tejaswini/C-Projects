using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    public static class ExtensionMethodClass
    {
        //public static int WordCount(this String str)
        //{
        //    return str.Split(new char[] { ' ', '.', '?' },
        //                     StringSplitOptions.RemoveEmptyEntries).Length;
        //}

        public static string  Hello(this string str)
        {
            Console.WriteLine("Hello All");
            return str;
        }
    }
}

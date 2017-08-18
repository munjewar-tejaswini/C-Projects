using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_RemoveExtraSpace
{
    class RemoveExtraSpace
    {
        public void MethodRemoveExtraSpace(string str)
        {
            string strCopy = "";
            for (int i = 0; i < str.Length; i++)
            {
                strCopy = Regex.Replace(str, @"\s+", "");
            }
            Console.WriteLine("\nExpected String: {0}", strCopy);
        }
    }
}

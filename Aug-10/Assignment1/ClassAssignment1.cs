using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class ClassAssignment1
    {
        public static string UppercaseEachFirst(this string Str)
        {
            char[] StrArr = Str.ToLower().ToCharArray();
            for(int i=0; i<Str.Length; i++)
            {
                StrArr[i] = i == 0 || StrArr[i - 1] == ' ' ? char.ToUpper(StrArr[i]) : StrArr[i];
            }
            return new string(StrArr);
        }

    }
}

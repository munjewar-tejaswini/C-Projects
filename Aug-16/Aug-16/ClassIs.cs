using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug_16
{
    class ClassIs
    {
        public static void Method()
        {
            object[] myObj = new object[6];
            myObj[0] = new class1();
            myObj[1] = new class2();
            myObj[2] = "String";
            myObj[3] = 32;
            myObj[4] = null;

            for(int i=0; i<myObj.Length; ++i)
            {
                string s = myObj[i] as string;
                Console.Write("{0}: ", i);

                if (s != null)
                    Console.WriteLine("'" + s + "'");
                else
                    Console.WriteLine("Not a string");
            }

        }
    }

    class class1
        {

        }
    class class2
    {

    }
}

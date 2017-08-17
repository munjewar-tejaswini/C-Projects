using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfNum
{
    class ClassGenerateTable
    {
       public void MethodGenerateTable(int num)
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i * num);
            }
        }
    }
}

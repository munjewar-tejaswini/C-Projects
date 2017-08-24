using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class DivideByZeroException : Exception
    {
        public DivideByZeroException(string message) : base(message)
        {

        }
    }

    class ExceptionHandler : Exception
    {
       
    }
}

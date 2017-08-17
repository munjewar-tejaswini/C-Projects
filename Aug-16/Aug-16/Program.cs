using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a=int.MaxValue;
            //int c = a * a;
            //Console.WriteLine(c);

            //int b = checked(a * a);     //An unhandled exception of type 'System.OverflowException' occurred 
            //Console.WriteLine(b);

            //int d = unchecked(a * a);  //Displays Random Value
            //Console.WriteLine(d);

            //int a = 200000;
            ////int b = 300000;
            //Console.WriteLine(sizeof(int));
            //Console.WriteLine(typeof(Program));


            //if(a is float)
            //{
            //    Console.WriteLine("a is float");
            //}
            //else
            //{
            //    Console.WriteLine("a is not float");
            //}

            // ClassIs.Method();            



            //  Console.WriteLine("typeof int : {0}", typeof(int));
            //Console.WriteLine("typeof char : {0}", typeof(char));
            //Console.WriteLine("typeof bool : {0}", typeof(bool));
            //Console.WriteLine("typeof double : {0}", typeof(double));

            //Console.WriteLine(2-3*7);
            //int o = 10;
            //object i = o;//Boxing

            //int j = (int)i;//Unbox

            //i = 400;
            //Console.WriteLine("value of i: {0}",i);
            //Console.WriteLine("value of j: {0}", j);
            //Console.WriteLine("value of o: {0}", o);

            //SomeClass x, y;
            //x=new SomeClass();
            //y = new SomeClass();

            ////x = y;
            //Console.WriteLine("null and null    : {0}", ReferenceEquals(null,null));
            //Console.WriteLine("x and x          : {0}", ReferenceEquals(x, x));
            //Console.WriteLine("x and null       : {0}", ReferenceEquals(x, null));
            //Console.WriteLine("y and null       : {0}", ReferenceEquals(y, null));
            //Console.WriteLine("y and y          : {0}", ReferenceEquals(y, y));
            //Console.WriteLine("x and y          : {0}", ReferenceEquals(x, y));


            MyBaseClass derivedObject = new MyDerivedClass();
            MyBaseClass baseObject = new MyBaseClass();

            MyDerivedClass derivedCopy1 = (MyDerivedClass) derivedObject;
            //MyDerivedClass derivedCopy2 = (MyDerivedClass) baseObject;  //exception

            baseObject.MethodBase();
            derivedObject.MethodBase();
            derivedCopy1.MethodDerived();




            Console.ReadLine();

        }
    }
    //class SomeClass
    //{
        
    //}

  
}

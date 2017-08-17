using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementEvents EventObj = new ImplementEvents();
            //ImplementEvents.MyDelegate myDel = new ImplementEvents.MyDelegate(MethodEventHandler);
            EventObj.MyEvent += new ImplementEvents.MyDelegate(MethodEventHandler);

            Console.WriteLine("Please Enter Your Message");
            string msg = Console.ReadLine();

            EventObj.RaiseEvent(msg);

            Console.ReadLine();
        }

        static void MethodEventHandler( string message)
        {
            Console.WriteLine("Your message is '{0}'",message);
        }
    }

    public class ImplementEvents
    {
        public delegate void MyDelegate(string message);
        public event MyDelegate MyEvent;

        public void RaiseEvent(string message)
        {
            if(MyEvent != null)
            {
                MyEvent(message);
            }
        }
    }
}

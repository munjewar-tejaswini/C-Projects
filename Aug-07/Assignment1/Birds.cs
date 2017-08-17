using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   public abstract class Birds
    {
        public abstract void Walk();
       
    }
    class FlyingBirds : Birds
    {
        public override void Walk()
        {
            Console.WriteLine("Birds can Walk");
        }

        public void Fly()
        {
            Console.WriteLine("Birds can fly");
        }

    }


    class SingingBirds : Birds
    {
        public override void Walk()
        {
            Console.WriteLine("Birds can Walk");
        }

        public void Sing()
        {
            Console.WriteLine("Birds can Sing");
        }
    }

}

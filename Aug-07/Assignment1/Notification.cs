using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Notification
    {
        public virtual void NotifyUser()
        {
            Console.WriteLine("Notify Method Unknown");
        }
    }

    class SmsNotification : Notification
    {
        public override void NotifyUser()
        {
            Console.WriteLine("Notify user via SMS");
        }
    }

    class EmailNotification : Notification
    {
        public override void NotifyUser()
        {
            Console.WriteLine("Notify user via Email");
        }
    }
}

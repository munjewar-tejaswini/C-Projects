using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class ElectricityBill
    {
        public void GetBill(int id, string name, int unit)
        {
            if (unit <= 199)
                Console.WriteLine("Amount Charges @Rs. 1.20 per unit: {0}",unit*1.2);
            else if(unit>=200 && unit<400)
                Console.WriteLine("Amount Charges @Rs. 1.50 per unit: {0}", unit * 1.5);
            else if (unit >= 400 && unit < 600)
                Console.WriteLine("Amount Charges @Rs. 1.80 per unit: {0} \nSurchage Amount: {1} \nNet Amount Paid By the Customer: {2}", unit * 1.8, unit * 0.15, (unit * 1.8 + unit * 0.15));
            else if (unit >= 600)
                Console.WriteLine("Amount Charges @Rs. 2.00 per unit: {0} \nSurchage Amount: {1} \nNet Amount Paid By the Customer: {2}", unit * 2.0, unit * 0.15, (unit * 2.0 + unit * 0.15));

        }
    }
}

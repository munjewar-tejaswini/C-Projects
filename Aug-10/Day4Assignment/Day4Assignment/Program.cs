﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
                AreaMaster as_object1 = new AreaMaster(id: 1, code: "IND", name: "India", description: "Hello World", areaId: 0, areaType: AreaMaster.AreaTypeEnum.Country);
                AreaMaster as_object2 = new AreaMaster(id: 2, code: "MH", name: "Maharashtra", description: "Hello World", areaId: 1, areaType: AreaMaster.AreaTypeEnum.State);
                AreaMaster as_object3 = new AreaMaster(id: 3, code: "NGP", name: "Nagpur", description: "Orange City", areaId: 2, areaType: AreaMaster.AreaTypeEnum.City);
                AreaMaster as_object4 = new AreaMaster(id: 4, code: "NG", name: "Nagpur District", description: "Hello World", areaId: 3, areaType: AreaMaster.AreaTypeEnum.District);


              //as_object4.GetAreaMasterByCity("Nagpur");
            as_object4.GetAreaMasterByState("Maharashtra");
            //as_object4.GetAreaMasterByCountry("India");
            Console.ReadLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment
{
    public class CountryMaster : AreaMaster
    {
        public override AreaTypeEnum AreaType
            {
                get
                {
                    return AreaTypeEnum.Country;
                }

                set
                {
                    AreaType = AreaTypeEnum.Country;
                }
            }
      }
}


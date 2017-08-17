using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment
{
    public class StateMaster : AreaMaster
    {
        public override AreaTypeEnum AreaType
        {
            get
            {
                return AreaTypeEnum.State;
            }

            set
            {
                AreaType = AreaTypeEnum.State;
            }
        }
    }
}

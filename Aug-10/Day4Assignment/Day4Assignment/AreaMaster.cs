using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment
{
    public class AreaMaster
    {
        public enum AreaTypeEnum { Country, State, City, District }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AreaId { get; set; }
        public virtual AreaTypeEnum AreaType { get; set; }
        public static List<AreaMaster> AreaCollection = new List<AreaMaster>();
        
        //Default Constructor
        public AreaMaster() { }

        //Parameterized Constructor
        
        public AreaMaster(int id, string code, string name, string description, int areaId, AreaTypeEnum areaType)
        {
            ID = id;
            Code = code;
            Name = name;
            Description = description;
            AreaId = areaId;
            AreaType = areaType;
            AreaCollection.Add(this);
        }


        public int state_id;
        public int country_id;
        public int city_id;

        public void Print()
        {
            foreach (var area in AreaCollection)
            {
                Console.WriteLine("ID:  {0}", area.ID);
                Console.WriteLine("Code:  {0}", area.Code);
                Console.WriteLine("Name:  {0}", area.Name);
                Console.WriteLine("Description:  {0}", area.Description);
                Console.WriteLine("AreaType:  {0}", area.AreaType);
                Console.WriteLine("AreaID:  {0}", area.AreaId);
            }
        }

        //Get Area by City Function
        public void GetAreaMasterByCity(string city_name)
        {

            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.City && area.Name == city_name)
                {
                    Console.WriteLine("Name : {0}", area.Name);
                    state_id = area.AreaId;
                }
            }
            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.State && area.ID == state_id)
                {
                    Console.WriteLine("State : {0}", area.Name);
                    country_id = area.AreaId;
                }
            }
            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.Country && area.ID == country_id)
                {
                    Console.WriteLine("Country : {0}", area.Name);
                }
            }
            
        }

        //Get Area by State Function
        public void GetAreaMasterByState(string state_name)
        {

            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.State && area.Name == state_name)
                {
                    Console.WriteLine("Name : {0}", area.Name);
                    country_id = area.AreaId;
                }
            }
            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.Country && area.ID == country_id)
                {
                    Console.WriteLine("Country : {0}", area.Name);

                }
            }


        }

        //Get Area by Country Function
        public void GetAreaMasterByCountry(string country_name)
        {

            foreach (var area in AreaCollection)
            {
                if (area.AreaType == AreaTypeEnum.Country && area.Name == country_name)
                {
                    Console.WriteLine("Name : {0}", area.Name);
                    country_id = area.AreaId;
                }
            }
          
        }

        //end
        
    }
}

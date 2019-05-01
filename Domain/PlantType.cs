using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Domain
{
    public class PlantType
    {

        public int PlantNumber { get; private set; }
        public string Type { get; private set; }
        public int ExpectedGrowthTimeInDays { get; private set; }

        public PlantType(string type, int expectedGrowthTimeInDays, int plantNumber)
        {
            Type = type;
            ExpectedGrowthTimeInDays = expectedGrowthTimeInDays;
            PlantNumber = plantNumber;
        }


    }
}

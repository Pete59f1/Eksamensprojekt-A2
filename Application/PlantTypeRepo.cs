using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppeA2.Domain;

namespace GruppeA2.Application
{
    public class PlantTypeRepo : Repo<PlantType>
    {
        public int get_plant_number(PlantType planttype)
        {
            return planttype.PlantNumber;
        }
        public string get_plant_type(PlantType planttype)
        {
            return planttype.Type;
        }
        public string get_plant_phaseOne(PlantType planttype)
        {
            return planttype.PhaseOne;
        }
        public string get_plant_phaseTwo(PlantType planttype)
        {
            return planttype.PhaseTwo;
        }
        public string get_plant_phaseThree(PlantType planttype)
        {
            return planttype.PhaseThree;
        }
        public string get_plant_phaseFour(PlantType planttype)
        {
            return planttype.PhaseFour;
        }
    }
}

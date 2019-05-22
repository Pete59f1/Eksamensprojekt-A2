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
        public int GetPlantNumber(PlantType plantType)
        {
            return plantType.PlantNumber;
        }
        public string GetPlantType(PlantType plantType)
        {
            return plantType.Type;
        }
        public string GetPlantPhaseOne(PlantType plantType)
        {
            return plantType.PhaseOne;
        }
        public string GetPlantPhaseTwo(PlantType plantType)
        {
            return plantType.PhaseTwo;
        }
        public string GetPlantPhaseThree(PlantType plantType)
        {
            return plantType.PhaseThree;
        }
        public string GetPlantPhaseFour(PlantType plantType)
        {
            return plantType.PhaseFour;
        }
    }
}

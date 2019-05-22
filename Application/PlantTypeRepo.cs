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
        public int GetPlantNumber(int index) => RepoCollection[index].PlantNumber;

        public string GetPlantType(int index) => RepoCollection[index].Type;

        public string GetPlantPhaseOne(int index) => RepoCollection[index].PhaseOne;

        public string GetPlantPhaseTwo(int index) => RepoCollection[index].PhaseTwo;

        public string GetPlantPhaseThree(int index) => RepoCollection[index].PhaseThree;

        public string GetPlantPhaseFour(int index) => RepoCollection[index].PhaseFour;
      
    }
}

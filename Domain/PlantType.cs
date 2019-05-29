using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Domain
{
    public class PlantType
    {

        public int PlantId { get; private set; }
        public string Type { get; private set; }
        public string PhaseOne { get; private set; }
        public string PhaseTwo { get; private set; }
        public string PhaseThree { get; private set; }
        public string PhaseFour { get; private set; }

        public PlantType(int plantId, string type, string phaseOne, string phaseTwo, string phaseThree, string phaseFour)
        {
            PlantId = plantId;
            Type = type;
            PhaseOne = phaseOne;
            PhaseTwo = phaseTwo;
            PhaseThree = phaseThree;
            PhaseFour = phaseFour;
        }
    }
}

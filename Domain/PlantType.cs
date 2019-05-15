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
        public int PhaseOne { get; private set; }
        public int PhaseTwo { get; private set; }
        public int PhaseThree { get; private set; }
        public int PhaseFour { get; private set; }

        public PlantType(int plantNumber, string type, int phaseOne, int phaseTwo, int phaseThree, int phaseFour)
        {
            PlantNumber = plantNumber;
            Type = type;
            PhaseOne = phaseOne;
            PhaseTwo = phaseTwo;
            PhaseThree = phaseThree;
            PhaseFour = phaseFour;
        }



    }
}

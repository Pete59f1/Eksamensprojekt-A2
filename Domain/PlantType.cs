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

        public override bool Equals(object obj)
        {
            PlantType p;
            if (obj is PlantType)
            {
                p = obj as PlantType;
                if (p.Type == this.Type && p.PlantId == this.PlantId)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
                throw new Exception("The Object you want to compare is not a PlantType");
            }
        }
    }
}

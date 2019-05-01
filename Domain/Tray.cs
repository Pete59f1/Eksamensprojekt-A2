using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Tray
    {

        public int Traynumber { get; private set; }
        public PlantType PlantType { get; private set; }
        public DateTime ExpectedEndDate { get; private set; }
        public bool IsInProduction { get; private set; }
        public DateTime EndDate { get; private set; }

        public Tray(int traynumber, PlantType plantType, DateTime expectedEndDate, bool isInProduction)
        {
            Traynumber = traynumber;
            PlantType = plantType;
            ExpectedEndDate = expectedEndDate;
            IsInProduction = isInProduction;
        }
        public void ChangePlantType(PlantType planttype)
        {
            PlantType = planttype;
        }
        public void EndTrayDate(DateTime endTrayDate)
        {
            EndDate = endTrayDate;
        }
    }
}

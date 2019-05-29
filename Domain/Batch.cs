using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Domain
{
    public class Batch
    {
       
        public int BatchNr { get; private set; }
        public int Phase { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int PlantId { get; private set; }
        public List<Day> DaysInProduction { get; set; } = new List<Day>();

        public Batch(int batchNr, int phase, DateTime startDate, DateTime endDate, int plantId)
        {
            BatchNr = batchNr;
            Phase = phase;
            StartDate = startDate;
            EndDate = endDate;
            PlantId = plantId;
        }
    }
}

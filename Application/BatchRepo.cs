using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppeA2.Domain;

namespace GruppeA2.Application
{
    public class BatchRepo : Repo<Batch>
    {
        public int GetProductionNumberByIndex(int index) => RepoCollection[index].ProductionNumber;
        public int GetPhaseByIndex(int index) => RepoCollection[index].Phase;
        public DateTime GetStartDateByIndex(int index) => RepoCollection[index].StartDate;
        public DateTime GetEndDateByIndex(int index) => RepoCollection[index].EndDate;
        public int GetPlantIdByIndex(int index) => RepoCollection[index].PlantId;
        public List<int> GetDayNrByBatchId(int batchId)
        {
            List<int> days = new List<int>();
            foreach (Batch batch in RepoCollection)
            {
                if (batch.ProductionNumber.Equals(batchId))
                {
                    foreach (Day day in batch.DaysInProduction)
                    {
                        days.Add(day.DayNr);
                    }
                }
            }
            return days;
        }
    }
}

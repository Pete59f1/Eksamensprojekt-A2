using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Domain
{
    public class Batch
    {
       
        public int ProductionNumber { get; private set; }
        public int Phase { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public List<Day> DaysInProduction { get; private set; } = new List<Day>();
        public Day CurrentDay {
            get
            {
                foreach (Day item in DaysInProduction)
                {
                    if (item.Date == DateTime.Today)
                    {
                        return item;
                    }
                }
                return null;
            }
           
        }

     
        public Batch(int productionNUmber, int phase, DateTime startDate, DateTime endDate)
        {
            ProductionNumber = productionNUmber;
            Phase = phase;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void AddDay(Day day)
        {
            DaysInProduction.Add(day);
        }
        public void RemoveDay(int dayNr)
        {
            foreach (Day item in DaysInProduction)
            {
                    if (item.DayNr == dayNr)
                    {
                    DaysInProduction.Remove(item);
                    }
            }
        }
        public Day GetDay (int dayNr)
        {
            Day tray = null;
            foreach (Day item in DaysInProduction)
            {
                if (item.DayNr == dayNr)
                {
                    tray = item;
                    return tray;
                }

            }
            return tray;
        }

    }
}

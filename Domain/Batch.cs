using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Domain
{
    public class Batch
    {
       

        public int ProductionNUmber { get; private set; }
        public int Phase { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public List<Tray> TraysInProduction { get; private set; }
        public Batch(int productionNUmber, int phase, DateTime startDate, DateTime endDate)
        {
            ProductionNUmber = productionNUmber;
            Phase = phase;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void AddTray(Tray tray)
        {
            TraysInProduction.Add(tray);
        }
        public void RemoveTray(int trayNumber)
        {
            foreach (Tray item in TraysInProduction)
            {
                    if (item.Traynumber == trayNumber)
                    {
                        TraysInProduction.Remove(item);
                    }
            }
        }
        public Tray GetTray (int trayNumber)
        {
            Tray tray = null;
            foreach (Tray item in TraysInProduction)
            {
                if (item.Traynumber == trayNumber)
                {
                    tray = item;
                    return tray;
                }

            }
            return tray;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Production
    {
        public int ProductionNUmber { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime ExpectedEndDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Assessment { get; private set; }
        public bool IsProductionDone { get; private set; }
        public List<Tray> TraysInProduction { get; private set; }

        public Production(DateTime startDate, DateTime expectedEndDate, DateTime endDate, string assessment, bool isProductionDone)
        {
            StartDate = startDate;
            ExpectedEndDate = expectedEndDate;
            EndDate = endDate;
            Assessment = assessment;
            IsProductionDone = isProductionDone;
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
        public void ChangeAssessment(string assessment)
        {
            Assessment = assessment;
        }
        public void EndProduction(DateTime endDate)
        {
            EndDate = endDate;
            IsProductionDone = true;
        }
    }
}

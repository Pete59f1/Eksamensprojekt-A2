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
        private Controller controller = new Controller();

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

        public void DeleteAllDaysButChosen(int batchId, int dayNr)
        {
            foreach (Batch batch in RepoCollection)
            {
                if (batch.ProductionNumber.Equals(batchId))
                {
                    for(int i = 0; i < batch.DaysInProduction.Count; i++)
                    {
                        if (batch.DaysInProduction[i].DayNr != dayNr)
                        {
                            batch.DaysInProduction.Remove(batch.DaysInProduction[i]);
                        }
                    }
                }
            }
        }
        public int GetDayIdFromDayNr(int batchNr, int dayNr)
        {
            int dayId = 0;
            foreach (Batch batch in RepoCollection)
            {
                if (batch.ProductionNumber.Equals(batchNr))
                {
                    foreach (Day day in batch.DaysInProduction)
                    {
                        if (day.DayNr.Equals(dayNr))
                        {
                            dayId = day.DayId;
                        }
                    }
                }
            }
            return dayId;
        }
        public void AddPictureDataFromDayId(int batchNr, int dayNr)
        {
            foreach (Batch batch in RepoCollection)
            {
                if (batch.ProductionNumber.Equals(batchNr))
                {
                    foreach (Day day in batch.DaysInProduction)
                    {
                        if (day.DayNr.Equals(dayNr))
                        {
                            day.PicturesFromThisDay = controller.GetAllPicturesFromDayId(day.DayId);
                        }
                    }
                }
            }
        }

        public string GetPictureLinkByIndex(int batchNr, int dayNr, int index)
        {
            string pictureLink = "";
            foreach (Batch batch in RepoCollection)
            {
                if (batch.ProductionNumber.Equals(batchNr))
                {
                    foreach (Day day in batch.DaysInProduction)
                    {
                        if (day.DayNr.Equals(dayNr))
                        {
                            for (int i = 0; i < day.PicturesFromThisDay.Count; i++)
                            {
                                if (i.Equals(index))
                                {
                                    pictureLink = day.PicturesFromThisDay[i].PictureLink;
                                }
                            }
                        }
                    }
                }
            }
            return pictureLink;
        }

        public int GetPictureNumberByIndex(int batchNr, int dayNr, int index)
        {
            int pictureNumber = 0;
            foreach (Batch batch in RepoCollection)
            {
                if (batch.ProductionNumber.Equals(batchNr))
                {
                    foreach (Day day in batch.DaysInProduction)
                    {
                        if (day.DayNr.Equals(dayNr))
                        {
                            for (int i = 0; i < day.PicturesFromThisDay.Count; i++)
                            {
                                if (i.Equals(index))
                                {
                                    pictureNumber = day.PicturesFromThisDay[i].PictureNumber;
                                }
                            }
                        }
                    }
                }
            }
            return pictureNumber;
        }
    }
}

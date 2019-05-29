using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Domain
{
    public class Day
    {
        public int DayId { get; private set; }
        public int DayNr { get; private set; }
        public DateTime Date { get; private set; }

        public List<Picture> PicturesFromThisDay { get; set; }

        public Day(int dayId, int dayNr, DateTime date)
        {
            PicturesFromThisDay = new List<Picture>();
            DayId = dayId;
            DayNr = dayNr;
            Date = date;
        }
    }
}

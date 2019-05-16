using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Domain
{
    public class Day
    {
        public int DayNr { get; private set; }
        public DateTime Date { get; private set; }

        public List<Picture> PictureRepo { get; private set; }

        public Day(int dayNr, DateTime date)
        {
            PictureRepo = new List<Picture>();
            DayNr = dayNr;
            Date = date;
        }
        public void AddPicture(Picture p) => PictureRepo.Add(p);

        public Picture GetPicture() => throw new NotImplementedException();

    }
}

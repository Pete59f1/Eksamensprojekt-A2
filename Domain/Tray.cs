using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Domain
{
    public class Tray
    {

        public int Traynumber { get; private set; }
        public PlantType PlantType { get; private set; }
        public DateTime ExpectedEndDate { get; private set; }
        public bool IsInProduction { get; private set; }
        public DateTime EndDate { get; private set; }
        public List<Picture> PicturesInTray { get; private set; }

        public Tray(int traynumber, PlantType plantType, DateTime expectedEndDate, bool isInProduction)
        {
            Traynumber = traynumber;
            PlantType = plantType;
            ExpectedEndDate = expectedEndDate;
            IsInProduction = isInProduction;
        }

        public void AddPicture(Picture picture)
        {
            PicturesInTray.Add(picture);
        }
        public void RemovePicture(int pictureNumber)
        {
            foreach (Picture item in PicturesInTray)
            {
                if (item.PictureNumber == pictureNumber)
                {
                    PicturesInTray.Remove(item);
                }
            }
        }
        public Picture GetPicture(int pictureNumber)
        {
            Picture picture = null;
            foreach (Picture item in PicturesInTray)
            {
                if (item.PictureNumber == pictureNumber)
                {
                    picture = item;
                    return picture;
                }

            }
            return picture;
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

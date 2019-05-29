using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Domain
{
    public class Picture
    {

        public int PictureId { get; private set; }
        public DateTime Name { get; private set; }
        public string Comment { get; private set; }
        public PictureStatus Status { get; private set; }
        public int TrayNumber { get; private set; }
        public string PictureLink { get; private set; } = "/Domain;component/Images/01-05-2019.png";

        public Picture(int pictureId, DateTime name, string comment, PictureStatus status, string pictureLink, int tray)
        {
            PictureId = pictureId;
            Name = name;
            Comment = comment;
            Status = status;
            PictureLink = pictureLink;
            TrayNumber = tray;
        }        
        public static PictureStatus ConvertStringStatusToEnumStatus(string status)
        {
            PictureStatus stat;
            if (status == "")
            {
                stat = PictureStatus.unset;
            }
            else
            {
                stat = (PictureStatus)Enum.Parse(typeof(PictureStatus), status);
            }
            return stat;
        }

        public static string ConvertStatusFromDkToEng(string status)
        {
            string translation = "";

            if (status.Equals("Exeptional Vækst"))
            {
                translation = "ExceptionalGrowth";
            }
            else if (status.Equals("Normal Vækst"))
            {
                translation = "NormalGrowth";
            }
            else if (status.Equals("Lidt Vækst"))
            {
                translation = "SomeGrowth";
            }
            else if (status.Equals("Intet Vækst"))
            {
                translation = "NoGrowth";
            }
            else if (status.Equals("Død"))
            {
                translation = "Dead";
            }
            return translation;
        }
    }
}

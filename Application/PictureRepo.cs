using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppeA2.Application;
using GruppeA2.Domain;

namespace GruppeA2.Application
{
    public class PictureRepo : Repo<Picture>
    {
        public int GetPictureNumber(Picture pic)
        {
            return pic.PictureNumber;
        }
        public DateTime GetPictureName(Picture pic)
        {
            return pic.Name;
        }
        public string GetPictureComment(Picture pic)
        {
            return pic.Comment;
        }
        public PictureStatus GetPictureStatus(Picture pic)
        {
            return pic.Status;
        }
        public int GetPictureTray(Picture pic)
        {
            return pic.Traynumber;
        }
        public string GetPictureLink(Picture pic)
        {
            return pic.PictureLink;
        }
    }
}

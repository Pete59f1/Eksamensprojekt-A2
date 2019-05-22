using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppeA2.Application;
using GruppeA2.Domain;

namespace GruppeA2.Application
{
    public class NewPicturesRepo : Repo<Picture>
    {
        public int GetPictureNumberByIndex(int index) => RepoCollection[index].PictureNumber;
        public DateTime GetPictureNameByIndex(int index) => RepoCollection[index].Name;


        public string GetPictureCommentByPictureNumber(int pictureNumber)
        {
            foreach (Picture item in RepoCollection)
            {
                if (item.PictureNumber == pictureNumber)
                {
                    return item.Comment;
                }
            }
            return "fejl";
        }
        public int GetPictureStatusByPictureNumber(int pictureNumber)
        {
            foreach(Picture item in RepoCollection)
            {
                if (item.PictureNumber == pictureNumber)
                {
                    return Convert.ToInt32(item.Status);
                }
            }
            return 0;
        }
        public string GetPictureLinkByIndex(int index) => RepoCollection[index].PictureLink;

    }
}

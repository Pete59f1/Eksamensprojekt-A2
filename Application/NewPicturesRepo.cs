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
        public string GetPictureCommentByIndex(int index) => RepoCollection[index].Comment;
        public int GetPictureStatusByIndex(int index) => Convert.ToInt32(RepoCollection[index].Status);
        public string GetPictureLinkByIndex(int index) => RepoCollection[index].PictureLink;

    }
}

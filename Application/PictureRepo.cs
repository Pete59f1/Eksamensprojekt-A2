using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppeA2.Domain;

namespace GruppeA2.Application
{
    public class PictureRepo : Repo<Picture>
    {
        public PictureRepo()
        {
            
        }
        public string GetName(int index) => RepoCollection[index].Name.ToString();
        public int GetStatus(int index) => Convert.ToInt32(RepoCollection[index].Status);
        public string GetComment(int index) => RepoCollection[index].Comment;
        public int GetTrayNumber(int index) => RepoCollection[index].Traynumber;
        public string GetPictureLink(int index) => RepoCollection[index].PictureLink;

        public void DeletePicture(int checkedIndex)
        {
            RepoCollection[checkedIndex] = null;
        }
    }
}

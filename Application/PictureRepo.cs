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
        public string GetStatus(int index) => RepoCollection[index].Status.ToString();
        public string GetComment(int index) => RepoCollection[index].Comment;
        public int GetTrayNumber(int index) => RepoCollection[index].Traynumber;
        public string GetPictureLink(int index) => RepoCollection[index].PictureLink;
    }
}

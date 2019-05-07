using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppeA2.Domain;

namespace GruppeA2.Application
{
    public class Controller
    {
        // Test til UI
        public PictureRepo pictureRepo;
        public Controller()
        {
            pictureRepo = new PictureRepo();
            Picture pic = new Picture(DateTime.Now, 1);
   
            pictureRepo = new PictureRepo();
            Picture pic1 = new Picture(DateTime.Now, 1);

            pictureRepo = new PictureRepo();
            Picture pic2 = new Picture(DateTime.Now, 1);

            pictureRepo.AddItem(pic);
            pictureRepo.AddItem(pic1);
            pictureRepo.AddItem(pic2);


        }
        public void UpdatePictures()
        {

        }
    }
}

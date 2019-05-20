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
        private GetDBController GDBC = new GetDBController();
        public Batch activeBatch = new Batch(1,1,new DateTime(2019,05,20),new DateTime(2019,05,23));

        public Controller()
        {
           


            Picture pic = new Picture(DateTime.Now, 1);
            pic.ChangePictureNumber(0);
            pic.ChangePictureStatus(4);
            pic.ChangePictureComment("Sejt");
            Picture pic1 = new Picture(DateTime.Now, 1);
            pic1.ChangePictureNumber(1);
            pic1.ChangePictureStatus(0);
            Picture pic2 = new Picture(DateTime.Now, 1);
            pic2.ChangePictureNumber(2);
            pic2.ChangePictureStatus(1);

            activeBatch.AddDay(new Day(1,new DateTime(2019, 05, 20)));
            activeBatch.AddDay(new Day(1, new DateTime(2019, 05, 22)));
            activeBatch.AddDay(new Day(1, new DateTime(2019, 05, 23)));

            activeBatch.DaysInProduction[0].AddPicture(pic);
            activeBatch.DaysInProduction[0].AddPicture(pic1);
            activeBatch.DaysInProduction[0].AddPicture(pic2);


        }

        public string GetPictureCommentInActiveBranch(int pictureIndex) => activeBatch.CurrentDay.PictureRepo[pictureIndex].Comment;
        public int GetPictureStatusInActiveBranch(int pictureIndex) => activeBatch.CurrentDay.PictureRepo[pictureIndex].FindStatus(pictureIndex);
        public void UpdatePictures()
        {

        }

        public PlantTypeRepo GetAllPlantType()
        {
            return GDBC.GetAllPlantType();
        }

    }
}

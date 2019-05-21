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
        private AddDBController ADBC = new AddDBController();
        private GetDBController GDBC = new GetDBController();
        public Batch activeBatch = new Batch(1,1,new DateTime(2019,05,20),new DateTime(2019,05,23));

        public Controller()
        {
           
        }

        
        public int GetPictureStatusInActiveBranch(int pictureIndex) => activeBatch.CurrentDay.PictureRepo[pictureIndex].FindStatus(pictureIndex);
        public void UpdatePictures()
        {

        }

        public PlantTypeRepo GetAllPlantType()
        {
            return GDBC.GetAllPlantType();
        }
        public PictureRepo GetPicturesWithNoCommentAndStatus()
        {
            return GDBC.GetPicturesWithNoCommentAndStatus();
        }
        public void new_batch(int phase, DateTime start_date, DateTime end_date, int plantId)
        {
            ADBC.new_batch(phase, start_date, end_date, plantId);
        }
    }
}

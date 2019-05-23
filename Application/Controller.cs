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
        private ChangeDBController CDBC = new ChangeDBController();
        public Controller()
        {
           
        }
        public void UpdatePictures()
        {

        }
        public void save_picture(string comment, string status, int pictureId)
        {
            CDBC.SavePicture(comment, status, pictureId);   
        }
        public void delete_picture(int pictureId)
        {
            CDBC.DeletePicture(pictureId);
        }
        public PlantTypeRepo GetAllPlantType()
        {
            return GDBC.GetAllPlantType();
        }
        public NewPicturesRepo GetPicturesWithNoCommentAndStatus()
        {
            return GDBC.GetPicturesWithNoCommentAndStatus();
        }
        public BatchRepo GetAllBatches()
        {
            return GDBC.GetAllBatches();
        }
        public void new_batch(int phase, DateTime start_date, DateTime end_date, int plantId)
        {
            ADBC.NewBatch(phase, start_date, end_date, plantId);
        }
        public List<Picture> GetAllPicturesFromDayId(int dayId)
        {
            return GDBC.GetAllPicturesFromDayId(dayId);
        }
    }
}

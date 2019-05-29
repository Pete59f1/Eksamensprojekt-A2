using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppeA2.Domain;
using System.Data;
using System.Data.SqlClient;

namespace GruppeA2.Application
{
    class GetDBController : DBController
    {

        public PlantTypeRepo GetAllPlantType()
        {
            PlantTypeRepo savedPlantRepo = new PlantTypeRepo();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_GetPlantType", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string plantNr = read["PlantId"].ToString();
                            int plantNumber = int.Parse(plantNr);
                            string plantType = read["Type"].ToString();
                            string phase1 = read["Phase_1"].ToString();
                            string phase2 = read["Phase_2"].ToString();
                            string phase3 = read["Phase_3"].ToString();
                            string phase4 = read["Phase_4"].ToString();

                            PlantType plants = new PlantType(plantNumber, plantType, phase1, phase2, phase3, phase4);
                            savedPlantRepo.AddItem(plants);
                        }
                    }
                    return savedPlantRepo;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            //Lavet test data for at arbejde videre


        }

        public NewPicturesRepo GetPicturesWithNoCommentAndStatus()
        {
            NewPicturesRepo savedPictureRepo = new NewPicturesRepo();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_FindPictureWithNoCommentAndStatus", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string pictureNumber = read["PicId"].ToString();
                            int picNumber = int.Parse(pictureNumber);
                            string name = read["Date"].ToString();
                            DateTime date = DateTime.Parse(name);
                            date.ToString("dd/MM/yyyy HH:mm");
                            string comment = read["Comment"].ToString();
                            PictureStatus status = Picture.ConvertStringStatusToEnumStatus(read["Status"].ToString());
                            string pictureLink = read["PictureLink"].ToString();
                            string tray = read["TrayNr"].ToString();
                            int trayNr = int.Parse(tray);
                            Picture pic = new Picture(picNumber, date, comment, status, pictureLink, trayNr);
                            savedPictureRepo.AddItem(pic);
                        }
                    }
                    return savedPictureRepo;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public BatchRepo GetAllBatches()
        {
            BatchRepo Batches = new BatchRepo();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_GetAllBatches", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string batNr = read["BatchNr"].ToString();
                            int batchNr = int.Parse(batNr);
                            string pha = read["Phase"].ToString();
                            int phase = int.Parse(pha);
                            string sDate = read["StartDate"].ToString();
                            DateTime startDate = DateTime.Parse(sDate);
                            string eDate = read["EndDate"].ToString();
                            DateTime endDate = DateTime.Parse(eDate);
                            string plant = read["PlantId"].ToString();
                            int plantId = int.Parse(plant);
                            Batch batch = new Batch(batchNr, phase, startDate, endDate, plantId);
                            batch.DaysInProduction = GetAllDaysFromBatchNr(batchNr);
                            Batches.AddItem(batch);
                        }
                    }
                    return Batches;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private List<Day> GetAllDaysFromBatchNr(int batchNr)
        {
            List<Day> days = new List<Day>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_GetAllDaysFromBatchId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@BatchNr", batchNr));

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string dId = read["DayId"].ToString();
                            int dayId = int.Parse(dId);
                            string dNr = read["DayNr"].ToString();
                            int dayNr = int.Parse(dNr);
                            string dat = read["Date"].ToString();
                            DateTime date = DateTime.Parse(dat);
                            Day day = new Day(dayId, dayNr, date);
                            days.Add(day);
                        }
                    }
                    return days;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public List<Picture> GetAllPicturesFromDayId(int dayId)
        {
            List<Picture> pictures = new List<Picture>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_GetAllPicturesFromDayId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@DayId", dayId));

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string pId = read["PicId"].ToString();
                            int picId = int.Parse(pId);
                            string dat = read["Date"].ToString();
                            DateTime date = DateTime.Parse(dat);
                            string comment = read["Comment"].ToString();
                            string stat = Picture.ConvertStatusFromDkToEng(read["Status"].ToString());
                            PictureStatus status = Picture.ConvertStringStatusToEnumStatus(stat);
                            string pictureLink = read["PictureLink"].ToString();
                            string traNr = read["TrayNr"].ToString();
                            int trayNr = int.Parse(traNr);
                            Picture picture = new Picture(picId, date, comment, status, pictureLink, trayNr);
                            pictures.Add(picture);
                        }
                    }
                    return pictures;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}

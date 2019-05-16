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
        }

        public Batch GetMostRecentProduction()
        {
            return null;
        }
        public Batch GetSpecificProduction(int productionNumber)
        {
            return null;
        }
        //public PictureRepo GetPictures()
        //{
        //    PictureRepo savedPictureRepo = new PictureRepo();
        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {
        //        try
        //        {
        //            con.Open();

        //            SqlCommand cmd = new SqlCommand("sp_FindAllPicturesWithCommentAndStatus", con);
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlDataReader read = cmd.ExecuteReader();

        //            if (read.HasRows)
        //            {
        //                while (read.Read())
        //                {
        //                    string pictureNumber = read["Pic_Id"].ToString();
        //                    int picNumber = int.Parse(pictureNumber);
        //                    string name = read["Name"].ToString();
        //                    DateTime datetime = DateTime.Parse(name);
        //                    name = datetime.ToString("yyyy-MM-dd HH:mm");
        //                    string comment = read["Comment"].ToString();
        //                    string status = read["Status"].ToString();
        //                    string pictureLink = read["Picture_Link"].ToString();
        //                    //Console.WriteLine("Id: " + id + "| Purchase date: " + date + "| Number of items: " + numberofitems);
        //                    Picture pic = new Picture(picNumber, datetime, comment, status, pictureLink);
        //                    savedPictureRepo.AddItem(pic);
        //                }
        //            }
        //            return savedPictureRepo;
        //        }
        //        catch (SqlException ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //    }
        //}
    }
}

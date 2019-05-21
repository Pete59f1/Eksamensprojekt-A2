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
    class AddDBController : DBController
    {
        public void new_batch(int phase, DateTime start_date, DateTime end_date, int plantId)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    //Create new batch
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_NewBatch", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@phase", phase));
                    cmd.Parameters.Add(new SqlParameter("@startDate", start_date));
                    cmd.Parameters.Add(new SqlParameter("@endDate", end_date));
                    cmd.Parameters.Add(new SqlParameter("@plantId", plantId));
                    cmd.ExecuteNonQuery();


                    //Get the new batch's number
                    int batchNr = 0;

                    cmd = new SqlCommand("sp_GetNewBatchId");
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            string batId = read["BatchNr"].ToString();
                            batchNr = int.Parse(batId);
                        }
                    }


                    //Create the number of days
                    int days = ((TimeSpan)(end_date - start_date)).Days;

                    cmd = new SqlCommand("sp_CreateDay");
                    cmd.CommandType = CommandType.StoredProcedure;

                    for (int i = 0; i < days; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter("@DayNr", i + 1));
                        cmd.Parameters.Add(new SqlParameter("@Date", start_date.AddDays(i)));
                        cmd.Parameters.Add(new SqlParameter("@BatchNr", batchNr));
                        cmd.ExecuteNonQuery();
                    }

                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public void save_picture(string comment, string status,int pictureId)
        {
            using(SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_SavePicture", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PicId", pictureId));
                    cmd.Parameters.Add(new SqlParameter("@Comment", comment));
                    cmd.Parameters.Add(new SqlParameter("@Status", status));

                    cmd.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public void delete_picture(int pictureId)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_DeletePicture", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PicId", pictureId));

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}

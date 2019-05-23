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
        public void NewBatch(int phase, DateTime startDate, DateTime endDate, int plantId)
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
                    cmd.Parameters.Add(new SqlParameter("@startDate", startDate));
                    cmd.Parameters.Add(new SqlParameter("@endDate", endDate));
                    cmd.Parameters.Add(new SqlParameter("@plantId", plantId));
                    cmd.ExecuteNonQuery();


                    //Get the new batch's number
                    
                    int batchNr = 0;

                    cmd = new SqlCommand("sp_GetNewBatchId", con);
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
                    read.Close();


                    //Create the number of days
                    int days = ((TimeSpan)(endDate - startDate)).Days + 1;

                    
                    for (int i = 0; i < days; i++)
                    {
                        cmd = new SqlCommand("sp_CreateDay", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@DayNr", i + 1));
                        cmd.Parameters.Add(new SqlParameter("@Date", startDate.AddDays(i)));
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
        public void SavePicture(string comment, string status,int pictureId)
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
        
    }
}

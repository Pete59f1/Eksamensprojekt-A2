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
    class ChangeDBController : DBController
    {
        
        public void DeletePicture(int pictureId)
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
        public void SavePicture(string comment, string status, int pictureId)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
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
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}

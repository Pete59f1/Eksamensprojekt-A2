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
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_NewBatch", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@phase", phase));
                    cmd.Parameters.Add(new SqlParameter("@startDate", start_date));
                    cmd.Parameters.Add(new SqlParameter("@endDate", end_date));
                    cmd.Parameters.Add(new SqlParameter("@plantId", plantId));
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Application
{
    abstract class DBController
    {
        private string connectionString = "SERVER = ealSQL1.eal.local; Database = A_DB28_2018; User Id = A_STUDENT28; Password = A_OPENDB28;";

        public string ConnectionString { get { return connectionString; } private set { connectionString = value; } }
    }
}

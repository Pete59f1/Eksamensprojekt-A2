using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    abstract class DBController
    {
        private string connectionString = "Bla";

        public string ConnectionString { get { return connectionString; } private set { connectionString = value; } }
    }
}

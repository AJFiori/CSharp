using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DailyCensusReport
{
    class DBConnect
    {
        public static SqlConnection GetConnection()
        {

            string connectionString =
                "Data Source=sql.neit.edu;Initial Catalog=SE265_AJF1130;User ID=001246352  ;Password= 02272014";
            SqlConnection connect = new SqlConnection(connectionString);
            return connect;
        }
    }
}

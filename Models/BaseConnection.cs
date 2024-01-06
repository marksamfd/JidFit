using Microsoft.AspNetCore.Http;
using System.Data;
using System.Data.SqlClient;

namespace JidFit.Models
{
    public class BaseConnection
    {
        string ConString;
        protected SqlConnection con;
        public BaseConnection()
        {
            ConString = "Data Source=DESKTOP-TDPGBSC\\MSSQLSERVER2;Initial Catalog=JidFit;Integrated Security=True";
            con = new SqlConnection(ConString);
            // use conn in the other files
        }
    }
}

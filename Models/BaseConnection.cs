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
            ConString = "Data Source=DESKTOP-PFKM237\\SQLEXPRESS;Initial Catalog=COMPANYDB;Integrated Security=True";
            con = new SqlConnection(ConString);
        }
    }
}

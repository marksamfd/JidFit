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
            ConString = "Data Source=MARK-PC\\SQLEXPRESS;Initial Catalog=jidfit;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection(ConString);
            // use conn in the other files
        }
    }
}

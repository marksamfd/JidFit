using System.Data;
using System.Data.SqlClient;

namespace JidFit.Models
{
    public class Payment : BaseConnection
    {
        public Payment()
        {
        }
        public DataTable getCurrentSubscription(string email, int month)
        {
            Console.WriteLine(email);
            DataTable dt = new DataTable();
            string query = "select user_name,u.user_email from payment p left join users u on p.user_email = u.user_email where MONTH(p.day) = @month and p.coach_email = @cemail";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("cemail", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("month", SqlDbType.Int).Value = month;
            try
            {
                con.Open();
                dt.Load(cmd.ExecuteReader());

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}

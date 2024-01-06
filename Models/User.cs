using System.Data;
using System.Data.SqlClient;

namespace JidFit.Models
{
	public class User : BaseConnection
	{
		public User() { }

		public DataTable getUserDetails(string user)
		{
			DataTable dt = new DataTable();
			string query = "SELECT * FROM users WHERE user_email = @user";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.Add("user", SqlDbType.VarChar).Value = user;
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
		public DataTable getProblems(string user)
		{
			DataTable dt = new DataTable();
			string query = "SELECT * FROM has_problems WHERE user_email = @user";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.Add("user", SqlDbType.VarChar).Value = user;
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
		public DataTable getPlates(string user)
		{
			DataTable dt = new DataTable();
			string query = "SELECT * FROM assign_plate ap left join plates p on p.plate_name = ap.plate_name WHERE user_email = @user order by meal_type";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.Add("user", SqlDbType.VarChar).Value = user;
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
        public DataTable getexercise(string user)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM assigned_exercise ap left join exercise p on p.exersice_name = ap.exersice_name WHERE user_email = @user ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("user", SqlDbType.VarChar).Value = user;
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

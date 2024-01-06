using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
namespace JidFit.Models
{
	[BindProperties(SupportsGet = true)]
	public class CoachNutritionist : BaseConnection
    {
        public enum UType
        {
            COACH,
            NUTRITIONIST
        }
        public string name { get; set; }
        public UType role { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public CoachNutritionist()
        {
            email = "";
            name = "";
            password = "";

        }
        public CoachNutritionist(string email, string name, string password, UType role)
        {
            this.email = email;
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public DataTable getCoachOrNutritionist()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM coach_or_nut";
            SqlCommand cmd = new SqlCommand(query, con);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public void insertCoachOrNutritionist(coachNutritionistModal m)
        {
            string query = "INSERT INTO coach_or_nut (coach_email, coach_name, password, role) VALUES (@email, @name, @password, @role)";
            SqlCommand cmd = new SqlCommand(query, con);
			cmd.Parameters.Add("name", SqlDbType.VarChar).Value = m.name;
			cmd.Parameters.Add("role", SqlDbType.Char).Value = m.role;
			cmd.Parameters.Add("password", SqlDbType.VarChar).Value = m.password;
			cmd.Parameters.Add("email", SqlDbType.VarChar).Value = m.email;

            try
            {
				con.Open();
				cmd.ExecuteNonQuery();
			}
			catch (SqlException e)
            {
				Console.WriteLine(e.Message);
			}
			finally
            {
				con.Close();
			}
        }

        public bool login(string email, string pass)
        {
            string query = "SELECT password FROM coach_or_nut WHERE coach_email = @email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = email;
            try
            {
				con.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
                {
					if (reader.GetString(0) == pass)
                    {
						return true;
					}
				}
			}
			catch (SqlException e)
            {
				Console.WriteLine(e.Message);
			}
			finally
            {
				con.Close();
			}
            return false;
        }
        
    }
}

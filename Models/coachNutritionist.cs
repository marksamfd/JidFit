using Microsoft.AspNetCore.Http;
using System.Data;
using System.Data.SqlClient;
namespace JidFit.Models
{
    public class coachNutritionist : BaseConnection
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

        public coachNutritionist()
        {
            email = "";
            name = "";
            password = "";

        }
        public coachNutritionist(string email, string name, string password, UType role)
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
        public void insertCoachOrNutritionist()
        {
            string query = "INSERT INTO coach_or_nut (coach_email, coach_name, password, role) VALUES ('@email', '@name', '@password', '@role')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        
    }
}

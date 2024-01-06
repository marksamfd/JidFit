using Microsoft.AspNetCore.Http;
using System.Data;
using System.Data.SqlClient;

namespace JidFit.Models
{
    public class useres : BaseConnection
    {
        public enum GenderType
        {
            Male,
            Female
        }

        public string Email { get; set; }
        public decimal? Weight { get; set; }
        public DateTime? Birthdate { get; set; }
        public string UserName { get; set; }
        public bool? Gender { get; set; }
        public int? Target { get; set; }
        public string Password { get; set; }
        public decimal? Height { get; set; }

        public useres()
        {
            Email = "";
            Weight = null;
            Birthdate = null;
            UserName = "";
            Gender = null;
            Target = null;
            Password = "";
            Height = null;
        }

        public useres(string email, decimal? weight, DateTime? birthdate, string userName, bool? gender, int? target, string password, decimal? height)
        {
            Email = email;
            Weight = weight;
            Birthdate = birthdate;
            UserName = userName;
            Gender = gender;
            Target = target;
            Password = password;
            Height = height;
        }

        public DataTable GetUsers()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM users";
            SqlCommand cmd = new SqlCommand(query, con);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public void InsertUser()
        {
            string query = "INSERT INTO users (user_email, weight, birthdate, user_name, gender, target, password, height) " +
                           "VALUES ('@email', @weight, @birthdate, '@userName', @gender, @target, '@password', @height)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@weight", Weight ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@birthdate", Birthdate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@userName", UserName);
            cmd.Parameters.AddWithValue("@gender", Gender ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@target", Target ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@height", Height ?? (object)DBNull.Value);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

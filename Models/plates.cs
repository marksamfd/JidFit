using Microsoft.AspNetCore.Http;
using System.Data;
using System.Data.SqlClient;

namespace JidFit.Models
{
    public class Plate : BaseConnection
    {
        public string PlateName { get; set; }
        public int? Amount { get; set; }
        public string Unit { get; set; }
        public decimal? Protein { get; set; }
        public decimal? Fat { get; set; }
        public decimal? Carbs { get; set; }
        public decimal? Calories { get; set; }

        public Plate()
        {
            PlateName = "";
            Amount = null;
            Unit = "";
            Protein = null;
            Fat = null;
            Carbs = null;
            Calories = null;
        }

        public Plate(string plateName, int? amount, string unit, decimal? protein, decimal? fat, decimal? carbs, decimal? calories)
        {
            PlateName = plateName;
            Amount = amount;
            Unit = unit;
            Protein = protein;
            Fat = fat;
            Carbs = carbs;
            Calories = calories;
        }

        public DataTable GetPlates()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM plates";
            SqlCommand cmd = new SqlCommand(query, con);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public void InsertPlate()
        {
            string query = "INSERT INTO plates (plate_name, amount, unit, protien, fat, carbs, calories) " +
                           "VALUES ('@plateName', @amount, '@unit', @protein, @fat, @carbs, @calories)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@plateName", PlateName);
            cmd.Parameters.AddWithValue("@amount", Amount ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@unit", Unit);
            cmd.Parameters.AddWithValue("@protein", Protein ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@fat", Fat ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@carbs", Carbs ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@calories", Calories ?? (object)DBNull.Value);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
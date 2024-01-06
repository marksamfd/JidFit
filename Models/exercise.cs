using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace JidFit.Models
{
    [BindProperties(SupportsGet = true)]
    public class Exercise : BaseConnection
    {
        public string ExerciseName { get; set; }
        public string TargetMuscle { get; set; }
        public string IllustrationLink { get; set; }

        public Exercise()
        {
            ExerciseName = "";
            TargetMuscle = "";
            IllustrationLink = "";
        }

        public Exercise(string exerciseName, string targetMuscle, string illustrationLink)
        {
            ExerciseName = exerciseName;
            TargetMuscle = targetMuscle;
            IllustrationLink = illustrationLink;
        }

        public DataTable GetExercises()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM exercise";
            SqlCommand cmd = new SqlCommand(query, con);
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public void InsertExercise()
        {
            string query = "INSERT INTO exercise (exercise_name, target_muscle, illust_link) " +
                           "VALUES ('@exerciseName', '@targetMuscle', '@illustrationLink')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@exerciseName", ExerciseName);
            cmd.Parameters.AddWithValue("@targetMuscle", TargetMuscle);
            cmd.Parameters.AddWithValue("@illustrationLink", IllustrationLink);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
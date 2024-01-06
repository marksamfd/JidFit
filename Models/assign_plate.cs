using System.Data;
using System.Data.SqlClient;
namespace JidFit.Models
{
	public class assign_plate: BaseConnection
	{
		public string user_email { get; set; }
		public string plate_name { get; set; }
		public int meal_type { get; set; }
		public int day { get; set; }
		public int serving_amount { get; set; }

		public assign_plate()
		{
			user_email = "";
			plate_name = "";
			meal_type = 0;
			day = 0;
			serving_amount = 0;

		}	
		public assign_plate(string user_email, string plate_name, int meal_type, int day, int serving_amount)
		{
			this.user_email = user_email;
			this.plate_name = plate_name;
			this.meal_type = meal_type;
			this.day = day;
			this.serving_amount = serving_amount;
		}

		public DataTable getAssignPlate()
		{
			DataTable dt = new DataTable();
			string query = "SELECT * FROM assign_plate";
			SqlCommand cmd = new SqlCommand(query, con);
			dt.Load(cmd.ExecuteReader());
			return dt;
		}
	}
}

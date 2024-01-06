using Microsoft.AspNetCore.Mvc;

namespace JidFit.Models
{
	[BindProperties(SupportsGet = true)]	
	public class coachNutritionistModal
	{
        public string name { get; set; }
		public string email { get; set; }
		public string password { get; set; }
		public string role { get; set; }
    }
}

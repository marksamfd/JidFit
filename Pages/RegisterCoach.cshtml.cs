using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JidFit.Models;

namespace JidFit.Pages
{
	[BindProperties(SupportsGet = true)]
	public class RegisterCoachModel : PageModel
	{
		private readonly ILogger<RegisterCoachModel> _logger;
		public CoachNutritionist db;
        public coachNutritionistModal m { get; set; }
        public RegisterCoachModel(ILogger<RegisterCoachModel> logger, CoachNutritionist db)
		{
			_logger = logger;
			this.db = db;
		}
		public void OnGet()
		{

		}
		public void OnPost()
		{
			/*Console.WriteLine(m.name);
			Console.WriteLine(m.password);
			Console.WriteLine(m.email);
			Console.WriteLine(m.role);*/
			db.insertCoachOrNutritionist(m);
		}
	}
}

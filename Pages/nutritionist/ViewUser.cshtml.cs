using JidFit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace JidFit.Pages.nutritionist
{
	[BindProperties(SupportsGet = true)]
	public class ViewUserModel : PageModel
	{
		public DataTable dt { get; set; }
		public DataTable prob { get; set; }
		public DataTable plates { get; set; }
		public User db;
        public string admin { get; set; }
        public string user { get; set; }
        [BindProperty]
		public string chartLabels { get; set; }
		[BindProperty]
		public string userData { get; set; }
		[BindProperty]
		public string plansData { get; set; }
		public ViewUserModel(User _db) {
			db = _db;
		}
        public void OnGet()
		{
			
			dt = db.getUserDetails(user);
			prob = db.getProblems(user);
			plates = db.getPlates(user);
			chartLabels = "January,February,March,April, May, June, July";
			userData = "65, 59, 80, 81, 56, 55, 40";
			plansData = "60, 51, 79, 70, 20, 20, 4";	
		}
		public void OnPost()
		{

		}
	}
}

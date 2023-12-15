using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JidFit.Pages.nutritionist
{
	public class ViewUserModel : PageModel
	{
		[BindProperty]
		public string chartLabels { get; set; }
		[BindProperty]
		public string userData { get; set; }
		[BindProperty]
		public string plansData { get; set; }
        public void OnGet()
		{
			chartLabels = "January,February,March,April, May, June, July";
			userData = "65, 59, 80, 81, 56, 55, 40";
			plansData = "60, 51, 79, 70, 20, 20, 4";	
		}
	}
}

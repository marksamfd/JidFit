using JidFit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JidFit.Pages
{
    [BindProperties(SupportsGet = true)]
    public class login_Model : PageModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public CoachNutritionist db;
        public login_Model(CoachNutritionist _db)
        {
            db = _db;
		}
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(db.login(email, password))
            {
                return RedirectToPage("/nutritionist/ViewUsers", new { admin = email });
			}
			else
            {
				return RedirectToPage("login-coach");
			}
        }
    }
}

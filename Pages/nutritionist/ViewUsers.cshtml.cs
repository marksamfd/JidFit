using JidFit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace JidFit.Pages.nutritionist
{
    [BindProperties(SupportsGet = true)]
    public class ViewUsersModel : PageModel
    {
        public DataTable dt;
        public Payment db;
        public string admin { get; set; }
        public ViewUsersModel(Payment _db) { 
        
            db = _db;
        }

        public void OnGet()
        {
            dt = db.getCurrentSubscription(admin, Convert.ToInt32(DateTime.Now.ToString("MM")));
        }
    }
}

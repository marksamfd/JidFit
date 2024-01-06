using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JidFit.Models;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;

namespace JidFit.Pages.coach
{
 
    [BindProperties(SupportsGet = true)]
    public class CoachNutritionistModel
    {
        private readonly ILogger<CoachRegistrationModel> _logger;
        public coachNutritionist db;
        public CoachRegistrationModel m { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public string role { get; set; }
    }
    public class CoachRegistrationModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost()
        {
            db.insertCoachOrNutritionist(m);
        }
   
    }
}

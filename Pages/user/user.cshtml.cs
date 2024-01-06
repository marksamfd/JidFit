using JidFit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JidFit.Pages.useres
{
    public class useresModel : PageModel

    {
        private readonly ILogger<useresModel> _logger;
        public useresModel db;
        public useresModel m { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {

        }
    }
}

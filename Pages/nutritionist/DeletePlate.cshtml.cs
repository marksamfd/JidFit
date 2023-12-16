using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JidFit.Pages.nutritionist
{
    public class DeletePlateModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public string email { get; set; }
		[BindProperty(SupportsGet = true)]
		public string plateName{ get; set; }
		[BindProperty(SupportsGet = true)]
		public string meal{ get; set; }
		[BindProperty(SupportsGet = true)]
		public int day{ get; set; }
        public void OnGet()
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternat_Library.Models;

namespace Bookings
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Booking Item { get; set; }

        public void OnGet() => Item = new();

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            // TODO: Save item
            return RedirectToPage("./Index");
        }
    }
}

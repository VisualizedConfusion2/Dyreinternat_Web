using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternat_Library.Models;
using System.Collections.Generic;

namespace Bookings
{
    public class IndexModel : PageModel
    {
        public List<Booking> Items { get; set; } = new();

        public void OnGet()
        {
            // TODO: Load from service or repo
        }
    }
}

using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternat_Library.Models;
using System.Collections.Generic;

namespace DoctorVisits
{
    public class IndexModel : PageModel
    {
        public List<DoctorVisit> Items { get; set; } = new();

        public void OnGet()
        {
            // TODO: Load from service or repo
        }
    }
}

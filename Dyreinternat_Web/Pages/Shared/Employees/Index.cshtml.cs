using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternat_Library.Models;
using System.Collections.Generic;

namespace Employees
{
    public class IndexModel : PageModel
    {
        public List<Employee> Items { get; set; } = new();

        public void OnGet()
        {
            // TODO: Load from service or repo
        }
    }
}

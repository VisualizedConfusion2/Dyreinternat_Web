using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternat_Library.Models;
using System.Collections.Generic;

namespace Blogs
{
    public class IndexModel : PageModel
    {
        public List<Blog> Items { get; set; } = new();

        public void OnGet()
        {
            // TODO: Load from service or repo
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Deneme.EFCORE;

namespace RazorPages.Deneme.Pages.Shared
{
    public class GaleriModel : PageModel
    {
        public DenemeDbContext context = new();

        public void OnGet()
        {
        }
    }
}

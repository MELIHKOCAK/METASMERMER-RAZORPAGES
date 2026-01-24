using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Deneme.EFCORE;

namespace RazorPages.Deneme.Pages.Admin
{
    public class HeaderModel : PageModel
    {
        public DenemeDbContext context = new();

        [BindProperty]
        public string _Title { get; set; }

        [BindProperty]
        public string _Desc { get; set; }

        public void OnGet()
        {
        }

        public void OnPostUpdateService()
        {
            var services = context.Services.FirstOrDefault();
            services.Title = _Title;
            services.Desc = _Desc;
            context.SaveChanges();
            RedirectToPage();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Deneme.EFCORE;

namespace RazorPages.Deneme.Pages.Admin
{
    public class HeroModel : PageModel
    {
        public DenemeDbContext context = new();

        [BindProperty]
        public string _CompanyName { get; set; }

        public void OnPostUpdateCompanyName()
        {
            var companyName = context.Heros.FirstOrDefault();
            companyName.CompanyName = _CompanyName;
            context.SaveChanges();
            RedirectToPage();
        }

        public void OnGet()
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using RazorPages.Deneme.EFCORE;

namespace RazorPages.Deneme.Pages.Admin
{
    public class FooterModel : PageModel
    {
        public DenemeDbContext context = new();
        
        [BindProperty]
        public string _NewFacebookLink { get; set; }

        [BindProperty]
        public string _NewInstagramLink { get; set; }

        public void OnGet()
        {
        }

        public void OnPostUpdateFooter()
        {
            var footer = context.Footer.FirstOrDefault();
            footer.FacebookLink = _NewFacebookLink;
            footer.InstagramLink = _NewInstagramLink;
            context.SaveChanges();
            RedirectToPage();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Deneme.EFCORE;

namespace RazorPages.Deneme.Pages.Admin
{
    public class WhatsappModel : PageModel
    {
        public DenemeDbContext context = new();

        [BindProperty]
        public string _NewWhatsappTitle { get; set; }
        [BindProperty]
        public string _NewWhatsappDescription { get; set; }
        [BindProperty]
        public string _NewWhatsappPhoneNumber { get; set; }

        public void OnGet()
        {
        }

        public void OnPostUpdateWhatsapp()
        {
            var whatsapp = context.Whatsapp.FirstOrDefault();
            whatsapp.Title = _NewWhatsappTitle;
            whatsapp.Desc = _NewWhatsappDescription;
            whatsapp.PhoneNumber = _NewWhatsappPhoneNumber;
            context.SaveChanges();
            RedirectToPage();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Deneme.EFCORE;

namespace RazorPages.Deneme.Pages.Admin
{
    public class ContactModel : PageModel
    {
        public DenemeDbContext context = new();

        [BindProperty]
        public string _NewFirstNumber { get; set; }
        
        [BindProperty]
        public string _NewSecondNumber { get; set; }
        
        [BindProperty]
        public string _NewEmailAddress { get; set; }
        
        [BindProperty]
        public string _NewMapLink { get; set; }
        
        [BindProperty]
        public string _NewCompanyAddress { get; set; }
        
        [BindProperty]
        public string _NewMapEmbedLink { get; set; }

        public void OnGet()
        {
        }

        public void OnPostUpdateContact()
        {
            var contact = context.Contact;
            contact.Find(1).Value = _NewFirstNumber;
            contact.Find(2).Value = _NewSecondNumber;
            contact.Find(3).Value = _NewEmailAddress;
            contact.Find(4).Value = _NewMapLink;
            contact.Find(5).Value = _NewCompanyAddress;
            contact.Find(6).Value = _NewMapEmbedLink;

            context.SaveChanges();
        }
    }
}

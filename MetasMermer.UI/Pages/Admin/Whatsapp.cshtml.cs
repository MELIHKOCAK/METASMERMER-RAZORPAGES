using MetasMermer.Services.Whatsapps;
using MetasMermer.Services.Whatsapps.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetasMermer.UI.Pages.Admin
{
    public class WhatsappModel(IWhatsappService _service) : PageModel
    {
        [BindProperty]
        public UpdateWhatsappDto UpdateWhatsappDto { get; set; }

        internal WhatsappDto _whatsappDto { get; set; }
        public async Task OnGetAsync()
        {
            _whatsappDto = await _service.GetByIdAsync(1);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            UpdateWhatsappDto.Id = 1;
            await _service.Update(UpdateWhatsappDto);
            return RedirectToPage();
        }
    }
}

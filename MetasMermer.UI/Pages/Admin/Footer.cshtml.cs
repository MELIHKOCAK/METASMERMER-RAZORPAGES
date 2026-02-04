using Mapster;
using MetasMermer.Services.Footers;
using MetasMermer.Services.Footers.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetasMermer.UI.Pages.Admin
{
    public class FooterModel(IFooterService _service) : PageModel
    {
        [BindProperty]
        public UpdateFooterDto UpdateFooterDto { get; set; } = new();
        internal FooterDto _footerDto { get; set; }

        public async Task OnGetAsync()
        {
            _footerDto = await _service.GetByIdAsync(1);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            UpdateFooterDto.Id = 1;
            await _service.Update(UpdateFooterDto);
            return RedirectToPage();
        }
    }
}

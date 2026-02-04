using MetasMermer.Services.Abouts;
using MetasMermer.Services.Abouts.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetasMermer.UI.Pages.Admin
{
    public class AboutModel(IAboutService _service) : PageModel
    {
        [BindProperty]
        public UpdateAboutDto UpdateAboutDto { get; set; }
        internal AboutDto _aboutDto { get; set; } = default!;

        public async Task OnGetAsync()
        {
            _aboutDto = await _service.GetByIdAsync(1);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            UpdateAboutDto.Id = 1;
            await _service.Update(UpdateAboutDto);
            return RedirectToPage();
        }
    }
}

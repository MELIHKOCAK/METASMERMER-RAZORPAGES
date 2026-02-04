using MetasMermer.Services.Heroes;
using MetasMermer.Services.Heroes.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetasMermer.UI.Pages.Admin
{
    public class HeroModel(IHeroService _service) : PageModel
    {
        internal HeroDto _Hero { get; set; } = default!;

        [BindProperty]
        public UpdateHeroDto Hero { get; set; } = new();
        public async Task OnGetAsync()
        {
            _Hero = await _service.GetByIdAsync(1);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Hero.Id = 1;
            await _service.Update(Hero);
            return RedirectToPage();
        }
    }
}

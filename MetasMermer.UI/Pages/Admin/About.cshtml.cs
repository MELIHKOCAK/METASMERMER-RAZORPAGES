using MetasMermer.Services.Abouts;
using MetasMermer.Services.Abouts.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MetasMermer.UI.Pages.Admin
{
    public class AboutModel(IAboutService _service) : PageModel
    {
        [BindProperty]
        public UpdateAboutDto UpdateAboutDto { get; set; }
        [BindProperty]
        public string SelectedImage { get; set; }

        public List<SelectListItem> ImageList = new();

        internal AboutDto _aboutDto { get; set; } = default!;

        public async Task OnGetAsync()
        {
            _aboutDto = await _service.GetByIdAsync(1);
            await Help();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            UpdateAboutDto.Id = 1;
            await Help();
            await _service.Update(UpdateAboutDto, SelectedImage, ImageList);
            return RedirectToPage();
        }

        private async Task Help()
        {
            _aboutDto = await _service.GetByIdAsync(1);

            int i = 0;
            foreach (var item in _aboutDto.ImageLink)
            {
                ImageList.Add(new SelectListItem { Text = _aboutDto.ImageLink[i], Value = $"{i}" });
                i++;
            }
        }

    }
}

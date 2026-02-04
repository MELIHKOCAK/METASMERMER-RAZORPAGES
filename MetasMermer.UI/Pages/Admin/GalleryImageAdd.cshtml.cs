using MetasMermer.Repositories.EFCORE.Galleries;
using MetasMermer.Services.Galleries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetasMermer.UI.Pages.Admin
{
    public class GalleryImageAddModel(IGalleryService _service) : PageModel
    {
        [BindProperty]
        public IFormFile Photo { get; set; }
        public string UploadedPath { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Photo == null || Photo.Length == 0) //Fast Fail Yaklaþýmý
                return Page();

            UploadedPath = await _service.Add(Photo);
            TempData["UploadedPath"] = UploadedPath;
            return RedirectToPage();
        }
    }
}

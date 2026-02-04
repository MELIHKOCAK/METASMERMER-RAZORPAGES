using MetasMermer.Services.Galleries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetasMermer.UI.Pages.Admin
{
    public class GalleryImageDeleteModel(IGalleryService _service) : PageModel
    {
        public List<GalleryDto> GalleryList { get; set; }

        [BindProperty]
        public List<int> SelectedPhotoIds { get; set; }
        public async Task OnGetAsync()
        {
            GalleryList = await _service.GetAll();
        }

        public async Task<IActionResult> OnPostDeletePhotoAsync()
        {
            await _service.Delete(SelectedPhotoIds);
            return RedirectToPage();
        }
    }
}

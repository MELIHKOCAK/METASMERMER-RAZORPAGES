using MetasMermer.Services.Galleries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetasMermer.UI.Pages
{
    public class GalleryModel(IGalleryService _service) : PageModel
    {
        public List<GalleryDto> galleryDtos { get; set; }
        public async Task OnGetAsync()
        {
           galleryDtos = await _service.GetAll();
        }
    }
}

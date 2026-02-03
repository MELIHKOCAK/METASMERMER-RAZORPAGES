using MetasMermer.Services.Galleries;
using Microsoft.AspNetCore.Mvc;

namespace MetasMermer.UI.Pages.Shared.Components.Lightbox;

public class LightboxViewComponent(IGalleryService _service):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var gallery = await _service.GetAll();
        return View("Default", gallery);
    }
}

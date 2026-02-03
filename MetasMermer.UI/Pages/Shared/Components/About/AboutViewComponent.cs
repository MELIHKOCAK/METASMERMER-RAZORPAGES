using MetasMermer.Services.Abouts;
using Microsoft.AspNetCore.Mvc;

namespace MetasMermer.UI.Pages.Shared.Components.About;

[ViewComponent(Name ="about")]
public class AboutViewComponent(IAboutService _service):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var about = await _service.GetByIdAsync(1);
        return View("Default", about);
    }
}

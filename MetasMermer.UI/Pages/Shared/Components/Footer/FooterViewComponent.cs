using MetasMermer.Services.Footers;
using Microsoft.AspNetCore.Mvc;

namespace MetasMermer.UI.Pages.Shared.Components.Footer;

public class FooterViewComponent(IFooterService _service) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var footer = await _service.GetByIdAsync(1)!;
        return View("Default", footer);
    }
}

using MetasMermer.Services.Whatsapps;
using Microsoft.AspNetCore.Mvc;

namespace MetasMermer.UI.Pages.Shared.Components.Whatsapp;

public class WhatsappViewComponent(IWhatsappService _service) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var whatsapp = await _service.GetByIdAsync(1)!;
        return View("Default", whatsapp);
    }
}

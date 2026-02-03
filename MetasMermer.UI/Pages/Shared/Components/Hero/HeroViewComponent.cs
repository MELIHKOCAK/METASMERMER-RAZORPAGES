using MetasMermer.Services.Heroes;
using Microsoft.AspNetCore.Mvc;

namespace MetasMermer.UI.Pages.Shared.Components.Hero;

[ViewComponent(Name = "hero")]
public class HeroViewComponent(IHeroService _service):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var hero = await _service.GetByIdAsync(1);
        return View("Default", hero);
    } 
}

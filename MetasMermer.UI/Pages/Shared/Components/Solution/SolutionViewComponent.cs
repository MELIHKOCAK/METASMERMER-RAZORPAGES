using MetasMermer.Services.Solutions;
using Microsoft.AspNetCore.Mvc;

namespace MetasMermer.UI.Pages.Shared.Components.Solution;

[ViewComponent(Name = "solution")]
public class SolutionViewComponent(ISolutionService _service):ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var solution = await _service.GetByIdAsync(1)!;
        return View("Default", solution);
    }
}

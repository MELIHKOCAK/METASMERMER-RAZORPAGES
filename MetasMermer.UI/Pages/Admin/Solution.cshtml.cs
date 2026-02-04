using MetasMermer.Services.Solutions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetasMermer.UI.Pages.Admin
{
    public class SolutionModel(ISolutionService _service) : PageModel
    {
        [BindProperty]
        public UpdateSolutionDto UpdateSolutionDto { get; set; }
        internal SolutionDto _solutionDto { get; set; }

        public async Task OnGetAsync() => _solutionDto = await _service.GetByIdAsync(1);

        public async Task<IActionResult> OnPostAsync()
        {
            UpdateSolutionDto.Id = 1;
            await _service.Update(UpdateSolutionDto);
            return RedirectToPage();
        }
    }
}

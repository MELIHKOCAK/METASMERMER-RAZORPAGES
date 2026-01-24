using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Deneme.EFCORE;

namespace RazorPages.Deneme.Pages
{
    public class IndexModel : PageModel
    {
        public DenemeDbContext context = new();
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
    }
}

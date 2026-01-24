using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Deneme.EFCORE;

namespace RazorPages.Deneme.Pages.Admin
{
    public class GalleryImageAddModel : PageModel
    {
        public DenemeDbContext context = new();

        [BindProperty]
        public IFormFile Photo { get; set; }

        public string UploadedPath { get; set; }

        private readonly IWebHostEnvironment _env;
        
        public GalleryImageAddModel(IWebHostEnvironment env)
        {
            _env = env;
        }
        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (Photo == null || Photo.Length == 0)
                return Page();

            // Güvenli dosya adý
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(Photo.FileName)}";

            var uploadFolder = Path.Combine(_env.WebRootPath, "img/gallery");

            if (!Directory.Exists(uploadFolder))
                Directory.CreateDirectory(uploadFolder);

            var filePath = Path.Combine(uploadFolder, fileName);

            using var stream = new FileStream(filePath, FileMode.Create);
            await Photo.CopyToAsync(stream);

            UploadedPath = "/img/gallery/" + fileName;

            Gallery dummy = new Gallery()
            {
                ImageLink = "/img/gallery/" + fileName
            };
            context.Galleries.Add(dummy);
            context.SaveChanges();
            TempData["UploadedPath"] = "/img/gallery/" + fileName;
            return RedirectToPage();
        }
    }
}

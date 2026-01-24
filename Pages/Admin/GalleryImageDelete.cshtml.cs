using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Deneme.EFCORE;

namespace RazorPages.Deneme.Pages.Admin
{
    public class GalleryModel : PageModel
    {
        public DenemeDbContext context = new();

        public List<Gallery> Photos { get; set; }

        // Seçilen checkbox Id'leri
        [BindProperty]
        public List<int> SelectedPhotoIds { get; set; }

        private readonly IWebHostEnvironment _env;

        public GalleryModel(IWebHostEnvironment env)
        {
            _env = env;
        }



        public void OnGet()
        {
        }

        private void LoadPhotos()
        {
            Photos = GetPhotosFromDb();
        }

        public void OnPostDeletePhoto()
        {
            // Checkboxlar boþsa
            if (SelectedPhotoIds == null || !SelectedPhotoIds.Any())
                return;

            foreach (var id in SelectedPhotoIds)
            {
                var photo = GetPhotoFromDb(id); // DB'den çek

                if (photo != null)
                {
                    DeletePhotoFromDb(id); // DB'den sil
                }
            }

            RedirectToPage();
        }

        private List<Gallery> GetPhotosFromDb()
        {
            return context.Galleries.ToList();
        }

        private Gallery GetPhotoFromDb(int id)
        {
            return context.Galleries.Find(id)!;
        }
        private void DeletePhotoFromDb(int id)
        {
            var dummy = context.Galleries.Find(id);
            context.Galleries.Remove(dummy);
            context.SaveChanges();
        }
    }
}

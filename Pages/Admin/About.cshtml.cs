using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPages.Deneme.EFCORE;

namespace RazorPages.Deneme.Pages.Admin
{
    public class AboutModel : PageModel
    {
       public DenemeDbContext context = new();

        [BindProperty]
        public string SelectedImage { get; set; }

        [BindProperty]
        public string _NewTitle { get; set; }

        [BindProperty]
        public string _NewDesc { get; set; }

        public List<SelectListItem> ImageList = new();

        public void OnGet()
        {
            int i = 0;
            foreach (var item in context.AboutDetails)
            {
                ImageList.Add(new SelectListItem{ Text = item.ImageLink, Value = $"{i}" });
                i++;
            }
        }

        public void OnPostUpdateAbout()
        {
            int i = 0;
            foreach (var item in context.AboutDetails)
            {
                ImageList.Add(new SelectListItem { Text = item.ImageLink, Value = $"{i}" });
                i++;
            }
            var about= context.About.FirstOrDefault();
            about.Desc = _NewDesc;
            about.Title = _NewTitle;
            about.ImageLink = ImageList[Convert.ToInt32(SelectedImage)].Text;
            context.SaveChanges();

        }
    }
}

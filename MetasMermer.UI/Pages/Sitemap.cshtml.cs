using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace MetasMermer.UI.Pages
{
    public class SitemapModel : PageModel
    {
        public IActionResult OnGet()
        {
            // 1. Site adresini dinamik alalým
            var baseUrl = $"{Request.Scheme}://{Request.Host}";

            // 2. XML yapýsýný oluþturmaya baþlayalým
            var sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            sb.AppendLine("<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">");

            // --- SABÝT SAYFALAR ---
            sb.AppendLine($"<url><loc>{baseUrl}/</loc><lastmod>{DateTime.Now:yyyy-MM-dd}</lastmod><priority>1.0</priority></url>");
            sb.AppendLine($"<url><loc>{baseUrl}/gallery</loc><lastmod>{DateTime.Now:yyyy-MM-dd}</lastmod><priority>0.8</priority></url>");

            // !!! EKSÝK OLAN KISIM BURASIYDI !!!
            // Açtýðýmýz <urlset> etiketini kapatýyoruz:
            sb.AppendLine("</urlset>");

            return Content(sb.ToString(), "application/xml", Encoding.UTF8);
        }
    }
}
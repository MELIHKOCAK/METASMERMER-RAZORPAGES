using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Deneme.EFCORE;
using System.Security.Claims;

namespace RazorPages.Deneme.Pages.Admin
{
    public class IndexModel : PageModel
    {
        public DenemeDbContext context = new();

        public void OnGet()
        {
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            // 1️⃣ Kullanıcıyı DB'den bul
            var user = context.Users
                .FirstOrDefault(u => u.Username == Username && u.Password == Password);

            if (user == null)
                return Page();

            // 2️⃣ Claims oluştur (kimlik kartı)
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Username)
        };

            // 3️⃣ Admin ise ROLE ekle
            if (user.IsAdmin)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            }

            // 4️⃣ Kimlik oluştur
            var identity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            var principal = new ClaimsPrincipal(identity);

            // 5️⃣ Giriş yap (cookie yazılır)
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal
            );

            return RedirectToPage("/Admin/Dashboard");
        }
    }
}

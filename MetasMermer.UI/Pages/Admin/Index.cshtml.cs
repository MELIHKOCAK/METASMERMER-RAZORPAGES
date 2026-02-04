using MetasMermer.Services.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MetasMermer.UI.Pages.Admin
{
    public class IndexModel(IUserService _service) : PageModel
    {
        [BindProperty]
        public UserDto User { get; set; }

        private UserDto _User { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // 1️⃣ Kullanıcıyı DB'den bul
            _User = await _service.GetByIdAsync(1);

            if (_User is null || _User.UserName != User.UserName || _User.Password != User.Password)//Fast Fail Yaklaşımı
                return Page();


            //Claims oluştur (kimlik kartı)
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _User.UserName)
            };

            // Admin ise ROLE ekle
            if (_User.IsAdmin)
                claims.Add(new Claim(ClaimTypes.Role, "Admin"));

            // Kimlik oluştur
            var identity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            var principal = new ClaimsPrincipal(identity);

            //Giriş yap
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal
            );

            return RedirectToPage("/Admin/Dashboard");

        }
    }
}




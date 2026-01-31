using FluentValidation;
using System.Linq.Expressions;
namespace MetasMermer.Services.Abouts;

public class AboutDtoValidator: AbstractValidator<AboutDto>
{
    public AboutDtoValidator()
    {
        /*
         
         page modelde kullanımı 

        public class IndexModel : PageModel
{
    [BindProperty]
    public AboutDto AboutData { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) 
        {
            // Eğer AboutDto içindeki herhangi bir string alan boşsa 
            // burası 'false' dönecek ve senin yazdığın hata mesajı görünecektir.
            return Page();
        }

        // Başarılıysa kaydetme işlemlerine geç...
        return RedirectToPage("Success");
    }
}
         
         */
        this.ApplyNotEmptyToAllStrings();
    }
}

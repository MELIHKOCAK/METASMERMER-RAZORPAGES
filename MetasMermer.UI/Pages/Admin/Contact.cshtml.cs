using Mapster;
using MetasMermer.Services.Contacts;
using MetasMermer.Services.Contacts.Update;
using MetasMermer.Services.Footers.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetasMermer.UI.Pages.Admin
{
    public class ContactModel(IContactService _service) : PageModel
    {
        [BindProperty]
        public List<UpdateContactDto> UpdateContactDto { get; set; } = new();

        public List<ContactDto> _contactDto { get; set; } = new();

        public async Task OnGetAsync()
        {
            _contactDto = await _service.GetAllAsync();
            UpdateContactDto = _contactDto.Adapt<List<UpdateContactDto>>();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            for (int i = 0; i < UpdateContactDto.Count; i++)
                UpdateContactDto[i].Id = i;       
            await _service.Update(UpdateContactDto);
            return RedirectToPage();
        }
    }
}

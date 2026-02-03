using MetasMermer.Services.Contacts;
using Microsoft.AspNetCore.Mvc;

namespace MetasMermer.UI.Pages.Shared.Components.Contact;
[ViewComponent(Name ="contact")]
public class ContactViewComponent(IContactService _service): ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var contactList = await _service.GetAllAsync();
        return View("Default", contactList);
    }
}

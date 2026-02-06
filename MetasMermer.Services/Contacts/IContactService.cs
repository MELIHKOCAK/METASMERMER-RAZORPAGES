using MetasMermer.Services.Contacts.Update;

namespace MetasMermer.Services.Contacts;

public interface IContactService
{
    Task<ContactDto> GetByIdAsync(int id);
    Task<List<ContactDto>> GetAllAsync();
    Task<List<ContactDto>> Update(List<UpdateContactDto> contact);
}

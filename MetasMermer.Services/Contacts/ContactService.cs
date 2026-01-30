using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE.Contacts;
using MetasMermer.Services.Contacts.Update;
using Microsoft.EntityFrameworkCore;

namespace MetasMermer.Services.Contacts;

public class ContactService(IContactRepository _repository, IUnitOfWork _unitOfWork) : IContactService
{
    public async Task<List<ContactDto>> GetAllAsync()
    {
        var contact = await _repository.GetAll(false).ToListAsync();
        return contact.Adapt<List<ContactDto>>();
    }

    public async Task<ContactDto> GetByIdAsync(int id)
    {
        var contact = await _repository.GetByIdAsync(id);

        if (contact is null)
            return new ContactDto { Value = "null"};

        return contact.Adapt<ContactDto>();
    }

    public async Task<List<UpdateContactDto>> Update(List<ContactDto> _contact)
    {
        var contact = await _repository.GetAll(false).ToListAsync();

        if (contact is null)
            return new List<UpdateContactDto> { new UpdateContactDto { Value = "Null"} };

        for (int i = 0; i < contact.Count; i++)
            contact[i].Value = _contact[i].Value;

        _repository.UpdateList(contact);
        await _unitOfWork.SaveChangeAsync();

        return contact.Adapt<List<UpdateContactDto>>();
    }
}

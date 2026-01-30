using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE.Whatsapps;
using MetasMermer.Services.Whatsapps.Update;

namespace MetasMermer.Services.Whatsapps;

public class WhatsappService(IGenericRepository<Whatsapp> _repository,
                             IUnitOfWork _unitOfWork) : IWhatsappService
{

    public async Task<WhatsappDto> GetByIdAsync(int id)
    {
        var whatsapp = await _repository.GetByIdAsync(id);

        if (whatsapp is null)
            return new WhatsappDto { Title = "Null", Description = "Null", PhoneNumber = "Null" };

        return whatsapp.Adapt<WhatsappDto>();
    }

    public async Task<WhatsappDto> Update(UpdateWhatsappDto updateWhatsappDto)
    {
        var whatsapp = await _repository.GetByIdAsync(updateWhatsappDto.Id);

        if (whatsapp is null)
            return new WhatsappDto { Title = "Null", Description = "Null", PhoneNumber = "Null" };
        
        whatsapp.Description = updateWhatsappDto.Description;
        whatsapp.Title = updateWhatsappDto.Title;
        whatsapp.PhoneNumber = updateWhatsappDto.PhoneNumber;
        
        _repository.Update(whatsapp);
        await _unitOfWork.SaveChangeAsync();

        return whatsapp.Adapt<WhatsappDto>();
    }
}

using MetasMermer.Services.Whatsapps.Update;

namespace MetasMermer.Services.Whatsapps;

public interface IWhatsappService
{
    Task<WhatsappDto> GetByIdAsync(int id);
    Task<WhatsappDto> Update(UpdateWhatsappDto updateWhatsappDto);
}

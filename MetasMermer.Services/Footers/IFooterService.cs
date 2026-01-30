using MetasMermer.Services.Footers.Update;

namespace MetasMermer.Services.Footers;

public interface IFooterService
{
    Task<FooterDto> GetByIdAsync(int id);
    Task<FooterDto> Update(UpdateFooterDto updateFooterDto);
}

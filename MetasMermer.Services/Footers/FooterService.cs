using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE;
using MetasMermer.Repositories.EFCORE.Footers;
using MetasMermer.Services.Footers.Update;

namespace MetasMermer.Services.Footers;

public class FooterService(IGenericRepository<Footer> _repository, IUnitOfWork _unitOfWork) : IFooterService
{
    public async Task<FooterDto> GetByIdAsync(int id)
    {
        var footer = await _repository.GetByIdAsync(id);

        if (footer is null)
            return new FooterDto { FacebookLink = "Null", InstagramLink = "Null" };

        return footer.Adapt<FooterDto>();
    }

    public async Task<FooterDto> Update(UpdateFooterDto updateFooterDto)
    {
        var footer =  await _repository.GetByIdAsync(updateFooterDto.Id);

        if (footer is null)
            return new FooterDto { FacebookLink = "Null", InstagramLink = "Null" };

        footer.FacebookLink = updateFooterDto.FacebookLink;
        footer.InstagramLink = updateFooterDto.InstagramLink;

        _repository.Update(footer);
        await _unitOfWork.SaveChangeAsync();

        return footer.Adapt<FooterDto>();
    }
}

using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE.Abouts;
using MetasMermer.Services.Abouts.Update;

namespace MetasMermer.Services.Abouts;

public class AboutService(IGenericRepository<About> _repository, IUnitOfWork _unitOfWork) : IAboutService
{
    public async Task<AboutDto> GetByIdAsync(int id)
    {
        var about = await _repository.GetByIdAsync(id);

        if (about is null)
            return new AboutDto { Title = "Null", Description = "Null", ImageLink = "Null" };

        return about.Adapt<AboutDto>();
    }

    public async Task<AboutDto> Update(UpdateAboutDto updateAboutDto)
    {
        var about = await _repository.GetByIdAsync(updateAboutDto.Id);

        if (about is null)
            return new AboutDto { Title = "Null", Description = "Null", ImageLink = "Null" };

        about.ImageLink = updateAboutDto.ImageLink;
        about.Description = updateAboutDto.Description;
        about.Title=updateAboutDto.Title;

        _repository.Update(about);
        await _unitOfWork.SaveChangeAsync();

        return about.Adapt<AboutDto>();
    }
}

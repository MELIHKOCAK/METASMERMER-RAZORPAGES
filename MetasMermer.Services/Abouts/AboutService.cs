using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE.Abouts;
using MetasMermer.Services.Abouts.Update;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MetasMermer.Services.Abouts;

public class AboutService(IGenericRepository<About> _repository, IUnitOfWork _unitOfWork) : IAboutService
{
    public async Task<AboutDto> GetByIdAsync(int id)
    {
        var about = await _repository.GetByIdAsync(id);

        if (about is null)
            return new AboutDto { Title = "Null", Description = "Null", ImageLink = null };

        return about.Adapt<AboutDto>();
    }

    public async Task<AboutDto> Update(UpdateAboutDto updateAboutDto, string newImageUrl, List<SelectListItem> selectListItems)
    {
        var about = await _repository.GetByIdAsync(updateAboutDto.Id);

        if (about is null)
            return new AboutDto { Title = "Null", Description = "Null", ImageLink = null }; //fast fail yaklaşımı

        int imageUrl = Convert.ToInt32(newImageUrl);

        for (int i = 0; i < selectListItems.Count; i++)
        {
            about.ImageLink[i] = selectListItems[i].Text;
        }

        var newImageString = about.ImageLink[imageUrl].ToString();
        about.ImageLink[imageUrl] = about.ImageLink[0].ToString();
        about.ImageLink[0] = newImageString;
        about.Description = updateAboutDto.Description;
        about.Title=updateAboutDto.Title;

        _repository.Update(about);
        await _unitOfWork.SaveChangeAsync();

        return about.Adapt<AboutDto>();
    }
}

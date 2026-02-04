using MetasMermer.Services.Abouts.Update;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace MetasMermer.Services.Abouts;

public interface IAboutService
{
    Task<AboutDto> GetByIdAsync(int id);
    Task<AboutDto> Update(UpdateAboutDto updateAboutDto, string newImageUrl, List<SelectListItem> selectListItems);
}

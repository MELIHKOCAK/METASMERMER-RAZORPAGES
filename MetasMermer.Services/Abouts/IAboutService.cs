using MetasMermer.Services.Abouts.Update;
namespace MetasMermer.Services.Abouts;

public interface IAboutService
{
    Task<AboutDto> GetByIdAsync(int id);
    Task<AboutDto> Update(UpdateAboutDto updateAboutDto);
}

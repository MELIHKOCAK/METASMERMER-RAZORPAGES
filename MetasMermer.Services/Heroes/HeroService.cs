using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE.Heroes;
using MetasMermer.Services.Footers;
using MetasMermer.Services.Footers.Update;
using MetasMermer.Services.Heroes.Update;

namespace MetasMermer.Services.Heroes;

public class HeroService(IGenericRepository<Hero> _repository, IUnitOfWork _unitOfWork) : IHeroService
{
    public async Task<HeroDto> GetByIdAsync(int id)
    {
        var hero = await _repository.GetByIdAsync(id);

        if (hero is null)
            return new HeroDto { CompanyName = "null" };

        return hero.Adapt<HeroDto>();
    }

    public async Task<HeroDto> Update(UpdateHeroDto updateHeroDto)
    {
        var hero = await _repository.GetByIdAsync(updateHeroDto.Id);
        if (hero is null)
            return new HeroDto { CompanyName = "Null" };

        hero.CompanyName = updateHeroDto.CompanyName;

        _repository.Update(hero);
        await _unitOfWork.SaveChangeAsync();

        return updateHeroDto.Adapt<HeroDto>();
    }
}

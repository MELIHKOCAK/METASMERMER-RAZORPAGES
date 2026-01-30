using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE.Heroes;

namespace MetasMermer.Services.Heroes;

public class HeroService(IGenericRepository<Hero> _repository) : IHeroService
{
    public async Task<HeroDto> GetByIdAsync(int id)
    {
        var hero = await _repository.GetByIdAsync(id);

        if (hero is null)
            return new HeroDto { CompanyName = "null" };

        return hero.Adapt<HeroDto>();
    }
}

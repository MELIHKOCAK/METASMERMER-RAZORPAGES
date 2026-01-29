using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetasMermer.Services.Heroes
{
    public class HeroService : IHeroService
    {
        private IGenericRepository<Hero> _heroRepository { get; set; }

        public HeroService(IGenericRepository<Hero> heroRepository)
        {
            _heroRepository = heroRepository;
        }

        public async Task<HeroDto> GetByIdAsync(int id)
        {
            var hero = await _heroRepository.GetByIdAsync(id);

            if (hero == null)
                return new HeroDto { CompanyName = "Empty" };

            return hero.Adapt<HeroDto>();
        }
    }
}

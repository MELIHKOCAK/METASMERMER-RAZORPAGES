using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetasMermer.Services.Heroes
{
    public interface IHeroService
    {
        Task<HeroDto> GetByIdAsync(int id);
    }
}

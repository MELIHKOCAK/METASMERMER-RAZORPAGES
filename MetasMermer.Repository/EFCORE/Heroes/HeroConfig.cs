using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetasMermer.Repositories.EFCORE.Heroes;

public class HeroConfig : IEntityTypeConfiguration<Hero>
{
    public void Configure(EntityTypeBuilder<Hero> builder)
    {
        builder.HasData(
                new Hero
                {
                    Id = 1,
                    CompanyName = "Metaş Mermere"
                }
            );
    }
}

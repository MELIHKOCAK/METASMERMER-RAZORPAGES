using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetasMermer.Repositories.EFCORE.Solutions;

public class SolutionConfig : IEntityTypeConfiguration<Solution>
{
    public void Configure(EntityTypeBuilder<Solution> builder)
    {
        builder.HasData
            (
                new Solution
                {
                    Id = 1, Title = "Hizmetlerimiz", 
                    Description = " Metaş mermer ve granit sanayii olarak her türlü • Mutfak Tezgahı • Denizlik • Basamak • Mezar işleriniz itina ile yapılır."
                }
            );
    }
}

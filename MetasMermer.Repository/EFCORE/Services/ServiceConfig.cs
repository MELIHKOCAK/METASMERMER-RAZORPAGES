using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetasMermer.Repositories.EFCORE.Services;

public class ServiceConfig : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.HasData
            (
                new Service
                {
                    Id = 1, Title = "Hizmetlerimiz", 
                    Description = " Metaş mermer ve granit sanayii olarak her türlü • Mutfak Tezgahı • Denizlik • Basamak • Mezar işleriniz itina ile yapılır."
                }
            );
    }
}

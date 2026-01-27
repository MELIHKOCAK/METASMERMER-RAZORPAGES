using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetasMermer.Repositories.EFCORE.Footers;

public class FooterConfig : IEntityTypeConfiguration<Footer>
{
    public void Configure(EntityTypeBuilder<Footer> builder)
    {
        builder.HasData
            (
                new Footer 
                { 
                    Id = 1,
                    FacebookLink = "https://www.facebook.com/metas.muratersin",
                    InstagramLink = "https://www.instagram.com/metasmuratersin"
                }
            );
    }
}

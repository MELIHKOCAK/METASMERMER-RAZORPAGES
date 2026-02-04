using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetasMermer.Repositories.EFCORE.Abouts
{
    public class AboutConfig : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasData
                (
                    new About
                    {
                        Id = 1,
                        ImageLink = new List<string>
                        {
                            "/img/hero.webp",
                            "/img/kursat.webp"
                        },
                        Title = "Her Zaman Kalite",
                        Description = "2007 Yılında Tokat'ın Niksar ilçesinde sanayi bölgesinde kurulan \"Metaş Mermer Ve Granit Sanayii kalitesini\" geliştirerek siz değerli müşterilerimize hizmet vermeye devam etmektedir.."
                    }
                );
        }
    }
}

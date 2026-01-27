using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetasMermer.Repositories.EFCORE.Whatsapps;

public class WhatsappConfig : IEntityTypeConfiguration<Whatsapp>
{
    public void Configure(EntityTypeBuilder<Whatsapp> builder)
    {
        builder.HasData
            (
                new Whatsapp
                {
                    Id = 1,
                    Title = "Size Nasıl Yardımcı Olabilirim?",
                    Description = "Merhaba! 👋 Daha Fazla Bilgi İçin Bizlere Whatsapdan Ulaşabilirsiniz",
                    PhoneNumber = "905374480024"
                }
            );
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetasMermer.Repositories.EFCORE.Contacts;

public class ContactConfig : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.HasData
            (
                new Contact { Id = 1, Value = "905325887656" },
                new Contact { Id = 2, Value = "905374480024" },
                new Contact { Id = 3, Value = "kursatersin@icloud.com" },
                new Contact { Id = 4, Value = "https://www.google.com/maps?ll=40.583868,36.919473&z=16&t=m&hl=tr&gl=TR&mapclient=embed&cid=13389469205681263836" },
                new Contact { Id = 5, Value = "Sanayi Sitesi 9.Blok No: 50 Niksar/Tokat" },
                new Contact { Id = 6, Value = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3030.0853262311134!2d36.91728441569593!3d40.58387195338053!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x407d1b6512db2dab%3A0xb9d0f34d57a9d4dc!2sMETA%C5%9E%20MERMER!5e0!3m2!1str!2str!4v1665173589058!5m2!1str!2str" }
            );
    }
}

namespace MetasMermer.Repositories.EFCORE.Whatsapps;

public class Whatsapp : BaseEntity<int>
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
}

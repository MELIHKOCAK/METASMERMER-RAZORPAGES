namespace MetasMermer.Repositories.EFCORE.Services;

public class Service:BaseEntity<int>
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
}

namespace MetasMermer.Repositories.EFCORE.Abouts;

public class About : BaseEntity<int>
{
    public string ImageLink { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
}

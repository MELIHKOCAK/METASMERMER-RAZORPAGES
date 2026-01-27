namespace MetasMermer.Repositories.EFCORE.Footers;

public class Footer:BaseEntity<int>
{
    public string InstagramLink { get; set; } = default!;
    public string FacebookLink { get; set; } = default!;
}

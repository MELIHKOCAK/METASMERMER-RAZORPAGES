namespace MetasMermer.Repositories.EFCORE.Galleries;

public class Gallery : BaseEntity<int>
{
    public string ImageLink { get; set; } = default!;
}

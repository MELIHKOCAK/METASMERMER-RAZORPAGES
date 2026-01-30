namespace MetasMermer.Repositories.EFCORE.Solutions;

public class Solution:BaseEntity<int>
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
}

namespace MetasMermer.Repositories.EFCORE.Heroes;

public class Hero : BaseEntity<int>
{
    public string CompanyName { get; set; } = default!;
}

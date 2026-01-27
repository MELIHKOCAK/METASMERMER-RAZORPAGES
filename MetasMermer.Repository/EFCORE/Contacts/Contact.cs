namespace MetasMermer.Repositories.EFCORE.Contacts;

public class Contact : BaseEntity<int>
{
    public string Value { get; set; } = default!;
}

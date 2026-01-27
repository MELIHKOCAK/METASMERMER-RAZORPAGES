namespace MetasMermer.Repositories.EFCORE.Users;

public class Users:BaseEntity<int>
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
}

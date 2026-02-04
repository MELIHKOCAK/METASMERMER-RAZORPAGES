namespace MetasMermer.Services.Users;

public record UserDto
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
}

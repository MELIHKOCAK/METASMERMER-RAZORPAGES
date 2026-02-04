using MetasMermer.Services.Contacts;

namespace MetasMermer.Services.Users;

public interface IUserService
{
    Task<UserDto> GetByIdAsync(int id);

}

using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE.Users;

namespace MetasMermer.Services.Users;

public class UserService(IGenericRepository<Repositories.EFCORE.Users.Users> _repository) : IUserService
{
    public async Task<UserDto> GetByIdAsync(int id)
    {
        var user = await _repository.GetByIdAsync(id);

        if (user is null)
            return new UserDto { UserName = "Null", Password = "Null", IsAdmin = false };

        return user.Adapt<UserDto>();
    }
}

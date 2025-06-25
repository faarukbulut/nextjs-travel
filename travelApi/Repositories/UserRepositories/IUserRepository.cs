using travelApi.Dtos.UserDtos;

namespace travelApi.Repositories.UserRepositories;

public interface IUserRepository
{
    Task<List<GetUserListDto>> GetUserListAsync();
    Task CreateUserAsync(CreateUserDto createUserDto);
}

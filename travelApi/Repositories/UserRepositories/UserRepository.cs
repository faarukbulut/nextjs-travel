using travelApi.DbModel;
using travelApi.Dtos.UserDtos;
using travelApi.MockData;

namespace travelApi.Repositories.UserRepositories;

public class UserRepository : IUserRepository
{
    public Task<List<GetUserListDto>> GetUserListAsync()
    {
        var userList = UserData.Users
            .Select(u => new GetUserListDto
            {
                UserId = u.UserId,
                Email = u.Email,
                UserName = u.UserName,
                Photo = u.Photo,
                FirstName = u.FirstName,
                LastName = u.LastName
            })
            .ToList();

        return Task.FromResult(userList);
    }

    public Task CreateUserAsync(CreateUserDto createUserDto)
    {
        int userId = UserData.Users.Any()
            ? UserData.Users.Max(u => u.UserId) + 1
            : 1;
    
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(createUserDto.Password, workFactor: 12);

        var user = new User
        {
            UserId = userId,
            Email = createUserDto.Email,
            UserName = createUserDto.UserName,
            Password = hashedPassword,
            Photo = "",
            FirstName = createUserDto.FirstName,
            LastName = createUserDto.LastName
        };
        
        UserData.Users.Add(user);

        return Task.CompletedTask;
    }
}

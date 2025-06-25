using travelApi.DbModel;

namespace travelApi.MockData;

public static class UserData
{
    public static List<User> Users { get; set; } = new List<User>
    {
        new User
        {
            UserId = 1,
            Email = "john.doe@example.com",
            UserName = "johndoe",
            Password = BCrypt.Net.BCrypt.HashPassword("123456", workFactor: 12),
            Photo = "https://example.com/photos/johndoe.jpg",
            FirstName = "John",
            LastName = "Doe"
        },
    };
}

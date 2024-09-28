namespace CleanArchitecture.API.Model
{
    public class UserStore
    {
        public static List<User> Users = new List<User>
        {
            new User { Id=1, UserName = "admin", Password = "password", Email="admin@Example.com", Roles = new List<string> { "Admin", "User" } },
            new User { Id=2, UserName = "user", Password = "password", Email="user@Example.com", Roles = new List<string> { "User" } },
            new User { Id=3, UserName = "test", Password = "password", Email="test@Example.com", Roles = new List<string> { "Admin" } }
        };
    }
}

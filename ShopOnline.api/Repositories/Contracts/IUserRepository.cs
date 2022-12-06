using ShopOnline.api.Entities;

namespace Mark.Up.Hub.api.Repositories.Contracts
{
    public class IUserRepository
    {
        Task<IEnumerable<User>> GetUser(int id);
        Task<IEnumerable<User>> GetUserName(string userName);
        Task<User> GetUserEmail(string email);
    }
}

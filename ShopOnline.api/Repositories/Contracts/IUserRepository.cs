using ShopOnline.api.Entities;

namespace Mark.Up.Hub.api.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUser(int id);
        Task<IEnumerable<User>> GetUsers();
        Task<IEnumerable<User>> GetUserName(string userName);
        Task<User> GetUserEmail(string email);
    }
}

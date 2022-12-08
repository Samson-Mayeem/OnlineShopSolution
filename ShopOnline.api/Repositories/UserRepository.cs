using Mark.Up.Hub.api.Data;
using Mark.Up.Hub.api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using ShopOnline.api.Entities;

namespace Mark.Up.Hub.api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext dataContext;

        public UserRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public Task<IEnumerable<User>> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task <IEnumerable<User>> GetUsers()
        {
            var users = await this.dataContext.Users.ToListAsync();
            return users;
        }
    }
}

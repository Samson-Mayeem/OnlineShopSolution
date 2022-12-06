using Mark.Up.Hub.api.Data;
using Mark.Up.Hub.api.Repositories.Contracts;

namespace Mark.Up.Hub.api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext dataContext;

        public UserRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}

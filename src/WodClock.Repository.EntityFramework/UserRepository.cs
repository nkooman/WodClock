using WodClock.Repository.EntityFramework.Abstractions;
using WodClock.Repository.EntityFramework.Entities;

namespace WodClock.Repository.EntityFramework
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApiContext context)
            : base(context) { }
    }
}
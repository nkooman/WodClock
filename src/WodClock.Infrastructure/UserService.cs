using AutoMapper;
using WodClock.Infrastructure.Abstractions;
using WodClock.Repository.EntityFramework.Abstractions;
using Entities = WodClock.Repository.EntityFramework.Entities;
using Models = WodClock.Core.Models;

namespace WodClock.Infrastructure
{
    public class UserService : Service<Entities.User, Models.User>, IUserService
    {
        public UserService(IMapper mapper, IUserRepository repository)
            : base(mapper, repository) { }
    }
}
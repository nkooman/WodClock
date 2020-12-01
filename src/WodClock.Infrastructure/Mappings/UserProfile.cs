using AutoMapper;
using UserEntity = WodClock.Repository.EntityFramework.Entities.User;
using UserModel = WodClock.Core.Models.User;

namespace WodClock.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel, UserEntity>()
                .ReverseMap();
        }
    }
}
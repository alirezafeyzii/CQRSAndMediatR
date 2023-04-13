using AutoMapper;
using SampleMediatR.Entity;
using SampleMediatR.Models.Responses.Users;

namespace SampleMediatR.Profiles.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserResponse>();
        }
    }
}

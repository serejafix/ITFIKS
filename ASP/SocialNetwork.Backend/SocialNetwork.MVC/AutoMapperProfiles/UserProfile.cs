using AutoMapper;
using Social.Network.DTO;
using SocialNetwork.MVC.Data.EntityModels;

namespace SocialNetwork.MVC.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
        }
    }
}

using AutoMapper;
using Social.Network.DTO;
using SocialNetwork.MVC.Data.EntityModels;
using SocialNetwork.MVC.Interfaces;

namespace SocialNetwork.MVC.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository,IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserDTO>> GetUsers()
        {
            IEnumerable<User> entities = await _userRepository.GetUsers();

            IEnumerable<UserDTO> users = _mapper.Map<IEnumerable<UserDTO>>(entities);

            return users;
        }
    }
}

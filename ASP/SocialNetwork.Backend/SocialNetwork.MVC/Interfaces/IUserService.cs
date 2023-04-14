using Social.Network.DTO;

namespace SocialNetwork.MVC.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetUsers();
    }
}

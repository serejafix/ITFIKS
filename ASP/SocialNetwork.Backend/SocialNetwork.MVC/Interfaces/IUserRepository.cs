using SocialNetwork.MVC.Data.EntityModels;

namespace SocialNetwork.MVC.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
    }
}

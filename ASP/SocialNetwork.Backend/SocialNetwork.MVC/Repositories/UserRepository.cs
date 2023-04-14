using Microsoft.EntityFrameworkCore;
using SocialNetwork.MVC.Data;
using SocialNetwork.MVC.Data.EntityModels;
using SocialNetwork.MVC.Interfaces;

namespace SocialNetwork.MVC.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SocailNetworkDbContext _context;
        public UserRepository(SocailNetworkDbContext context)
        {  
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
           IQueryable<User> entities = _context.Users
                .Where(c => c.IsDeleted == false);
            return await entities.ToListAsync();
        }
    }
}

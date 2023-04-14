using SocialNetwork.MVC.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.MVC.Data
{
    public static class DbInitializer
    {

        public static async Task Initialize(IServiceProvider services)
        {
            SocailNetworkDbContext context =
                services.GetService<SocailNetworkDbContext>();

            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            User user = new User
            {
              
                FirstName = "firstname",
                LastName = "lastname",
                BirthDate = DateTime.Now,
                Gender = Gender.Male,
                StatusText = "status",
                PhoneNumber = "1234567890",
                Email = "123@gmail.com",
                IsDeleted = false,
                EmailConfirmed = false,
            };
            User user1 = new User
            {
             
                FirstName = "firstname1",
                LastName = "lastname1",
                BirthDate = DateTime.Now,
                Gender = Gender.Male,
                StatusText = "status1",
                PhoneNumber = "12345678901",
                Email = "1223@gmail.com",
                IsDeleted = false,
                EmailConfirmed = false,
            };

            context.Users.Add(user);
            await context.SaveChangesAsync();
        }
    }
}

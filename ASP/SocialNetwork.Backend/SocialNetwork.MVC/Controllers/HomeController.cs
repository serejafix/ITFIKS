using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SocialNetwork.MVC.Data;
using SocialNetwork.MVC.Interfaces;
using Social.Network.DTO;

namespace SocialNetwork.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly SocailNetworkDbContext _context;
        private readonly IUserService _userService;
        public HomeController(SocailNetworkDbContext context,IUserService userService)
        {
            _userService = userService;
            _context = context;
        }

        public IActionResult Index()
        {
            //IEnumerable<UserDTO> users = await _userService.GetUsers();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
           
        }
    }
}
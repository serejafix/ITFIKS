using DZ_5.Models;
using DZ_5.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DZ_5.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context; 
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                User? user = await _context.Users.FirstOrDefaultAsync(u => u.Email == loginVM.Email &&
                                                                u.Password == loginVM.Password);
                if (user != null)
                {
                    await Authentication(loginVM.Email);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Incorrect login and (or) password");
            }
            
            return View(loginVM);
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                User? user = _context.Users.FirstOrDefault(u => u.Email == registerVM.Email);
                if (user is null)
                {
                    _context.Users.Add(new User
                    {
                        Email = registerVM.Email,
                        Password = registerVM.Password
                    });
                    await _context.SaveChangesAsync();
                    await Authentication(registerVM.Email);
                    return RedirectToAction(nameof(Index), "Home");
                }
                ModelState.AddModelError("", "Incorrect login and (or) password");
            }

            return View(registerVM);
        }

        public async Task Authentication(string userName)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType,userName)
            };

            ClaimsIdentity id = new ClaimsIdentity(
                claims: claims,
                authenticationType:"ApplicationCookie",
                nameType:ClaimsIdentity.DefaultNameClaimType,
                roleType:ClaimsIdentity.DefaultRoleClaimType
                );

            await HttpContext.SignInAsync(
                scheme: CookieAuthenticationDefaults.AuthenticationScheme,
                principal: new ClaimsPrincipal(id)
                );
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
                scheme: CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(Login),"Account");
        }
    }
}

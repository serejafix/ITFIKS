using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SocialNetwork.MVC.Data.EntityModels;
using SocialNetwork.MVC.ViewModels;

namespace SocialNetwork.MVC.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(UserManager<User> userManager,
                                 SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerVM)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    FirstName = registerVM.FirstName,
                    LastName = registerVM.LastName,
                    Email = registerVM.Email,
                    UserName = registerVM.Email,
                    BirthDate = registerVM.BirthDate,
                    ProfileImage = await ConvertFileToBytesAsync(registerVM.ProfilePhoto),
                    Gender = registerVM.Gender,
                };
                var registrationResult = await _userManager
                                        .CreateAsync(user,registerVM.Password);
                if (registrationResult.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in registrationResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(registerVM);
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(loginViewModel.Email,
                                                             loginViewModel.Password,
                                                             loginViewModel.RememberMe,
                                                             false);
                if (result.Succeeded)
                {
                    //Защита от Open Redirect Attack
                    //При всей простоте защиты, Open Redirect стоит на третьем месте по популярности в мире.
                    if (!string.IsNullOrEmpty(loginViewModel.ReturnUrl) && Url.IsLocalUrl(loginViewModel.ReturnUrl))
                    {
                        return Redirect(loginViewModel.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }
            return View(loginViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        private static async Task<byte[]> ConvertFileToBytesAsync(IFormFile file)
        {
            using (MemoryStream Stream = new MemoryStream())
            {
                // Open the image as a stream and copy it into Stream object
                await file?.OpenReadStream()?.CopyToAsync(Stream);
                // Convert the stream to Byte array.
                return Stream.ToArray();
            }
        }
    }
}

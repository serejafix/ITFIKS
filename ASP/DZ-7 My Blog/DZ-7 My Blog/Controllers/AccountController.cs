using Blog.Models;
using Blog.Services.EmailService;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private readonly IEmailService _emailService;
        public AccountController(UserManager<User> userManager,
            SignInManager<User> signInManaget, IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManaget;
            _emailService = emailService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            User? user =  await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return View("Error");
            }
            IdentityResult result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return RedirectToAction("ConfirmedAccount", "Account");
            }
            else
            {
                return View("Error");
            }
        }

        [HttpGet]
        public IActionResult ConfirmedAccount()
        {
            return View("ConfirmedAccount");
        }

        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginViewModel.Email);
                if (user != null) 
                {
                    if (!await _userManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError(string.Empty, "You are not confirmed Email Address");
                        return View(loginViewModel);
                    }
                }

                Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager
                    .PasswordSignInAsync(
                    userName: loginViewModel.Email,
                    password: loginViewModel.Password,
                    isPersistent: loginViewModel.RememberMe,
                    lockoutOnFailure: false);

                if (signInResult.Succeeded)
                {
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
                    ModelState.AddModelError(string.Empty, "Invalid Login or password");
                }
            }
            return View(loginViewModel);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Email
                };

                IdentityResult result = await _userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    string callBackUrl = Url.Action(
                        "ConfirmEmail",
                        "Account",
                        new
                        {
                            userId = user.Id,
                            code = code
                        },
                        protocol: HttpContext.Request.Scheme)!;

                    await _emailService.SendEmailAsync(
                  "MyBlog",
                  registerViewModel.Email,
                  "Confirm",
                  $"For confirm registration <a href='{callBackUrl}'>Fallow the ling </a>");
                    return View("ConfirmRegistration");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }

            }
            return View(registerViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

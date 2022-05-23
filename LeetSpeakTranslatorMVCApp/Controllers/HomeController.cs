using Business.Abstract;
using DreamProcessingIK.Managers;
using Entities.Concrete;
using Entities.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetSpeakTranslatorMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;
        public UserManager<AppUser> _userManager;
        public RoleManager<AppRole> _roleManager;
        public SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(IUserService userSevice, RoleManager<AppRole> roleManager, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IWebHostEnvironment webHostEnvironment, ILogger<HomeController> logger)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _userManager = userManager;
            _userService = userSevice;
            DefaultAdmin();
        }


        #region IActionResults

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterVM register)
        {
            AppUser user = new AppUser();
            user.UserName = register.UserName;
            user.FirstName = register.FirstName;
            user.LastName = register.LastName;
            user.Password = register.Password;
            user.Photo = register.Photo.GetUniqueNameAndSavePhotoToDisk(_webHostEnvironment);
            IdentityResult result = await _userManager.CreateAsync(user, register.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
                return RedirectToAction("UserIndex", "User");
            }
            AddErrorsToModelState(result, this);
            return View(register);
        }

        public IActionResult LogIn(string returnUrl)
        {
            TempData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(UserLoginVM userLoginVM)
        {
            if (ModelState.IsValid)
            {
                if (_userManager.Users.Where(x => x.UserName == userLoginVM.UserName).ToList().Any())
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _userService.LogIn(userLoginVM);
                    if (result.Succeeded)
                    {
                        AppUser user = await _userManager.FindByNameAsync(userLoginVM.UserName);
                        IList<string> roles = await _userManager.GetRolesAsync(user);

                        if (roles.Contains("Admin"))
                        {
                            if (TempData["ReturnUrl"] != null)
                            {
                                return Redirect(TempData["ReturnUrl"].ToString());
                            }
                            return RedirectToAction("AllSearchHistoryWithUsers", "Admin");
                        }
                        else
                        {
                            if (TempData["ReturnUrl"] != null)
                            {
                                return Redirect(TempData["ReturnUrl"].ToString());
                            }
                            return RedirectToAction("UserIndex", "User");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password!");
                }
            }
            return View(userLoginVM);
        }


        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(UserLoginVM userLoginVM)
        {
            AppUser user = _userManager.FindByNameAsync(userLoginVM.UserName).Result;
            IdentityResult passwordResult = _userManager.ChangePasswordAsync(user, user.Password, userLoginVM.Password).Result;
            user.Password = userLoginVM.Password;
            IdentityResult result = await _userManager.UpdateAsync(user);
            if (passwordResult.Succeeded && result.Succeeded)
            {
                await _userManager.UpdateSecurityStampAsync(user);
                await _signInManager.SignOutAsync();
                await _signInManager.SignInAsync(user, true);
            }
            return RedirectToAction("LogIn");
        }


        #endregion




        #region Methods

        public static void AddErrorsToModelState(IdentityResult result, Controller controller)
        {
            List<IdentityError> errors = result.Errors.ToList();
            foreach (var error in errors)
            {
                controller.ModelState.AddModelError("", error.Description);
            }
        }

        public void LogOut()
        {
            _signInManager.SignOutAsync();
        }

        public void DefaultAdmin()
        {
            if (!_roleManager.Roles.ToList().Any())  //to create the basic roles when the first time project starts 
            {
                AppRole admin = new AppRole() { Name = "Admin" };
                IdentityResult adminResult = _roleManager.CreateAsync(admin).Result;

                AppRole user = new AppRole() { Name = "User" };
                IdentityResult userResult = _roleManager.CreateAsync(user).Result;
                if (!_userManager.Users.ToList().ToList().Any())
                {
                    AppUser appUser = new AppUser() { FirstName = "Emre", LastName = "Koc", UserName = "emrekoc", Password = "1234" };
                    IdentityResult result = _userManager.CreateAsync(appUser, appUser.Password).Result;
                }
                if (!_userManager.GetUsersInRoleAsync("Admin").Result.Contains(_userManager.FindByNameAsync("emrekoc").Result))
                {
                    _userManager.AddToRoleAsync(_userManager.FindByNameAsync("emrekoc").Result, _roleManager.FindByNameAsync("Admin").Result.ToString());
                }
            }
        }
        #endregion

    }
}

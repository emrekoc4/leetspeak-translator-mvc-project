using Business.Abstract;
using DreamProcessingIK.Managers;
using Entities.Concrete;
using Entities.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetSpeakTranslatorMVCApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUserService _userService;
        private readonly IContentsService _contentsService;
        private readonly IUserContentsService _userContentsService;

        public UserManager<AppUser> _userManager;
        public SignInManager<AppUser> _signInManager;
        public RoleManager<AppRole> _roleManager;
        public AdminController(IUserService userSevice, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IContentsService contentsService, IUserContentsService userContentsService, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _userService = userSevice;
            _contentsService = contentsService;
            _userContentsService = userContentsService;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }


        #region IActionResults
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(CreateUserVM createUser)
        {
            IdentityResult result = CreateUser(createUser).Result;
            if (result.Succeeded)
            {
                return RedirectToAction("GetAllUsers");
            }
            HomeController.AddErrorsToModelState(result, this);
            return View(createUser);
        }

        public IActionResult AllSearchHistoryWithUsers()
        {
            return View(GetAllHistoryWithUsers());
        }
        public IActionResult AllSearchHistory()
        {
            return View(GetAllSearchHistory());
        }
        public IActionResult GetAllUsers()
        {
            return View(GetUsers());
        }
        public IActionResult DeleteUser(string userId)
        {
            IdentityResult result = DeleteUserById(userId).Result;
            if (result.Succeeded)
            {
                return RedirectToAction("GetAllUsers");
            }
            HomeController.AddErrorsToModelState(result, this);
            return RedirectToAction("GetAllUsers");
        }

        #endregion







        #region Methods

        public List<UserContentListVM> GetAllHistoryWithUsers()
        {
            List<UserContentListVM> userHistory = new List<UserContentListVM>();
            List<UserContentsDto> history = _userContentsService.GetList();
            foreach (UserContentsDto item in history)
            {
                UserContentListVM userContentListVM = new UserContentListVM();
                AppUser user = GetUser(item.UserId);
                Contents contents = _contentsService.GetById((int)item.ContentsId);
                userContentListVM.UserId = user.Id;
                userContentListVM.UserName = user.UserName;
                userContentListVM.FirstName = user.FirstName;
                userContentListVM.LastName = user.LastName;
                userContentListVM.ContentId = contents.Id;
                userContentListVM.Translated = contents.translated;
                userContentListVM.Text = contents.text;
                userContentListVM.Translation = contents.translation;
                userHistory.Add(userContentListVM);
            }
            return userHistory;
        }

        public List<Contents> GetAllSearchHistory()
        {
            return _contentsService.GetList();
        }

        public List<GetUsersVM> GetUsers()
        {
            List<GetUsersVM> users = new List<GetUsersVM>();
            List<AppUser> appUsers = _userManager.Users.ToList();
            foreach (var item in appUsers)
            {
                GetUsersVM userVM = new GetUsersVM();
                userVM.UserId = item.Id;
                userVM.UserName = item.UserName;
                userVM.FirstName = item.FirstName;
                userVM.LastName = item.LastName;
                userVM.Photo = item.Photo;
                userVM.Role = _userManager.IsInRoleAsync(item, "Admin").Result ? "Admin,User" : "User";
                users.Add(userVM);
            }
            return users;
        }

        public AppUser GetUser(string userId)
        {
            return _userManager.FindByIdAsync(userId).Result;
        }

        public async Task<IdentityResult> CreateUser(CreateUserVM createUser)
        {
            AppUser user = new AppUser();
            user.UserName = createUser.UserName;
            user.FirstName = createUser.FirstName;
            user.LastName = createUser.LastName;
            user.Password = createUser.Password;
            user.Photo = createUser.Photo.GetUniqueNameAndSavePhotoToDisk(_webHostEnvironment);
            IdentityResult result = await _userManager.CreateAsync(user, createUser.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
                if (createUser.IsAdmin == "Admin")
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
            }
            return result;
        }

        public async Task<IdentityResult> DeleteUserById(string userId)
        {
            if (_userContentsService.GetByUserId(userId) != null)
            {
                _userContentsService.Delete(_userContentsService.GetByUserId(userId));
            }
            AppUser user = GetUser(userId);
            IdentityResult result = await _userManager.DeleteAsync(user);
            return result;
        }
        #endregion
    }
}

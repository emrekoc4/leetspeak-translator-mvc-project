using Business.Abstract;
using DreamProcessingIK.Managers;
using Entities.Concrete;
using Entities.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace LeetSpeakTranslatorMVCApp.Controllers
{
    [Authorize(Roles = "User,Admin")]
    public class UserController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUserService _userService;
        private readonly IContentsService _contentsService;
        private readonly IUserContentsService _userContentsService;

        public UserManager<AppUser> _userManager;
        public SignInManager<AppUser> _signInManager;
        public RoleManager<AppRole> _roleManager;

        public UserController(IUserService userSevice, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IContentsService contentsService, IUserContentsService userContentsService, IWebHostEnvironment webHostEnvironment)
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
        public IActionResult UserIndex()
        {
            UserContentVM userContentVM = new UserContentVM();
            userContentVM.UserName = GetLoggedUser().UserName;
            return View(userContentVM);
        }

        [HttpPost]
        public IActionResult UserIndex(UserContentVM userContentVM)
        {
            userContentVM.UserName = _userManager.GetUserAsync(User).Result.UserName;
            string link = GetLink(userContentVM.Content);
            ConvertingVM convertingVM = GetConvertingVM(link);
            CreateContent(convertingVM, userContentVM);
            if (_userManager.IsInRoleAsync(GetLoggedUser(), "Admin").Result)
            {
                return RedirectToAction("AllSearchHistoryWithUsers","Admin");
            }
            return RedirectToAction("SearchHistory");
        }
        public IActionResult SearchHistory()
        {
            string userId = _userManager.GetUserAsync(User).Result.Id.ToString();
            TempData["IsAdmin"] = _userManager.IsInRoleAsync(GetUser(userId), "Admin").Result.ToString();
            TempData["UserName"] = GetLoggedUser().UserName.ToString();
            return View(GetUserSearchHistory(userId));
        }

        public IActionResult UpdateUser(string userName)
        {
            userName = userName == null ? GetLoggedUser().UserName : userName;
            AppUser user = _userManager.FindByNameAsync(userName).Result;
            UpdateUserVM updateUserVM = new UpdateUserVM() { FirstName = user.FirstName, LastName = user.LastName, PhotoAddress = user.Photo };
            return View(updateUserVM);
        }

        [HttpPost]
        public IActionResult UpdateUser(UpdateUserVM updateUserVM)
        {
            if (GetLoggedUser().UserName == updateUserVM.CurrentUserName && _userManager.CheckPasswordAsync(GetLoggedUser(), updateUserVM.CurrentPassword).Result || _userManager.IsInRoleAsync(GetLoggedUser(), "Admin").Result)
            {
                IdentityResult result = EditUser(updateUserVM).Result;
                if (result.Succeeded)
                {
                    return RedirectToAction("SearchHistory");
                }
                else
                {
                    HomeController.AddErrorsToModelState(result, this);
                }
            }
            return View(updateUserVM);
        }


        public IActionResult UpdateContent(int contentId)
        {
            UserContentsDto userContentsDto = _userContentsService.GetByContentId(contentId);
            if (userContentsDto.UserId == GetLoggedUser().Id)
            {
                Contents content = _contentsService.GetById(contentId);
                UpdateUserContentVM updateUserContentVM = new UpdateUserContentVM() { Content = content.text, ContentId = content.Id, UserName = GetLoggedUser().UserName };
                return View(updateUserContentVM);
            }
            return RedirectToAction("SearchHistory");
        }

        [HttpPost]
        public IActionResult UpdateContent(UpdateUserContentVM updateUserContentVM)
        {
            string link = GetLink(updateUserContentVM.Content);
            ConvertingVM convertingVM = GetConvertingVM(link);
            EditContent(convertingVM, updateUserContentVM.ContentId);
            return RedirectToAction("SearchHistory");
        }

        public IActionResult DeleteContent(int contentId)
        {
            Contents content = _contentsService.GetById(contentId);
            UserContentsDto userContent = _userContentsService.GetByContentId(contentId);
            _userContentsService.Delete(userContent);
            _contentsService.Delete(content);
            return RedirectToAction("SearchHistory");
        }
        #endregion







        #region Methods
        public async Task<IdentityResult> EditUser(UpdateUserVM updateUserVM)
        {
            AppUser updateUser = GetUserByUserName(updateUserVM.CurrentUserName);

            updateUser.UserName = updateUserVM.NewUserName;
            updateUser.Password = updateUserVM.NewPassword;
            updateUser.FirstName = updateUserVM.FirstName;
            updateUser.LastName = updateUserVM.LastName;
            updateUser.Photo = updateUserVM.Photo.GetUniqueNameAndSavePhotoToDisk(_webHostEnvironment);
            IdentityResult result = await _userManager.UpdateAsync(updateUser);
            IdentityResult passwordResult = _userManager.ChangePasswordAsync(updateUser, updateUserVM.CurrentPassword, updateUserVM.NewPassword).Result;
            if (result.Succeeded && passwordResult.Succeeded)
            {
                await _userManager.UpdateSecurityStampAsync(updateUser);
                if (!_userManager.IsInRoleAsync(GetLoggedUser(), "Admin").Result)
                {
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(updateUser, true);
                }
            }
            return result;
        }
        public static string GetLink(string content)  //This method gets the string from users and convert it to the link that will send as a request to API
        {
            string link = "https://api.funtranslations.com/translate/leetspeak.json?text=";
            char[] list = content.ToCharArray();
            foreach (var item in list)
            {
                if (item == ' ')
                {
                    link = link + "%20";
                }
                else
                {
                    link = link + item;
                }
            }
            return link;
        }

        public static ConvertingVM GetConvertingVM(string link)  //ConvertingVM was created to get data from API. 
        {
            string data = new WebClient().DownloadString(link);
            ConvertingVM convertingVM = JsonConvert.DeserializeObject<ConvertingVM>(data);//This is where data gets
            return convertingVM;
        }

        public void CreateContent(ConvertingVM convertingVM, UserContentVM userContentVM)  //This method gets the data, user searching(string text), user information and adds them to the database
        {
            AppUser user = _userManager.FindByNameAsync(userContentVM.UserName).Result;
            Contents content = convertingVM.Contents;
            _contentsService.Add(content);

            UserContentsDto userContentsDto = new UserContentsDto();
            userContentsDto.Content = content;
            userContentsDto.User = user;
            _userContentsService.Add(userContentsDto);
        }

        public void EditContent(ConvertingVM convertingVM, int contentId)  //This method gets the data, user searching(string text), user information and adds them to the database
        {
            Contents content = new Contents();
            content = convertingVM.Contents;
            content.Id = contentId;
            _contentsService.Update(content);
        }

        public AppUser GetUser(string userId)
        {
            return _userManager.FindByIdAsync(userId).Result;
        }

        public AppUser GetUserByUserName(string userName)
        {
            return _userManager.FindByNameAsync(userName).Result;
        }

        public AppUser GetLoggedUser()
        {
            return _userManager.GetUserAsync(User).Result;
        }

        public List<UserContentListVM> GetUserSearchHistory(string userId)
        {
            List<UserContentListVM> userHistory = new List<UserContentListVM>();
            List<UserContentsDto> history = _userContentsService.GetList();
            foreach (UserContentsDto item in history)
            {
                if (item.UserId == GetUser(userId).Id)
                {
                    UserContentListVM userContentListVM = new UserContentListVM();
                    AppUser user = GetUser(userId);
                    Contents contents = _contentsService.GetById((int)item.ContentsId);
                    userContentListVM.UserName = user.UserName;
                    userContentListVM.FirstName = user.FirstName;
                    userContentListVM.LastName = user.LastName;
                    userContentListVM.ContentId = contents.Id;
                    userContentListVM.Translated = contents.translated;
                    userContentListVM.Text = contents.text;
                    userContentListVM.Translation = contents.translation;
                    userContentListVM.PhotoAddress = user.Photo;
                    userHistory.Add(userContentListVM);
                }
            }
            return userHistory;
        }
        #endregion

    }
}

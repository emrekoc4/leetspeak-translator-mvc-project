using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserForManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager<AppUser> _userManager { get; }
        public SignInManager<AppUser> _signInManager { get; }

        public UserForManager(IUserDal userDal, UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _userDal = userDal;
            _signInManager= signInManager;
        }

        public async Task <IdentityResult> Register(UserRegisterVM userRegisterVM)
        {
            AppUser appUser = new AppUser();
 
            appUser.UserName = userRegisterVM.UserName;
            appUser.FirstName = userRegisterVM.FirstName;
            appUser.LastName = userRegisterVM.LastName;
            appUser.Password = userRegisterVM.Password;
            IdentityResult result=   await _userManager.CreateAsync(appUser,userRegisterVM.Password);
          return result;
        }

        public async Task<SignInResult> LogIn(UserLoginVM userLoginVM)
        {
            if (userLoginVM.UserName!=null)
            {
                AppUser user = await _userManager.FindByNameAsync(userLoginVM.UserName);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                }
                SignInResult result = _signInManager.PasswordSignInAsync(user, userLoginVM.Password, userLoginVM.RememberMe, false).Result;
                return result;
            }
            return null;
        }
    }
}

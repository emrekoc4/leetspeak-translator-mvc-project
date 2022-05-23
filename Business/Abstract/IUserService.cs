using Entities.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        Task<IdentityResult> Register(UserRegisterVM userRegisterVM);
        Task<SignInResult> LogIn(UserLoginVM userLoginVM);
    }
}

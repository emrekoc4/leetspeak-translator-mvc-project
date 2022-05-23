using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.CustomValidation
{
    public class CustomPasswordValidator : IPasswordValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)
        {
            
            List<IdentityError> errors = new List<IdentityError>();
            if (password.ToLower().Contains(user.UserName.ToLower()))
            {
                errors.Add(new IdentityError() { Code = "PasswordContainsUsername", Description = "Password shouldn't be contain username." });
            }
            //if (password.ToLower().Contains(user.Email.ToLower()))  //if email wants to be used (currently not using)
            //{
            //    errors.Add(new IdentityError() { Code = "PasswordContainsEmail", Description = "Password shouldn't be contain EMail Address." });
            //}
            if (errors.Count == 0)
            {
                return Task.FromResult(IdentityResult.Success);
            }
            else
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }
        }
    }
}

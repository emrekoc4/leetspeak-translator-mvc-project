using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Entities.ViewModels
{
    public class UpdateUserVM  //In order for the user to make changes to his profile, both the old username and the old password are required. This model has been created so that old and new properties can be met in a single model.
    {
        [Required(ErrorMessage = "Current Username is required. Please type again.")]
        public string CurrentUserName { get; set; }
        [Required(ErrorMessage = "Username is required. Please type again.")]
        public string NewUserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFile Photo { get; set; }
        public string PhotoAddress { get; set; }
        [Required(ErrorMessage = "Current password is required. Please type again.")]
        public string CurrentPassword { get; set; }
        [Required(ErrorMessage = "Password is required. Please type again.")]
        public string NewPassword { get; set; }
    }
}

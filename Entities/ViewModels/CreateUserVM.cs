using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Entities.ViewModels
{
    public class CreateUserVM  //This VM is the VM that holds the required properties to create a user.
    {
        [Required(ErrorMessage = "Password is required. Please type again.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Username is required. Please type again.")]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IsAdmin { get; set; }
        public IFormFile Photo { get; set; }  
    }
}

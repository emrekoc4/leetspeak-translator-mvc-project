using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;



namespace Entities.ViewModels 
{
    public class UserRegisterVM //model used when registering

    {
        [Required(ErrorMessage = "Password is required. Please type again.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Username is required. Please type again.")]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFile Photo { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;


namespace Entities.ViewModels
{
    public class UserLoginVM //model used when logging in
    {
        [Required(ErrorMessage = "Password is required. Please type again.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Username is required. Please type again.")]
        public string UserName { get; set; }
        public bool RememberMe { get; set; }

    }
}

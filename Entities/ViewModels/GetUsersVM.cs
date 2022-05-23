using Entities.Concrete;

namespace Entities.ViewModels
{
    public class GetUsersVM : AppUser  //Allows users to be sent to ActionResults with role property
    {
        public string Role { get; set; }
        public string UserId { get; set; }
    }
}

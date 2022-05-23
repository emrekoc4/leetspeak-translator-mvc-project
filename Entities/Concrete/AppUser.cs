using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class AppUser : IdentityUser //This class is the class that defines the properties that users will carry. Properties such as username, password, Id are inherited from the IdentityUser class. The password property(that you can see among the properties below) is used to see the password in the database, the actual password is actually hashed by IdentityUser.
    {
        public AppUser()
        {
            UserContentsDtos = new HashSet<UserContentsDto>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; } //the property 
        public string Photo { get; set; }  //takes the address of the file to save the database
        public virtual ICollection<UserContentsDto> UserContentsDtos { get; set; } //junction table
    }
}

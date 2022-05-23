using Microsoft.AspNetCore.Identity;

namespace Entities.Concrete
{
    public class AppRole : IdentityRole //this class ensures that roles exist and are associated with users. It does this by inheriting from the microsoft identity.In this project there are two types of roles those are 'User' and 'Admin'.These roles are used in authorization.
    {
    }
}

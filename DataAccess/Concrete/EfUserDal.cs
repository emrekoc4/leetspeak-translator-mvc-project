using Core.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfUserDal : EfEntityRepositoryBase<AppUser,MyContext>, IUserDal
    {

    }
}

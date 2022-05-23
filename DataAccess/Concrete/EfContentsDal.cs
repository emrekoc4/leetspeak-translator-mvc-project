using Core.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfContentsDal : EfEntityRepositoryBase<Contents, MyContext>, IContentsDal
    {
    }
}

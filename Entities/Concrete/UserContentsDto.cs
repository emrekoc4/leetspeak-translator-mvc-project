using Entities.Abstract;

namespace Entities.Concrete
{
    public class UserContentsDto : BaseEntity  //This class is the class that allows us to keep track of which user made which call  *junction table*
    {
        public string UserId { get; set; }
        public int? ContentsId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual Contents Content { get; set; }
    }
}

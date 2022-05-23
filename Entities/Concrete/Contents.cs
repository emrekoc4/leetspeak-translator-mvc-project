using Entities.Abstract;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Contents : BaseEntity  //This class allows us to meet the information from the API and save it to the database
    {
        public Contents()
        {
            UserContentsDtos = new HashSet<UserContentsDto>();
        }
        public string translated { get; set; }
        public string text { get; set; }
        public string translation { get; set; }
        public virtual ICollection<UserContentsDto> UserContentsDtos { get; set; }  //junction table

    }
}

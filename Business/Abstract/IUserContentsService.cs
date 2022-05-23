using Entities.Concrete;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IUserContentsService
    {
        UserContentsDto GetByContentId(int contentsId);
        UserContentsDto GetByUserId(string userId);
        UserContentsDto GetByBothId(int contentsId, string userId);
        List<UserContentsDto> GetList();
        void Add(UserContentsDto userContent);
        void Update(UserContentsDto userContent);
        void Delete(UserContentsDto userContent);
    }
}

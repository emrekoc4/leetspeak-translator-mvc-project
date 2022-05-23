using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class UserContentsManager : IUserContentsService
    {
        private IUserContentsDal _userContentsDal;
        public UserContentsManager(IUserContentsDal userContentsDal)
        {
            _userContentsDal = userContentsDal;
        }

        public void Add(UserContentsDto userContent)
        {
            _userContentsDal.Add(userContent);
        }

        public void Delete(UserContentsDto userContent)
        {
            _userContentsDal.Delete(userContent);
        }

        public UserContentsDto GetByBothId(int contentId, string userId)
        {
            return _userContentsDal.Get(filter: x => x.ContentsId == contentId && x.UserId == userId).Result;
        }

        public UserContentsDto GetByContentId(int contentId)
        {
            return _userContentsDal.Get(filter: x => x.ContentsId == contentId).Result;
        }

        public UserContentsDto GetByUserId(string userId)
        {
            return _userContentsDal.Get(filter: x => x.UserId == userId).Result;

        }

        public List<UserContentsDto> GetList()
        {
            return _userContentsDal.GetList().Result.ToList();
        }

        public void Update(UserContentsDto userContent)
        {
            _userContentsDal.Update(userContent);
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class ContentsManager : IContentsService
    {
        private IContentsDal _contentsDal;
        public ContentsManager(IContentsDal contentsDal)
        {
            _contentsDal = contentsDal;
        }
        public void Add(Contents contents)
        {
            _contentsDal.Add(contents);
        }

        public void Delete(Contents contents)
        {
            _contentsDal.Delete(contents);
        }

        public Contents GetById(int contentsId)
        {
            return _contentsDal.Get(filter: x => x.Id == contentsId).Result;
        }

        public List<Contents> GetList()
        {
            return _contentsDal.GetList().Result.ToList();
        }

        public void Update(Contents contents)
        {
            _contentsDal.Update(contents);
        }
    }
}

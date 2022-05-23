using Entities.Concrete;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IContentsService
    {
        Contents GetById(int contentsId);
        List<Contents> GetList();
        void Add(Contents contents);
        void Update(Contents contents);
        void Delete(Contents contents);
    }
}

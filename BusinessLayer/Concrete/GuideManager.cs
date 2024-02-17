using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal _guidedal;

        public GuideManager(IGuideDal guidedal)
        {
            _guidedal = guidedal;
        }

        public void TAdd(Guide t)
        {
            _guidedal.Insert(t);
        }

        public void TChangeToStatusActive(int id)
        {
            _guidedal.ChangeToStatusActive(id);
        }

        public void TChangeToStatusPassive(int id)
        {
            _guidedal.ChangeToStatusPassive(id);
        }

        public void TDelete(Guide t)
        {
            _guidedal.Delete(t);
        }

        public Guide TGetById(int id)
        {
           return _guidedal.GetById(id);
        }

        public List<Guide> TGetList()
        {
            return _guidedal.GetList();
        }

        public void TUpdate(Guide t)
        {
            _guidedal.Update(t);
        }
    }
}

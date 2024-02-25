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
    public class ContactUsManager : IContacUsService
    {
        IContactUsDal _contacUsDal;

        public ContactUsManager(IContactUsDal contacUsDal)
        {
            _contacUsDal = contacUsDal;
        }

        public void TAdd(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public ContactUs TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetList()
        {
           return _contacUsDal.GetList();
        }

        public List<ContactUs> TGetListByFalse()
        {
            return _contacUsDal.GetListByFalse();
        }

        public List<ContactUs> TGetListByTrue()
        {
            return _contacUsDal.GetListByTrue();
        }

        public void TUpdate(ContactUs t)
        {
            throw new NotImplementedException();
        }
    }
}

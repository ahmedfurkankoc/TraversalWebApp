using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContacUsService : IGenericService<ContactUs>
    {
        List<ContactUs> TGetListByTrue();
        List<ContactUs> TGetListByFalse();
        void TContactUsStatusChangeToFalse(int id);
    }
}

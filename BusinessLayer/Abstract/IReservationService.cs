using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListReservationByAwaitApproval(int id);
        List<Reservation> GetListReservationByConfirm(int id);
        List<Reservation> GetListReservationByPast(int id);
    }
}

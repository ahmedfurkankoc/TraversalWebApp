﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListReservationByAwaitApproval(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListReservationByConfirm(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListReservationByPast(int id)
        {
            //using(var context = new Context())
            //{
            //    return context.Reservations.Include(x => x.Destination)
            //}
            throw new NotImplementedException();
        }
    }
}
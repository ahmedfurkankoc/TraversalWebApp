using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public Destination GetDestinationWithGuide(int id)
        {
            using (var context = new Context())
            {
                return context.Destinations.Where(x=>x.DestinationId == id).Include(x => x.Guide).FirstOrDefault();
            }
        }

        public List<Destination> GetLastDestinations()
        {
            using(var context = new Context())
            {
                var values = context.Destinations.Take(4).OrderByDescending(x => x.DestinationId).ToList();

                return values;
            }
        }
    }
}

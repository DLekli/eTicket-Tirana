using eTicket.Data.Base;
using eTicket.Models;

namespace eTicket.Data.Services
{
    public class CinemasServices : EntityBaseRepository<Cinema>,ICienmasServices
    {
        public CinemasServices(AppDbContext context):base(context)
        {
            
        }
    }
}

using eTicket.Data.Base;
using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Services
{
    public class ActorsServices : EntityBaseRepository<Actor>, IActorsServices
    {
       
        public ActorsServices(AppDbContext context) : base(context) { }
       
     
    }
}

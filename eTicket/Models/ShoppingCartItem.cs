using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int Amount { get; set; }

        //We are going to clean up the database after the order is completed 
        public string ShoppingCartId { get; set; }
    }
}

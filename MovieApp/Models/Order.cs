using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public EShopApplicationUser? User { get; set; }
        public virtual ICollection<TicketInOrder>? TicketsInOrder { get; set; }
    }
}

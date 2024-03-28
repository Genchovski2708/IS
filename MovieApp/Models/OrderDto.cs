namespace MovieApp.Models
{
    public class OrderDto
    {
        public List<TicketInOrder>? Tickets { get; set; }
        public double? TotalPrice { get; set; }
    }
}

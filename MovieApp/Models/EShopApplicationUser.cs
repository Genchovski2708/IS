﻿using Microsoft.AspNetCore.Identity;

namespace MovieApp.Models
{
    public class EShopApplicationUser : IdentityUser
    {
        public EShopApplicationUser()
        {
            Order = new Order
            {
                UserId = this.Id,
                User = this,
                TicketsInOrder = new List<TicketInOrder>()
            };
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Ticket> MyTickets { get; set; }
        public virtual Order Order { get; set; }

    }

}
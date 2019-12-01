using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgency.DatabaseAccess.Entities
{
    internal class Order
    {
        public int Id { get; set; }

        public int OfferId { get; set; }

        public int UserId { get; set; }

        public int ManagerId { get; set; }
    }
}

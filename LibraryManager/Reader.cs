using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManager
{
    public class Reader
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronimic { get; set; }
        public DateTime? DateBith { get; set; }
        public int? PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }

        public int? DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
    }
}

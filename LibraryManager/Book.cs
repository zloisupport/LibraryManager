using System;
using System.Collections.Generic;

namespace LibraryManager
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public int? Amount { get; set; }
        public decimal? Price { get; set; }



        public virtual ICollection<Delivery> Deliveries { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

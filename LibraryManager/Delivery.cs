using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManager
{
    public class Delivery
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public int? ReaderId { get; set; }
        public DateTime? DateIssue { get; set; }
        public DateTime? DateReturn { get; set; }
        
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Reader> Readers { get; set; }

    }
}

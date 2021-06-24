using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManager
{
    public class BookReturn
    {
        public int Id { get; set; }

        public int ReaderId { get; set; }
        public virtual Reader Reader { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public DateTime? DateReturn { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace LibraryManager
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() :
            base("DefaultConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
    }
}

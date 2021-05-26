using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManager
{
    internal class DataAccess
    {
        private static AppDbContext context;
        static DataAccess()
        {
            DataAccess.context = new AppDbContext();
        }

        public static int GetReaderId { get; set; }
        public static int GetBookId { get; set; }

        public static List<Book> GetBooks()
        {

            using (AppDbContext db = new AppDbContext())
            {
                return db.Books.ToList();
            }

        }

        public static List<Reader> GetReaders()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Readers.ToList<Reader>();
            }
        }

        public static List<Delivery> GetDeliveries()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Deliveries.ToList<Delivery>();
            }
        }

        internal static void AddReader(Reader reader)
        {
            DataAccess.context.Readers.Add(reader);
            DataAccess.context.SaveChanges();
        }

        public static void UpdateReader(Reader reader)
        {


            DataAccess.context.Entry(reader).State = System.Data.Entity.EntityState.Modified;
            DataAccess.context.SaveChanges();



        }

        public static void UpdateBook(Book book)
        {
            DataAccess.context.SaveChanges();
        }

        internal static void DeleteReader(Reader _reader)
        {
            DataAccess.context.SaveChanges();
        }

    }
}

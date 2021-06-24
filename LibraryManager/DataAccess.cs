using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace LibraryManager
{
    internal class DataAccess
    {
           private static AppDbContext context;

        static DataAccess()
        {
            context = new AppDbContext();
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
        
        public  List<Delivery> GeDelivery()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Deliveries.ToList<Delivery>();
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

            return DataAccess.context.Deliveries.ToList<Delivery>();
        
        }

        internal static void AddReader(Reader reader)
        {
            context.Readers.Add(reader);
            context.SaveChanges();
        }

        public static void UpdateReader(Reader reader)
        {


            context.Entry(reader).State = EntityState.Modified;
            context.SaveChanges();


        }

        public static void UpdateEmployee(Reader reader)
        {
           context.SaveChanges();
        }
        public static void UpdateBook(Book book)
        {
            DataAccess.context.SaveChanges();
        }

        public static string FindReaderId(Reader reader)
        {
            using (AppDbContext db = new AppDbContext())
            {
               var id= db.Readers.Find(reader);
                return id.ToString();
            }
        }

        internal static void DeleteReader(Reader _reader)
        {
            DataAccess.context.SaveChanges();
        }

    }
}

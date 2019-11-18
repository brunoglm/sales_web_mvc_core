using SalesWebMvcCore.Models;
using SalesWebMvcCore.Models.Enums;
using System;
using System.Linq;

namespace SalesWebMvcCore.Data
{
    public class SeedingService
    {
        private SalesWebMvcCoreContext _context;

        public SeedingService(SalesWebMvcCoreContext context)
        {
            _context = context; 
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // O Banco de dados já foi populado. 
            }

            Department d1 = new Department(1, "Computers"); 
            Department d2 = new Department(2, "Eletronics"); 
            Department d3 = new Department(3, "Fashion"); 
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998,4,21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979,12,31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988,1,15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993,11,30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000,1,9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "alex_pink@gmail.com", new DateTime(1997,3,4), 3000.0, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 09, 24), 11000.0, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2018, 09, 23), 11000.0, SaleStatus.Billed, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2018, 09, 22), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2018, 09, 21), 11000.0, SaleStatus.Billed, s5);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2018, 09, 20), 11000.0, SaleStatus.Billed, s6);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2018, 09, 19), 11000.0, SaleStatus.Billed, s1);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2018, 09, 18), 11000.0, SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8);

            _context.SaveChanges(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;



namespace BookStoreLibraryFinalProject
{
      public class BookIInfos : DbContext //Data Source=(localdb)\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        {
        public IEnumerable<object> Reviewss;

        public DbSet<Book> Books { get; set; }
        public DbSet<Reviewss> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //Data Source=(localdb)\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            
                optionBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=ReviewsLog;Trusted_Connection=True;MultipleActiveResultSets=true");
            //(localdb)\ProjectModels
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reviewss>().HasData
                (
                    new Reviewss {  BookID = 1, ReviewID = 1, ReviewText = "WOWWO" },
                    new Reviewss { BookID = 2,  ReviewID = 2, ReviewText = "WOWWO3" }


                );
            
            
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace FINAL_PROJECT
{
    
        class ClsBookInfos : DbContext 
        {
       

        public DbSet<Books> Books { get; set; }
       // public DbSet<ReviewsT> Reviews { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Data Source=(localdb)\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BooksDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            //(localdb)\ProjectModels
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Books>().HasData
                (
                  new Books { BookId = 1, Isbn = "978-0-321-93251-7", AuthorName = "Jeffrey Archer", BookName = "The Prodigal Daughter", PublishYear = 1982, Img = "prodigal.jpg" },
                  new Books { BookId = 2, Isbn = "978-0-312-93351-7", AuthorName = "Jeffrey Archer", BookName = "Shall We Tell the President?", PublishYear = 1977, Img = "ShallWeTellThePres.jpg" },

                    new Books { BookId = 3, Isbn = "978-0-307-70018-6", AuthorName = "Paulo Coelho", BookName = "Aleph", PublishYear = 2011, Img = "aleph.jpg" },
                    new Books { BookId = 4, Isbn = "978-0-06-083281-0", AuthorName = "Paulo Coelho", BookName = "The Zahir", PublishYear = 2006, Img = "The_Zahir_(novel).jpg" },
                    new Books { BookId = 5, Isbn = "978-0-06-251279-6", AuthorName = "Paulo Coelho", BookName = "Eleven Minutes Publisher", PublishYear = 2005, Img = "ElevenMin.jpg" },
                    new Books { BookId = 6, Isbn = "978-0-06-251291-8", AuthorName = "Paulo Coelho", BookName = "The Valkyries", PublishYear = 1995, Img = "TheValkyries.jpg" },
                     new Books { BookId = 7, Isbn = "978-0-06-250218-6", AuthorName = "Paulo Coelho", BookName = "The Alchemist", PublishYear = 1995, Img = "TheAlchemist.jpg" },
                     new Books { BookId = 8, Isbn = "978-0-06-133881-6", AuthorName = "Paulo Coelho", BookName = "The Witch of Portobello", PublishYear = 2008, Img = "TheWitchofPortobello.jpg" },
                    
                     
                     //StephenKing
                     new Books {BookId = 9, Isbn = "978-1-587-67679-6", AuthorName = "Stephen King", BookName = "Flight or Fright", PublishYear = 2018, Img = "flight-or-fright.jpg" },
                     new Books { BookId =10, Isbn = "978-0-891-01127-9", AuthorName = "Stephen King", BookName = "Hearts in Suspension", PublishYear = 2016, Img = "Hearts-in-Suspension-cover.jpg" },
                     new Books { BookId = 11, Isbn = "978-1-534-40123-5", AuthorName = "Stephen King", BookName = "Charlie the Choo-Choo", PublishYear = 2016, Img = "Charliethe Choo-Choo.jpg" },
                     new Books { BookId = 12, Isbn = "978-1-579-40235-8", AuthorName = "Stephen King", BookName = "Guns", PublishYear = 2013,  Img = "Stephen_King_-_Guns.jpg" },
                     new Books { BookId = 13, Isbn = "978-1-401-22830-9", AuthorName = "Stephen King", BookName = "American Vampire", PublishYear = 2010, Img = "AmericanVamp.jpg" },
                     new Books { BookId = 14, Isbn = "978-1-451-60821-2", AuthorName = "Stephen King", BookName = "Blockade Billy", PublishYear = 2010, Img = "Blockade_Billy.jpg" },
                     new Books { BookId = 15, Isbn = "978-1-416-59236-5", AuthorName = "Stephen King", BookName = "The Plant", PublishYear = 2000, Img = "Plantcover.jpg" },
                     new Books { BookId = 16, Isbn = "978-0-671-03264-7", AuthorName = "Stephen King", BookName = "Storm of the Century", PublishYear = 1999, Img = "Stormcentury.jpg" },
                     new Books { BookId = 17, Isbn = "978-0-671-04617-0", AuthorName = "Stephen King", BookName = "Blood and Smoke", PublishYear = 1999, Img = "Bloodnsmoke.jpg" },
                     new Books { BookId = 18, Isbn = "978-0-452-25380-3", AuthorName = "Stephen King", BookName = "Creepshow", PublishYear = 1982, Img = "Creepshow_Plume.jpg" },
                     new Books { BookId = 19, Isbn = "978-0-453-00507-4", AuthorName = "Stephen King", BookName = "The Bachman Books", PublishYear = 1985, Img = "The_Bachman_Books(2).jpg" }



                     ) ;
            
            
            
        }

      

    }
}

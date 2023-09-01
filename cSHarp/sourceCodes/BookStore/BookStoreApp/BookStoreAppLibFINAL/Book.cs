using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreLibraryFinalProject
{
    public class Book
    { 

        // getters and setters
        public int? BookId { get; set; }
        public string? Isbn { get; set; }
        public string? AuthorName { get; set; }
        public string? BookTitle { get; set; }

        public int? PublishYear { get; set; }
        public string? img { get; set; }

        //no arg constructor
        public Book() { }
    }
}

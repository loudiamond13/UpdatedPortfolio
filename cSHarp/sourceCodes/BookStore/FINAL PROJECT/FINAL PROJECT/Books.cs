
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT
{

    public class Books
    {

        // getters and setters
        [Key]
        public int BookId { get; set; }
        public string Isbn { get; set; }
        public string AuthorName { get; set; }
        public string BookName { get; set; }

        public int PublishYear { get; set; }
        public string? Img { get; set; }

        //no arg constructor
        public Books() { }
    }
}

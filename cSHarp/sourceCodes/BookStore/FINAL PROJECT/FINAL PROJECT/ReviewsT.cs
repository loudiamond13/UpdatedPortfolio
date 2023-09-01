using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FINAL_PROJECT
{
     public class ReviewsT 


    {


        
        public int BookNum { get; set; }
        public int ReviewID { get; set; }
        public string ReviewText { get; set; } = string.Empty;


        public ReviewsT() { }

      
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Bookstore.Data.Models
{
    
    
    public class Book
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public int PublicationYears { get; set; }

        [Required]
        public bool IsAvailaible { get; set; }

        [Required]
        public string CallNumber { get; set; }
    }
}

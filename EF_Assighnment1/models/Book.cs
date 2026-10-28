using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF_Assighnment1.models
{
    internal class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ISBN { get; set; }


        [Precision(10, 3)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(50)]
        public int NumOfPage { get; set; }
        public DateTime Year { get; set; }
    }
}

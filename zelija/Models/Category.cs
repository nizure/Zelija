using System;
using System.ComponentModel.DataAnnotations;

namespace zelija.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime Display { get; set; }
        
        //public decimal Price { get; set; }
    }
}
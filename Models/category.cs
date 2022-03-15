using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DateMe.Models
{
    //Create a new model for the category for the data normalization. CategoryId is the primary key.
    public class category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public string Category { get; set; }
         
    }
}

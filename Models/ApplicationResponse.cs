using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    //Add validation requirements
    public class ApplicationResponse
    {   [Key]
        [Required]
        public int MovieId {get; set;}
        [Required]
        public string Title { get; set; }
        [Required]
        public ushort Year { get; set; }
        [Required]
        public string DirectorFirstName { get; set; }
        [Required]
        public string DirectorLastName { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        //Build Foreign Key Relationship 
        [Required]
        public int CategoryId { get; set; }
        public category Category { get; set; }

    }
}

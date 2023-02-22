using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class SubmitMovie
    {
        // make the MovieID the primary key
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public int ReleaseYear { get; set; }
        public string Notes { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [Required]
        public string Rating { get; set; }

        // foreign key
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

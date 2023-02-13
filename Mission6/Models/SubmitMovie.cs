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
        public string Title { get; set; }
        public string Category { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Notes { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Rating { get; set; }

    }
}

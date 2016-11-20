using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace qwertyuiop.Models
{
    public class UserWatchedFilm
    {
        [Required]
        public Film Film { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Range(1, 10)]
        [Required]
        public int Mark { get; set; }
    }
}
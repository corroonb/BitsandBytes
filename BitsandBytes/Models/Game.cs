using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitsandBytes.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Format { get; set; }

        [StringLength(30)]
        public string Publisher { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Discussion> Discussions { get; set; }
    }
}
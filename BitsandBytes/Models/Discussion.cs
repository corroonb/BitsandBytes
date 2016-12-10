using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace BitsandBytes.Models
{
    public class Discussion
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1024)]
        public string Body { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name ="Poster Name")]
        public string PosterName { get; set; }

        [Required]
        public DateTime PostDate { get; set; }

        public int GameId { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitsandBytes.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1024)]
        public string Body { get; set; }

        [Required]
        [Display(Name = "Reviewer Name")]
        public string ReviewerName { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }

        public int GameId { get; set; }
       
    }
}
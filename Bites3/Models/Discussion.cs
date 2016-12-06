using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bites3.Models
{
    public class Discussion
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1024)]
        public string Body { get; set; }

        [Required]
        [StringLength(30)]
        public string PosterName { get; set; }



        public int GameId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bites3.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string ReviewerName { get; set; }

        

        public int GameId { get; set; }
       
    }
}
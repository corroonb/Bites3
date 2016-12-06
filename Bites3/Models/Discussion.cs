using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bites3.Models
{
    public class Discussion
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string PosterName { get; set; }



        public int GameId { get; set; }
    }
}
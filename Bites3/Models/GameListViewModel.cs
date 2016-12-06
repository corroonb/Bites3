using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bites3.Models
{
    public class GameListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Format { get; set; }
        public string Publisher { get; set; }
        public int CountOfReviews { get; set; }
    }
}
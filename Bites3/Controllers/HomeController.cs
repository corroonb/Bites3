using Bites3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bites3.Controllers
{
    public class HomeController : Controller
    {
        BitesDb _db = new BitesDb();

        public ActionResult Index(string searchTerm = null)
        {


            var model =
                    _db.Games
                    .OrderByDescending(r => r.Name)
                    .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                    .Select( r => new GameListViewModel
                            {
                                Id = r.Id,
                                Name = r.Name,
                                Format = r.Format,
                                Publisher = r.Publisher,
                                CountOfReviews = r.Reviews.Count()
                            }
                    );

           



            //var model =
            //    from r in _db.Games
            //    orderby r.Name ascending
            //    select new GameListViewModel
            //    {
            //        GameID = r.GameID,
            //        Name = r.Name,
            //        Format = r.Format,
            //        ReleaseDate = r.ReleaseDate,
            //    };

            //var model =
            //     _db.Games
            //     .OrderByDescending(r => r.Name)
            //     .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
            //     .Select(r => new GameListViewModel
            //     {
            //         GameID = r.Id,
            //         Name = r.Name,
            //         Format = r.Format

            //     });


            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bits and Bytes";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get in touch!";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
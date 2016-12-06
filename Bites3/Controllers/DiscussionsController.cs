using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bites3.Models;

namespace Bites3.Controllers
{
    public class DiscussionsController : Controller
    {
        BitesDb _db = new BitesDb();

        public ActionResult Index([Bind(Prefix = "id")] int gameId)
        {
            var game = _db.Games.Find(gameId);
            if (game != null)
            {
                return View(game);
            }

            return HttpNotFound();
        }

        // GET: Discussions
        //public ActionResult Index()
        //{
        //    return View(db.Discussions.ToList());
        //}

        // GET: Discussions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Discussion discussion = _db.Discussions.Find(id);
            if (discussion == null)
            {
                return HttpNotFound();
            }
            return View(discussion);
        }

        // GET: Discussions/Create
        [HttpGet]
        public ActionResult Create(int GameId)
        {
            return View();
        }

        // POST: Discussions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Discussion discussion)
        {
            if (ModelState.IsValid)
            {
                _db.Discussions.Add(discussion);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = discussion.GameId });
            }

            return View(discussion);
        }

        // GET: Discussions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Discussion discussion = _db.Discussions.Find(id);
            if (discussion == null)
            {
                return HttpNotFound();
            }
            return View(discussion);
        }

        // POST: Discussions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Discussion discussion)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(discussion).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = discussion.GameId });
            }
            return View(discussion);
        }

        // GET: Discussions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Discussion discussion = _db.Discussions.Find(id);
            if (discussion == null)
            {
                return HttpNotFound();
            }
            return View(discussion);
        }

        // POST: Discussions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Discussion discussion = _db.Discussions.Find(id);
            _db.Discussions.Remove(discussion);
            _db.SaveChanges();
            return RedirectToAction("Index", new { id = discussion.GameId });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

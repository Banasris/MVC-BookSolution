using System;
using System.Collections.Generic;
using System.Linq;
using BookWeb.Models;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace BookWeb.Controllers
{
    public class ReviewController : Controller
    {
        //
        // GET: /Review/
        BookContext _db = new BookContext();

        public ActionResult ReviewBook()
        {
            ViewBag.review = "Reviews Of All Books";
            var model = (from r in _db.reviews
                         join b in _db.books on r.bookid equals b.bookid
                         select new ReviewBookModel
                         {
                            reviewername=r.reviewername,
                            rating=r.rating,
                            title=b.title,
                            picture=b.picture,
                            dateofreview=r.dateodreview,
                            body=r.body
                         }).ToList();
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db!= null)
            {
                _db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}

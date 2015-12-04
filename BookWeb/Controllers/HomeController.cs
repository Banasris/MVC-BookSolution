using System;
using System.Collections.Generic;
using System.Linq;
using BookWeb.Models;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace BookWeb.Controllers
{
    public class HomeController : Controller
    {

        BookContext _db = new BookContext();
        [HttpGet]
        public ActionResult Index(string SearchTerm, int page=1)
        {
            var model =
                (from b in _db.books
                 orderby b.bookid ascending
                 select new BookSearchViewModel
                 {
                     id = b.bookid,
                     picture = b.picture
                 }).Take(12);

            if (!String.IsNullOrEmpty(SearchTerm))
            {
                ViewBag.CurrentFilter = SearchTerm;
                var bookName =
                (from b in _db.books
                 join ab in _db.authorbooks on b.bookid equals ab.bookid
                 join a in _db.authors on ab.authorid equals a.authorid
                 where (b.title.Contains(SearchTerm))
                 orderby b.bookid ascending
                 select new BookSearchViewModel
                 {
                     id = b.bookid,
                     title = b.title,
                     name = a.name,
                     publisher = b.publisher,
                     picture = b.picture
                 }).ToPagedList(page, 4);
               // return PartialView("_SearchBook", bookName);
               
                    return View("Search", bookName);
              
                 }
           // return View(model);
           
            return View(model.ToPagedList(page,4));
        }
        
       //code returns lists of book of given Genre//
        public ActionResult Genre(string genrename, int page = 1)
       {
            ViewBag.CurrentGenre = genrename;
            var bookdetail =
                (from b in _db.books
                 join ab in _db.authorbooks on b.bookid equals ab.bookid
                 join a in _db.authors on ab.authorid equals a.authorid
                 where (b.booktype == genrename)
                 orderby b.bookid ascending
                 select new BookSearchViewModel
                 {
                     id = b.bookid,
                     title = b.title,
                     name = a.name,
                     publisher = b.publisher,
                     picture=b.picture
                 }).ToPagedList(page, 4);
           // return PartialView("_SearchBook", bookdetail);
            return View("Search", bookdetail);

        }

        public ActionResult Image(String idOfBook)
        {
            ViewBag.Message = "Book Picture";
            var bookimage =
               (from b in _db.books
                join ab in _db.authorbooks on b.bookid equals ab.bookid
                join a in _db.authors on ab.authorid equals a.authorid
                where (b.bookid == idOfBook.ToString())
                orderby b.bookid ascending
                select new BookSearchViewModel
                {
                    
                    title = b.title,
                    name = a.name,
                    publisher = b.publisher,
                    picture = b.picture
                }).SingleOrDefault();

            return View("Image", bookimage);
            

           // return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Choose Book";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

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

using CustomModel01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomModel01.Controllers
{
    public class BookController : Controller
    {
        [HttpGet]
        // GET: Book
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                return View(book);
            }
            return View();
        }
    }
}
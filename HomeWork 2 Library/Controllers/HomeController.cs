using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork_1_Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_1_Library.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddBook()
        {
            ViewData["Message"] = "Add a Book";

            return View();
        }

        [HttpPost]
        public ViewResult AddBook(BooksModel NewBook)
        {
            if (ModelState.IsValid)
            {
                Repository.AddBooks(NewBook);
                return View("MyLibrary", Repository.BooksRepo);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }

        public IActionResult MyLibrary()
        {
            ViewData["Message"] = "View Your Library";

            return View(Repository.BooksRepo);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

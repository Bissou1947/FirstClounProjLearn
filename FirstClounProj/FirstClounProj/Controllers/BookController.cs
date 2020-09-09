using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using FirstClounProj.Models;
using FirstClounProj.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FirstClounProj.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _newBookRepository = null;
        public BookController(BookRepository bookRepository) {
            _newBookRepository = bookRepository;
        }
        public ViewResult AddNewBook(bool check=false,int bookId=0)
        {
            ViewBag.CheckSuccess = check;
            ViewBag.GetBookId = bookId;
            return View();
        }
        [HttpPost]
        public IActionResult AddNewBook(BookModel NewBook)
        {
            int value=_newBookRepository.AddNewBook(NewBook);
            if (value>0) {
                return RedirectToAction("AddNewBook",new { check=true, bookId=value });
            }
            return View();
        }

        public ViewResult GetALlBooks()
        {
            var bookList = _newBookRepository.GetALlBooks();
            return View(bookList);
        }
        [Route("BookDetails",Name = "BookDetails")]
        public ViewResult GetBookById(int id,string nameBook)
        {
            var bookById = _newBookRepository.GetBookById(id);
            return View(bookById);
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return _newBookRepository.SearchBook(title, authorName);
        }

        public ViewResult TestDynamicView()
        {
            //var bookById = _newBookRepository.GetBookById(id);
            dynamic data = new ExpandoObject();
            data.book = _newBookRepository.GetBookById(1);
            data.name = "Bissou";
            return View(data);
        }
    }
}

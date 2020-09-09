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
        public async Task<IActionResult> AddNewBook(BookModel NewBook)
        {
            int value=await _newBookRepository.AddNewBook(NewBook);
            if (value>0) {
                return RedirectToAction("AddNewBook",new { check=true, bookId=value });
            }
            return View();
        }

        public async Task<ViewResult> GetALlBooks()
        {
            var bookList =await _newBookRepository.GetALlBooks();
            return View(bookList);
        }
        [Route("BookDetails",Name = "BookDetails")]
        public async Task<ViewResult> GetBookById(int id,string nameBook)
        {
            var bookById = await _newBookRepository.GetBookById(id);
            return View(bookById);
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return _newBookRepository.SearchBook(title, authorName);
        }

        public async Task<ViewResult> TestDynamicView()
        {
            //var bookById = _newBookRepository.GetBookById(id);
            dynamic data = new ExpandoObject();
            data.book = await _newBookRepository.GetBookById(1);
            data.name = "Bissou";
            return View(data);
        }
    }
}

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
        public BookController() {
            _newBookRepository = new BookRepository();
        }

        public ViewResult GetALlBooks()
        {
            var bookList = _newBookRepository.GetALlBooks();
            return View(bookList);
        }

        public ViewResult GetBookById(int id)
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

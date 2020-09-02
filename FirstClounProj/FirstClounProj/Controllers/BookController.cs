using System;
using System.Collections.Generic;
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

        public List<BookModel> GetALlBooks()
        {
            return _newBookRepository.GetALlBooks();
        }

        public BookModel GetBookById(int id)
        {
            return _newBookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return _newBookRepository.SearchBook(title, authorName);
        }

    }
}

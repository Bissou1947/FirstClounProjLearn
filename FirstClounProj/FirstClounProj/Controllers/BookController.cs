using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using FirstClounProj.Models;
using FirstClounProj.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

            //ViewBag.DDBL = new SelectList(_newBookRepository.bookLangPublic(), "bookLanguageId", "bookLanguageName");

            //ViewBag.DDBL = _newBookRepository.bookLangPublic().Select(a => new SelectListItem()
            //{
            //    Text = a.bookLanguageName,
            //    Value = a.bookLanguageId.ToString()
            //}).ToList();

            //var group1 = new SelectListGroup() { Name = "group1" };
            //var group2 = new SelectListGroup() { Name = "group2", Disabled = true };
            //var group3 = new SelectListGroup() { Name = "group3" };

            //ViewBag.DDBL = new List<SelectListItem>() {
            //    new SelectListItem(){Text="arabic1",Value="1",Group=group1},
            //    new SelectListItem(){Text="arabic12",Value="2",Group=group1 },
            //    new SelectListItem(){Text="arabic13",Value="3" ,Group=group2},
            //    new SelectListItem(){Text="arabic14",Value="4",Group=group2},
            //    new SelectListItem(){Text="arabic15",Value="5",Group=group3 },
            //    new SelectListItem(){Text="arabic16",Value="6" ,Group=group3}
            //};

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel NewBook)
        {
            if (ModelState.IsValid) {
                int value = await _newBookRepository.AddNewBook(NewBook);
                if (value > 0)
                {
                    return RedirectToAction("AddNewBook", new { check = true, bookId = value });
                }
            }

            //ViewBag.DDBL = new SelectList(_newBookRepository.bookLangPublic(), "bookLanguageId", "bookLanguageName");

            //ViewBag.DDBL = _newBookRepository.bookLangPublic().Select(a => new SelectListItem()
            //{
            //    Text = a.bookLanguageName,
            //    Value = a.bookLanguageId.ToString()
            //}).ToList();

            //var group1 = new SelectListGroup() { Name = "group1" };
            //var group2 = new SelectListGroup() { Name = "group2",Disabled=true };
            //var group3 = new SelectListGroup() { Name = "group3" };

            //ViewBag.DDBL = new List<SelectListItem>() {
            //    new SelectListItem(){Text="arabic1",Value="1",Group=group1},
            //    new SelectListItem(){Text="arabic12",Value="2",Group=group1 },
            //    new SelectListItem(){Text="arabic13",Value="3" ,Group=group2},
            //    new SelectListItem(){Text="arabic14",Value="4",Group=group2},
            //    new SelectListItem(){Text="arabic15",Value="5",Group=group3 },
            //    new SelectListItem(){Text="arabic16",Value="6" ,Group=group3}
            //};

            ModelState.AddModelError("","Please fill the Errors fields");
            return View(NewBook);
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

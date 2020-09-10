using FirstClounProj.Data;
using FirstClounProj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Repository
{
    public class BookRepository
    {
        private readonly FirstClounProjDbContext _context = null;
        public BookRepository(FirstClounProjDbContext context) {
            _context = context;
        }
        public async Task<int> AddNewBook(BookModel NewBook)
        {
            var newB = new Books() { 
            bookAuthor=NewBook.bookAuthor,
            bookCategory=NewBook.bookCategory,
            bookDescription=NewBook.bookDescription,
            bookLanguage=NewBook.bookLanguage1.ToString(),
            bookTitle=NewBook.bookTitle,
            bookTotalPages=NewBook.bookTotalPages.HasValue? NewBook.bookTotalPages.Value:0,
            createdDate=DateTime.UtcNow,
            updateDate=DateTime.UtcNow
            };
           await _context.Books.AddAsync(newB);
           await _context.SaveChangesAsync();
           return newB.bookId;
        }
        public async Task<List<BookModel>> GetALlBooks() {
            var booksToBookModel = new List<BookModel>();
            var allBooksDB =await _context.Books.ToListAsync();
            if (allBooksDB?.Any() == true) {
                foreach (var book in allBooksDB)
                {
                    booksToBookModel.Add(new BookModel()
                    {
                        bookId=book.bookId,
                        bookAuthor = book.bookAuthor,
                        bookCategory = book.bookCategory,
                        bookDescription = book.bookDescription,
                        bookLanguage = book.bookLanguage,
                        bookTitle = book.bookTitle,
                        bookTotalPages = book.bookTotalPages,
                        createdDate = book.createdDate,
                        updateDate = book.updateDate
                    }
                    );
                }
                return booksToBookModel;
            }
            return null;
        }

        public async Task<BookModel> GetBookById(int id)
        {
            var getBookDB = await _context.Books.FindAsync(id);
            if (getBookDB != null) {
                var booksToBookModel = new BookModel()
                {   bookId = getBookDB.bookId,
                    bookAuthor = getBookDB.bookAuthor,
                    bookCategory = getBookDB.bookCategory,
                    bookDescription = getBookDB.bookDescription,
                    bookLanguage = getBookDB.bookLanguage,
                    bookTitle = getBookDB.bookTitle,
                    bookTotalPages = getBookDB.bookTotalPages,
                    createdDate = getBookDB.createdDate,
                    updateDate = getBookDB.updateDate
                };
                return booksToBookModel;
            }
            return null;
        }

        public List<BookModel> SearchBook(string title,string authorName)
        {
            return SourceOfInformattions().Where(a=>a.bookTitle.Contains(title) || a.bookAuthor.Contains(authorName)).ToList();
        }

        private List<BookModel> SourceOfInformattions() {
            return new List<BookModel>()
            {
                new BookModel(){bookAuthor="Nassir Al-alem",bookTitle="hearts years",bookId=1 ,bookDescription="Some Description1",bookCategory="Reality",bookLanguage="Arabic",bookTotalPages=100},
                 new BookModel(){bookAuthor="Bassil Al-alem",bookTitle="C# Learning",bookId=2 ,bookDescription="Some Description2",bookCategory="Sience",bookLanguage="Turkish",bookTotalPages=250},
                  new BookModel(){bookAuthor="Laytgh Al-alem",bookTitle="Econimic",bookId=3 ,bookDescription="Some Description3",bookCategory="Econimic",bookLanguage="Pakistan",bookTotalPages=150},
                   new BookModel(){bookAuthor="Saba Al-alem",bookTitle="Humanity rights",bookId=4 ,bookDescription="Some Description4",bookCategory="Humanity",bookLanguage="Afhnistan",bookTotalPages=350},
                    new BookModel(){bookAuthor="Majd Al-alem",bookTitle="Communications",bookId=5 ,bookDescription="Some Description5",bookCategory="Sience",bookLanguage="Arabic",bookTotalPages=200},
                     new BookModel(){bookAuthor="Bassima Al-alem",bookTitle="English",bookId=6 ,bookDescription="Some Description6",bookCategory="Learning",bookLanguage="Enflish",bookTotalPages=50}
            };
        }


        //................For Dropdawn Book Laguage..........................
        public List<bookLanguageModel> bookLangPublic()
        {
            return  bookLangPrivate();
        }
        private List<bookLanguageModel> bookLangPrivate()
        {
            return new List<bookLanguageModel>()
            {
                new bookLanguageModel(){bookLanguageId=1,bookLanguageName="Arabic" },
                new bookLanguageModel(){bookLanguageId=2,bookLanguageName="Turkish"  },
                new bookLanguageModel(){ bookLanguageId=3,bookLanguageName="Pakistan" }
            };
        }
    }
}

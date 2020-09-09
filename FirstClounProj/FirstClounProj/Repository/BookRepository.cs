using FirstClounProj.Data;
using FirstClounProj.Models;
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
            bookLanguage=NewBook.bookLanguage,
            bookTitle=NewBook.bookTitle,
            bookTotalPages=NewBook.bookTotalPages,
            createdDate=DateTime.UtcNow,
            updateDate=DateTime.UtcNow
            };
           await _context.Books.AddAsync(newB);
           await _context.SaveChangesAsync();
           return newB.bookId;
        }
        public List<BookModel> GetALlBooks() {
            return SourceOfInformattions();
        }

        public BookModel GetBookById(int id)
        {
            return SourceOfInformattions().Where(a => a.bookId == id).FirstOrDefault();
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
    }
}

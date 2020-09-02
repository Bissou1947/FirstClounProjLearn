using FirstClounProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Repository
{
    public class BookRepository
    {
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
                new BookModel(){bookAuthor="Nassir Al-alem",bookTitle="hearts years",bookId=1 },
                 new BookModel(){bookAuthor="Bassil Al-alem",bookTitle="C# Learning",bookId=2 },
                  new BookModel(){bookAuthor="Laytgh Al-alem",bookTitle="Econimic",bookId=3 },
                   new BookModel(){bookAuthor="Saba Al-alem",bookTitle="Humaity rights",bookId=4 }
            };
        }
    }
}

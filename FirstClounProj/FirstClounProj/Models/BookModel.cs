using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Models
{
    public class BookModel
    {
        public int bookId { get; set; }
        public string bookTitle { get; set; }
        public string bookAuthor { get; set; }
        public string bookDescription { get; set; }
        public string bookCategory { get; set; }
        public int bookTotalPages { get; set; }
        public string bookLanguage { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? updateDate { get; set; }
    }
}

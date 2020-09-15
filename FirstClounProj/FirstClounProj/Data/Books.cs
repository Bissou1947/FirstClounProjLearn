using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Data
{
    public class Books
    {
        [Key]
        public int bookId { get; set; }
        public string bookTitle { get; set; }
        public string bookAuthor { get; set; }
        public string bookDescription { get; set; }
        public string bookCategory { get; set; }
        public int bookTotalPages { get; set; }
        
        public int bookLanguageId { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? updateDate { get; set; }

        public Languages Languages { get; set; }
    }
}

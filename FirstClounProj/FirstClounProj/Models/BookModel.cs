using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Models
{
    public class BookModel
    {
        public int bookId { get; set; }
        [Required]
        [StringLength(100,MinimumLength =4)]
        [Display(Name = "Book Title")]
        public string bookTitle { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 2)]
        [Display(Name = "Book Author")]
        public string bookAuthor { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 15)]
        [Display(Name = "Book Description")]
        public string bookDescription { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 4)]
        [Display(Name = "Book Category")]
        public string bookCategory { get; set; }
        [Required]
        [Display(Name = "Book TotalPages")]
        public int? bookTotalPages { get; set; }
        [Required]
        [Display(Name = "Book Language")]
        public string bookLanguage { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? updateDate { get; set; }
    }
}

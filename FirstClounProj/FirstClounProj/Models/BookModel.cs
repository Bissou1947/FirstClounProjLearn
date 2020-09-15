using FirstClounProj.Data;
using FirstClounProj.Enums;
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
        public int bookLanguageId { get; set; }

        public Languages Languages { get; set; }

        //public int LanguageslanguageId { get; set; }

        //...for multiple select in dropdawnlist
        //public List<string> bookLanguageList { get; set; }
        //public BookLanguageEnum bookLanguage1 { get; set; }
        //...................................................//
        [Display(Name = "Book Language")]
        [DataType(DataType.Date)]
        public DateTime? createdDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? updateDate { get; set; }

        //.....................here just for learn........................//

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email")]
        [EmailAddress]
        public string Email { get; set; }
        //..................................................................//
    }
}

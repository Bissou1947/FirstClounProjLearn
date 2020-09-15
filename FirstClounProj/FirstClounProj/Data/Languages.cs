using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Data
{
    public class Languages
    {
        [Key]
        public int languageId { get; set; }
        public string languageName { get; set; }
        public string languageDescription { get; set; }
        public ICollection<Books> Books { get; set; }
    }
}

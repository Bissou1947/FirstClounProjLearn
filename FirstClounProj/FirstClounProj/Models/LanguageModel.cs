using FirstClounProj.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Models
{
    public class LanguageModel
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public ICollection<Books> Books { get; set; }
    }
}

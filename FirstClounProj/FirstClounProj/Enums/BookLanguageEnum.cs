using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Enums
{
    public enum BookLanguageEnum
    {
        [Display(Name ="Arabic Language Recommended")]
        Arabic,
        [Display(Name = "Turkish Language Recommended")]
        Turkish,
        [Display(Name = "Pakstan Language not Recommended")]
        Pakstan,
        [Display(Name = "Afghanistan Language not Recommended")]
        Afghanistan
    }
}

using FirstClounProj.Data;
using FirstClounProj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Repository
{
    public class LanguageRepository
    {
        private readonly FirstClounProjDbContext _context = null;
        public LanguageRepository(FirstClounProjDbContext context)
        {
            _context = context;
        }

        public async Task<List<LanguageModel>> GetALlBooksLanguages()
        {
            return await _context.Languages.Select(
                a=>new LanguageModel() { 
                LanguageId=a.languageId,
                LanguageName=a.languageName
                }).ToListAsync();
        }
    }
}

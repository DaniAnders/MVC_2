using System;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using MVC_2.Data;
using MVC_2.Models;

namespace MVC_2.Services
{
    public class LanguagesServices : ILanguageService
    {
        private readonly ApplicationDBContext _context;

        public LanguagesServices(ApplicationDBContext context)
        {
            _context = context;
        }


        public async Task<List<LanguageModel>> GetLanguagesList()
        {
            try
            {
                IEnumerable<Language> languageslist = await _context.Languages.ToListAsync();
                List<LanguageModel> languagesList = new List<LanguageModel>();

                foreach (var language in languageslist)
                {
                    
                    LanguageModel languageModel = new LanguageModel { LanguageName = language.LanguageName };
                    languagesList.Add(languageModel);
                }

                return languagesList;

            }
            catch
            {
                throw;
            }

        }



    }
}


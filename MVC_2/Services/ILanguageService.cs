using System;
using MVC_2.Models;

namespace MVC_2.Services
{
    public interface ILanguageService
    {
        Task<List<LanguageModel>> GetLanguagesList();
     
    }
}


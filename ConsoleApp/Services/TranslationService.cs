using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal class TranslationService : ITranslationService
    {
        public string TranslateMorse(string morse)
        {
            return morse;
            //throw new NotImplementedException();
        }

        public string TranslateWord(string morse)
        {
            throw new NotImplementedException();
        }
    }
}

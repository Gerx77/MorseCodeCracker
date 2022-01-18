﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal interface ITranslationService
    {
        public string TranslateMorse(string morse);
        public string TranslateWord(string morse);
    }
}

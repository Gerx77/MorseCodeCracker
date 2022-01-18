using ConsoleApp.Models;

namespace ConsoleApp
{
    internal class Utils
    {
        public static void PlayDotSound()
        {
            //TODO: I'll need a third party Nuget package to play sounds in .Net core
            throw new NotImplementedException();
        }
        public static void PlayDashSound()
        {
            //TODO: I'll need a third party Nuget package to play sounds in .Net core
            throw new NotImplementedException();
        }

        public static void SeedData(List<IBaseMC> morseCodeMasterList)
        {
            //data source: http://www.sckans.edu/~sireland/radio/code.html
            //https://textcleaner.net/morse-code-translator/

            Dictionary<string, string> morse = new()
            {
                { "A", ".-" },
                { "B", "-..." },
                { "C", "-.-." },
                { "D", "-.." },
                { "E", "." },
                { "F", "..-." },
                { "G", "--." },
                { "H", "...." },
                { "I", ".." },
                { "J", ".---" },
                { "K", "-.-" },
                { "L", ".-.." },
                { "M", "--" },
                { "N", "-." },
                { "O", "---" },
                { "P", ".--." },
                { "Q", "--.-" },
                { "R", ".-." },
                { "S", "..." },
                { "T", "-" },
                { "U", "..-" },
                { "V", "...-" },
                { "W", ".--" },
                { "X", "-..-" },
                { "Y", "-.--" },
                { "Z", "--.." },
                { "0", "-----" },
                { "1", ".----" },
                { "2", "..---" },
                { "3", "...--" },
                { "4", "....-" },
                { "5", "....." },
                { "6", "-...." },
                { "7", "--..." },
                { "8", "---.." },
                { "9", "----." }
            };

            morseCodeMasterList.Add(new AlphaMC('A', morse["A"]));
            morseCodeMasterList.Add(new AlphaMC('B', "-***"));
            morseCodeMasterList.Add(new AlphaMC('C', "-*-*"));
            morseCodeMasterList.Add(new AlphaMC('D', "-**"));
            morseCodeMasterList.Add(new AlphaMC('E', "*"));
            morseCodeMasterList.Add(new AlphaMC('F', "**-*"));
            morseCodeMasterList.Add(new AlphaMC('G', "--*"));
            morseCodeMasterList.Add(new AlphaMC('H', "****"));
            morseCodeMasterList.Add(new AlphaMC('I', "**"));
            morseCodeMasterList.Add(new AlphaMC('J', "*---"));
            morseCodeMasterList.Add(new AlphaMC('K', "-*-"));
            morseCodeMasterList.Add(new AlphaMC('L', "*-**"));
            morseCodeMasterList.Add(new AlphaMC('M', "--"));
            morseCodeMasterList.Add(new AlphaMC('N', "-*"));
            morseCodeMasterList.Add(new AlphaMC('O', "---"));
            morseCodeMasterList.Add(new AlphaMC('P', "*--*"));
            morseCodeMasterList.Add(new AlphaMC('Q', "--*-"));
            morseCodeMasterList.Add(new AlphaMC('R', "*-*"));
            morseCodeMasterList.Add(new AlphaMC('S', "***"));
            morseCodeMasterList.Add(new AlphaMC('T', "-"));
            morseCodeMasterList.Add(new AlphaMC('U', "**-"));
            morseCodeMasterList.Add(new AlphaMC('V', "***-"));
            morseCodeMasterList.Add(new AlphaMC('W', "*--"));
            morseCodeMasterList.Add(new AlphaMC('X', "-**-"));
            morseCodeMasterList.Add(new AlphaMC('Y', "-*--"));
            morseCodeMasterList.Add(new AlphaMC('Z', "--**"));

            morseCodeMasterList.Add(new NumericMC('1', "*----"));
            morseCodeMasterList.Add(new NumericMC('2', "**---"));
            morseCodeMasterList.Add(new NumericMC('3', "***--"));
            morseCodeMasterList.Add(new NumericMC('4', "****-"));
            morseCodeMasterList.Add(new NumericMC('5', "*****"));
            morseCodeMasterList.Add(new NumericMC('6', "-****"));
            morseCodeMasterList.Add(new NumericMC('7', "--***"));
            morseCodeMasterList.Add(new NumericMC('8', "---**"));
            morseCodeMasterList.Add(new NumericMC('9', "----*"));
            morseCodeMasterList.Add(new NumericMC('0', "-----"));

            morseCodeMasterList.Add(new SpecialMC('.', "Period", "*-*-*-"));
            morseCodeMasterList.Add(new SpecialMC(',', "Comma", "--**--"));
            morseCodeMasterList.Add(new SpecialMC(':', "Colon", "---***"));
            morseCodeMasterList.Add(new SpecialMC('?', "Question Mark", "**--**"));
            morseCodeMasterList.Add(new SpecialMC('X', "Apostrophe", "*----*"));
            morseCodeMasterList.Add(new SpecialMC('-', "Hyphen", "-****-"));
            morseCodeMasterList.Add(new SpecialMC('/', "Fraction Bar", "-**-*"));
            morseCodeMasterList.Add(new SpecialMC('X', "Parentheses", "-*--*-"));
            morseCodeMasterList.Add(new SpecialMC('X', "Quotation Marks", "*-**-*"));
        }

        //testing stuff below

        async void PlaySOS()
        {
            ////Dot
            //Console.Beep(600, 100);
            ////Dash
            //Console.Beep(600, 200);
            Console.Beep(1000, 250);
            System.Threading.Thread.Sleep(50);
            Console.Beep(1000, 250);
            System.Threading.Thread.Sleep(50);
            Console.Beep(1000, 250);
            System.Threading.Thread.Sleep(50);

            Console.Beep(1000, 750);
            System.Threading.Thread.Sleep(50);
            Console.Beep(1000, 750);
            System.Threading.Thread.Sleep(50);
            Console.Beep(1000, 750);
            System.Threading.Thread.Sleep(50);

            Console.Beep(1000, 250);
            System.Threading.Thread.Sleep(50);
            Console.Beep(1000, 250);
            System.Threading.Thread.Sleep(50);
            Console.Beep(1000, 250);
            System.Threading.Thread.Sleep(50);

            ////SOS sound?? - dot dot dot dash dash dash dot dot dot
            //int freq = 600;
            //int duration = 100;

            //Console.Beep(freq, duration); //S
            //Console.Beep(freq, duration);
            //Console.Beep(freq, duration);

            //Console.Beep(freq, duration * 2); //O
            //Console.Beep(freq, duration * 2);
            //Console.Beep(freq, duration * 2);

            //Console.Beep(freq, duration); //S
            //Console.Beep(freq, duration);
            //Console.Beep(freq, duration);
        }

        void PlaySOS2()
        {
            string word = "sos";
            Dictionary<string, string> Codes = new Dictionary<string, string>
            {
                {"a", ".-   "}, {"b", "-... "}, {"c", "-.-. "}, {"d", "-..  "},
                {"e", ".    "}, {"f", "..-. "}, {"g", "--.  "}, {"h", ".... "},
                {"i", "..   "}, {"j", ".--- "}, {"k", "-.-  "}, {"l", ".-.. "},
                {"m", "--   "}, {"n", "-.   "}, {"o", "---  "}, {"p", ".--. "},
                {"q", "--.- "}, {"r", ".-.  "}, {"s", "...  "}, {"t", "-    "},
                {"u", "..-  "}, {"v", "...- "}, {"w", ".--  "}, {"x", "-..- "},
                {"y", "-.-- "}, {"z", "--.. "}, {"0", "-----"}, {"1", ".----"},
                {"2", "..---"}, {"3", "...--"}, {"4", "....-"}, {"5", "....."},
                {"6", "-...."}, {"7", "--..."}, {"8", "---.."}, {"9", "----."}
            };

            foreach (char c in word.ToCharArray())
            {
                string rslt = Codes[c.ToString()].Trim();
                foreach (char c2 in rslt.ToCharArray())
                {
                    if (c2 == '.')
                        Console.Beep(1000, 250);
                    else
                        Console.Beep(1000, 750);
                }
                System.Threading.Thread.Sleep(50);
            }
        }

        //var test = Encode("sos");
        //Console.WriteLine(test);
        //Console.WriteLine(Decode(test));
        //Console.ReadLine();

        Dictionary<string, string> morse = new()
        {
            { "A", ".-" },
            { "B", "-..." },
            { "C", "-.-." },
            { "D", "-.." },
            { "E", "." },
            { "F", "..-." },
            { "G", "--." },
            { "H", "...." },
            { "I", ".." },
            { "J", ".---" },
            { "K", "-.-" },
            { "L", ".-.." },
            { "M", "--" },
            { "N", "-." },
            { "O", "---" },
            { "P", ".--." },
            { "Q", "--.-" },
            { "R", ".-." },
            { "S", "..." },
            { "T", "-" },
            { "U", "..-" },
            { "V", "...-" },
            { "W", ".--" },
            { "X", "-..-" },
            { "Y", "-.--" },
            { "Z", "--.." },
            { "0", "-----" },
            { "1", ".----" },
            { "2", "..---" },
            { "3", "...--" },
            { "4", "....-" },
            { "5", "....." },
            { "6", "-...." },
            { "7", "--..." },
            { "8", "---.." },
            { "9", "----." }
        };

        string Encode(string text)
        {
            List<string> wordList = text.Split(" ").ToList(); // "hello world" -> "hello", "world" 

            List<string> morseList = new List<string>();

            for (int i = 0; i < wordList.Count; i++)
            {
                List<string> dividedWord = Divide(wordList[i], 1).ToList(); // "hello" -> "h", "e", "l"...

                for (int j = 0; j < dividedWord.Count; j++)
                {
                    dividedWord[j] = morse.SingleOrDefault(morseletter =>
                    string.Equals(dividedWord[j], morseletter.Key, StringComparison.OrdinalIgnoreCase)).Value;
                }

                morseList.Add(string.Join(" ", dividedWord));
            }

            return string.Join("   ", morseList);
        }

        string Decode(string morseText)
        {
            List<string> morseWordList = morseText.Split("   ").ToList();
            List<string> wordList = new List<string>();

            for (int i = 0; i < morseWordList.Count; ++i)
            {
                List<string> morseLetterList = morseWordList[i].Split(" ").ToList();

                for (int j = 0; j < morseLetterList.Count; ++j)
                {
                    morseLetterList[j] = morse.SingleOrDefault(morseTemp => string.Equals(morseLetterList[j], morseTemp.Value, StringComparison.OrdinalIgnoreCase)).Key;
                }

                wordList.Add(string.Join(String.Empty, morseLetterList));
            }

            return string.Join(" ", wordList);
        }

        IEnumerable<string> Divide(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}

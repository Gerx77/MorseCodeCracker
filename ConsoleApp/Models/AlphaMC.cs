namespace ConsoleApp.Models
{
    internal class AlphaMC : BaseMC, IBaseMC
    {
        public char Letter { get; set; }
        public string? Nato { get; set; }
        public string? English { get; set; }
        public string? International { get; set; }

        public AlphaMC(char letter, string code)
            : base(letter, code, letter.ToString(), MorseType.Alpha)
        {
            Letter = letter;
        }

        public AlphaMC(char letter, string code, string nato, string english, string international)
            : base(letter, code, letter.ToString(), MorseType.Alpha)
        {
            Letter = letter;
            Nato = nato;
            English = english;  
            International = international;
        }

        public string ToStringFull()
        {
            return $"{Code} - {Conversion} - {Nato}, {English}, {International}";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

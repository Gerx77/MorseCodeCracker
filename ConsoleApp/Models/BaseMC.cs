namespace ConsoleApp.Models
{
    internal abstract class BaseMC : IBaseMC
    {
        public char Character { get; set; }
        public string Code { get; set; }
        public string Conversion { get; set; }
        public MorseType MorseType { get; }

        public BaseMC(char character, string code, string conversion, MorseType morseType)
        {
            Character = character;
            Code = code;
            Conversion = conversion;
            MorseType = morseType;
        }

        public override string ToString()
        {
            return $"{Code} - {Conversion}";
        }
    }
}

namespace ConsoleApp.Models
{
    internal interface IBaseMC
    {
        public char Character { get; set; }
        public string Code { get; set; }
        public string Conversion { get; set; }
        public MorseType MorseType { get; }
    }
}

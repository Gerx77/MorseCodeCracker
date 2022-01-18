namespace ConsoleApp.Models
{
    internal class NumericMC : BaseMC, IBaseMC
    {
        public int Number { get; set; }

        public NumericMC(char number, string code)
            : base(number, code, number.ToString(), MorseType.Numeric)
        {
            Number = number;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

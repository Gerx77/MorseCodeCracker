namespace ConsoleApp.Models
{
    internal class SpecialMC : BaseMC, IBaseMC
    {
        public string Description { get; set; }

        public SpecialMC(char character, string description, string code)
            : base(character, code, character.ToString(), MorseType.Special)
        {
            Description = description;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

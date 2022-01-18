// See https://aka.ms/new-console-template for more information

using ConsoleApp;
using ConsoleApp.Models;
using ConsoleApp.Services;
using System.Text;

var morseCodeMasterList = new List<IBaseMC>();
Utils.SeedData(morseCodeMasterList);

//const bool enableSound = false;
bool showMenu = true;

while (showMenu)
{
    showMenu = MainMenu();
}

bool MainMenu()
{
    Console.Clear();
    Console.WriteLine("Morse Code Cracker \n");
    Console.WriteLine("1: Send Morse Code");
    Console.WriteLine("2: Send SOS");
    Console.WriteLine("3: Print Alphabet");
    Console.WriteLine("4: Print Numbers");
    Console.WriteLine("5: Print Special characters");
    Console.WriteLine("6: Print all");
    Console.WriteLine("q: Quit/Exit program");

    Console.Write("\r\nSelect an option: ");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            SendMorseCode();
            return true;
        case "2":
            Console.Clear();
            //PlaySOS2();
            SendSOS();
            return true;
        case "3":
            Console.Clear();
            Console.WriteLine("Morse Code Alphabet\r");
            PrintMorseCode(morseCodeMasterList.Where(x => x.MorseType == MorseType.Alpha).ToList());
            return true;
        case "4":
            Console.Clear();
            Console.WriteLine("Morse Code Numbers\n");
            PrintMorseCode(morseCodeMasterList.Where(x => x is NumericMC).ToList());
            return true;
        case "5":
            Console.Clear();
            Console.WriteLine("Morse Code Special\n");
            PrintMorseCode(morseCodeMasterList.Where(x => x is SpecialMC).ToList());
            return true;
        case "6":
            Console.Clear();
            PrintMorseCode(morseCodeMasterList);
            return true;
        case "q":
            return false;
        default:
            return true;
    }
}

void SendMorseCode()
{
    Console.WriteLine("Enter text:\n");
    var message = Console.ReadLine();

    if (message is not null)
    {
        var convertedMessage = Translate(message);
        PrintMorseCode(convertedMessage);
    }
}

List<IBaseMC> Translate(string message)
{
    List<IBaseMC> mc = new();
    foreach (var item in message)
    {
        var messagePart = morseCodeMasterList.Find(x => x.Character == char.ToUpper(item));

        if (messagePart != null)
            mc.Add(messagePart);
    }

    return mc;
}

void SendSOS()
{
    List<IBaseMC> mc = new();
    //mc.Add(new AlphaMC('S', "***"));
    //mc.Add(new AlphaMC('O', "---"));
    //mc.Add(new AlphaMC('S', "***"));
    mc = Translate("SOS");

    var result = PrintMorseCodeBasic(mc);
    Console.Write($"{result}\n");

    PrintMorseCode(mc);

    //PlaySOS();
}

string PrintMorseCodeBasic(List<IBaseMC> mc)
{
    if (mc.Count == 0)
        return String.Empty;

    var result = new StringBuilder();

    foreach (var item in mc)
    {
        result.Append(item.Code);
    }

    return result.ToString();
}

void PrintMorseCode(List<IBaseMC> mc)
{
    if (mc.Count == 0)
        return;

    var result = new StringBuilder();
    
    foreach (var item in mc)
    {
        if (item is AlphaMC alphaMC)
        {
            Console.WriteLine($"{alphaMC.Letter} : {alphaMC.Code}");
            //Console.Write(alphaMC.ToStringFull());
        }
        else if (item is NumericMC numericMC)
        {
            Console.WriteLine($"{numericMC.Conversion} : {numericMC.Code}");
        }
        else if (item is SpecialMC specialMC)
        {
            Console.WriteLine($"{specialMC.Code} : {specialMC.Conversion}");
        }
    }

    Console.Write("\r\nPress Enter to return to Main Menu\n");
    Console.ReadLine();
}

static void DisplayResult(string message)
{
    Console.WriteLine($"\r\nYour modified string is: {message}");
    Console.Write("\r\nPress Enter to return to Main Menu");
    Console.ReadLine();
}
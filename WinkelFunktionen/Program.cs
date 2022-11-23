Console.WriteLine("WinkelRechner");
Console.WriteLine("1.Cosinus");
Console.WriteLine("2.Sinus");
Console.WriteLine("3.Tangenz");
Console.Write("Bitte Wählen sie:");
short programm = Convert.ToInt16(Console.ReadLine());
Console.Write("Bitte Winkel in ° eingeben:");
double winkel = Convert.ToDouble(Console.ReadLine());
switch (programm)
{
    case 1:
        Console.WriteLine(Math.Cos(winkel));
        break;
    case 2:
        Console.WriteLine(Math.Sin(winkel));
        break;
    case 3:
        Console.WriteLine(Math.Tan(winkel));
        break;
    default:
        Console.WriteLine("ERROR #404\nFalsche Eingabe");
        break;
}
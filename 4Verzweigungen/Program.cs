/*
 * Herr Akinci:
 * Ich würd ihnen nicht unbedingr raten diesen code zu überprüfen
 * sondern nur auszuführen.schliesslich mus es am ende ja nur
 * funktionieren
 * Vielen danl
 * mit freundlichen Grüßen JP
 */

//Interface
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Linq.Expressions;

Console.WindowHeight = 10;
Console.WindowWidth = 50;
Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BufferHeight = 10;
Console.BufferWidth = 50;

//Aufg1
Console.SetCursorPosition(0,0);
Console.Write("Enter numbers to compare(-32k - 32k:)");
Console.SetCursorPosition(0,1);
Console.WriteLine("Number A:");
Console.WriteLine("Number B:");
Console.WriteLine("Result  :");
Console.SetCursorPosition(9,1);
string nmt1 = Console.ReadLine();
Console.SetCursorPosition (9, 2);
string nmt2 = Console.ReadLine();
short nm1 = Convert.ToInt16(nmt1);
short nm2 = Convert.ToInt16(nmt2);
Console.SetCursorPosition(9,3);
if (nm1 > nm2)
    Console.WriteLine("A ist groesser");
else if (nm2 > nm1)
    Console.WriteLine("B ist groesser");
else if (nm1 == nm2)
    Console.WriteLine("AB ist gleich");
Console.WriteLine("Press Enter to contnue!");
Console.ReadLine();
Console.Clear();

//Aufg2
Random rdn = new Random();
short nr = Convert.ToInt16(rdn.Next(1000));
bool r = false;
Console.WriteLine("Random numer zwischen 0 und 1000 generiert \n Viel spas beim erraten. \nDeine nummer:\nergebnis    :");
while (r == false)
{
    Console.SetCursorPosition(13, 2);
    short nr2 = Convert.ToInt16(Console.ReadLine());
    Console.SetCursorPosition(13, 3);
    if (nr2 > 1000)
        Console.WriteLine("Out OF Range");
    else if (nr2 > nr)
        Console.WriteLine("Too High    ");
    else if (nr2 < nr)
        Console.WriteLine("Too Low     ");
    else if (nr2 == nr)
    {
        Console.WriteLine("Got it      ");
        r = true;
    }
    Console.SetCursorPosition(13, 2);
    Console.Write("                              ");
}
Console.SetCursorPosition(0, 9);

Console.WriteLine("Press Enter to contnue!");
Console.ReadLine();
Console.Clear();

//Aufg3

Console.WriteLine("Herzenfakt - risikotest:\nBitte beantworten sie die folgenden fragen\nMit true fuer ja oder false fuer nein");
Console.WriteLine("Haben sie stress?");
bool S = Convert.ToBoolean(Console.ReadLine());
Console.SetCursorPosition(0,3);
Console.WriteLine("Sind sie Fett?     \n       ");
Console.SetCursorPosition(0,4);
bool F = Convert.ToBoolean(Console.ReadLine());
Console.Clear();
Console.WriteLine("Risiko nach tabelle:");
if (S == false && F == false)
    Console.WriteLine("5%");
else if (S == false && F == true)
    Console.WriteLine("18%");
else if (S == true && F == false)
    Console.WriteLine("15%");
else if (S == true && F == true)
    Console.WriteLine("62%");
Console.WriteLine("Press Enter to contnue!");
Console.ReadLine();

//Aufg4A
Console.Clear();
Console.WriteLine("Zahl 1 bitte:");
double numm1 = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("Zahl 2 bitte:");
double numm2 = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("Bitte Rechenart anhand von nummerierung wählen:\n1.Addition\n2.Suptrakrion\n3.Multiplikation\n" +
    "4.Division\n5.Potez");
Console.Write("Operator:");
short numm3 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("");
if (numm3 == 1)
    Console.WriteLine(numm1 + numm2);
if (numm3 == 2)
    Console.WriteLine(numm1 - numm2);
if (numm3 == 3)
    Console.WriteLine(numm1 * numm2);
if (numm3 == 4)
    Console.WriteLine(numm1 / numm2);
if (numm3 == 5)
    Console.WriteLine(Math.Pow(numm1, numm2));
Console.WriteLine("Press Enter to continue!");
Console.ReadLine();
Console.Clear();

//Aufg4B
Console.WriteLine("Zahl 1 bitte:");
numm1 = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("Zahl 2 bitte:");
numm2 = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("Bitte Rechenart anhand von nummerierung wählen:\n1.Addition\n2.Suptrakrion\n3.Multiplikation\n" +
    "4.Division\n5.Potez");
Console.Write("Operator:");
numm3 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("");
switch (numm3)
{
    case 1:
        Console.WriteLine(numm1 + numm2);
        break;
    case 2:
        Console.WriteLine(numm1 - numm2);
        break;
    case 3:
        Console.WriteLine(numm1 * numm2);
        break;
    case 4:
        Console.WriteLine(numm1 / numm2);
        break;
    case 5:
        Console.WriteLine(Math.Pow(numm1, numm2));
        break;
}
Console.WriteLine("Press Enter to continue!");
Console.ReadLine();
Console.Clear();
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Xml.Linq;

//Aufgabe 1
Console.WriteLine("Aufgabe 1:");
Console.WriteLine("Ganzzahlen:" + 
    "\n short   16bits" + short.MinValue + ".." + short.MaxValue + 
    "\n int     32bits" + int.MinValue + ".." + int.MaxValue + 
    "\n long    64bits" + long.MinValue + ".." + long.MaxValue +
    "\n" +
    "\n Dezimalzahlen:" +
    "\n float   32bits" + float.MinValue + ".." + float.MaxValue + 
    "\n double  64bits" + double.MinValue + ".." + double.MaxValue +
    "\n decimal 128bits" + decimal.MinValue + ".." + decimal.MaxValue);
/*Ganzzahlen:
short   16bits - 32768..32767
 int 32bits - 2147483648..2147483647
 long 64bits - 9223372036854775808..9223372036854775807

 Dezimalzahlen:
float   32bits - 3,4028235E+38..3,4028235E+38
 double 64bits - 1,7976931348623157E+308..1,7976931348623157E+308
 decimal 128bits - 79228162514264337593543950335..79228162514264337593543950335*/
Console.WriteLine("Press somethng to continue");
Console.ReadKey();

//Aufgabe 2
Console.WriteLine("Aufgabe2:");
string N = "Julian";
short A = 15;
bool J = false;
Console.WriteLine("{0} | {1} | Ist C# meine erste programmiersprche? {2}",N,A,J);
Console.WriteLine("Press somethng to continue");
Console.ReadKey();

//Aufgabe 3
Console.WriteLine("Aufgabe3:");
int DollarZahl = 36;
char Dollar = (char)DollarZahl;
Console.WriteLine("If {1} matches the symbol for the number {0} dann ist der absatz koerrekt", DollarZahl, Dollar);
Console.WriteLine("Press somethng to continue");
Console.ReadKey();

//Aufgabe 4
Console.WriteLine("Aufgabe4:");
string eingabe;
short B;
double C;
Console.Write("Bitte Ganze zahl eingeben:");
eingabe = Console.ReadLine();
B = Convert.ToInt16(eingabe);
Console.Write("\n Bitte Dezimalzahl eingeben:");
eingabe = Console.ReadLine();
C = Convert.ToDouble(eingabe);

Console.WriteLine("Press Enter to end");
Console.ReadLine();
Console.WindowHeight = 6;
Console.WindowWidth = 17;
Console.WriteLine(@"      _   _____  ");
Console.WriteLine(@"     | | |  __ \ ");
Console.WriteLine(@"     | | | |__) |");
Console.WriteLine(@" _   | | |  ___/ ");
Console.WriteLine(@"| |__| | | |     ");
Console.Write(    @" \____/  |_|     ");
Console.ReadLine();
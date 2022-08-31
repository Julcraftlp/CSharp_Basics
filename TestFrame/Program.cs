string name;
string alter;
string klasse;

Console.Write("Bitte Vorname eingeben:");
name = Console.ReadLine();
Console.Write("\nBitte Alter eingeben:");
alter = Console.ReadLine();
Console.Write("\nBitte Klassen-Name eingeben:");
klasse = Console.ReadLine();
int alternr = alter.Count();
if (alternr >= 18) {
    Console.WriteLine("Ist 18+");
}

Console.WriteLine("\n\n{0} ist {1} Jahre alt und " +
    "besucht die {2} des Georg-Simon-Ohm",name,alter,klasse);

name = "Juian";
alter = "15";
string jn = "nein";
Console.WriteLine("{0} | {1} | Ist C# meine erste programmiersprche? {2}",
    name,alter,jn);

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

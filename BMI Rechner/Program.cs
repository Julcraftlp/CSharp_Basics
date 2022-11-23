Console.Write("Eingabe der Körpergröße in cm bitte:");
double L = Convert.ToInt32(Console.ReadLine());
L = L / 100;
Console.Write("Eingabe des Gewichts bitte:");
int GW = Convert.ToInt32(Console.ReadLine());
double bmi = GW / (L * L);
if (bmi < 18.5)
    Console.WriteLine("Untergewicht");
else if (bmi > 25)
    Console.WriteLine("Übergewicht");
else
    Console.WriteLine("Normalgewicht");
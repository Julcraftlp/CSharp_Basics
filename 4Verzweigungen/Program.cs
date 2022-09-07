//Interface
using System.Drawing;

Console.WindowHeight = 10;
Console.WindowWidth = 50;
Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BufferHeight = 10;
Console.BufferWidth = 50;
Console.WriteLine("##################################################");
Console.WriteLine("#                                                #");
Console.WriteLine("#                                                #");
Console.WriteLine("#                                                #");
Console.WriteLine("#                                                #");
Console.WriteLine("#                                                #");
Console.WriteLine("#                                                #");
Console.WriteLine("#                                                #");
Console.WriteLine("#                                                #");
Console.Write("##################################################");
//Aufg1
Console.SetCursorPosition(1,1);
Console.Write("Enter numbers to compare(-32k - 32k:");
Console.SetCursorPosition(1, 2);
Console.WriteLine("Number A:");
Console.WriteLine("#Number B:");
Console.WriteLine("#Result  :");
Console.SetCursorPosition(10,2);
string nmt1 = Console.ReadLine();
Console.SetCursorPosition (10, 3);
string nmt2 = Console.ReadLine();
short nm1 = Convert.ToInt16(nmt1);
short nm2 = Convert.ToInt16(nmt2);
Console.SetCursorPosition(10,4);
if (nm1 < nm2)
    Console.Write("A ist groesser");
else if (nm2 < nm1)
    Console.Write("B ist groesser");
else if (nm1 == nm2)
    Console.Write("AB ist gleich");

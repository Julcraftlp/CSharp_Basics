using System;
using System.Reflection.Metadata;

string a = "Hallo";
string b = "H";
b += "allo";

Console.WriteLine(b);
Console.WriteLine(b.Length);
Console.WriteLine(a == b);
Console.WriteLine((object)a == b);


//ausgabe:
/*
 * Hallo
 * 5
 * True
 * False
 */

double x = 2.0;
double y = x * x + 1 + x / 4;
//erwartet:5.5
Console.WriteLine(y);
//erhalten:5.5
 x = 2.0;
 y = x * (x + 1 + x / 4);
//erwartet:7
Console.WriteLine(y);
//erhalten:7
bool c = true && false || 5 > 6;
//erwartet:true
Console.WriteLine(c);
//erhalten:false
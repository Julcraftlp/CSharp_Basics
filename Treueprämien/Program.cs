using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Bitte anzahl an jahren eingeben:");
int J = Convert.ToInt32(Console.ReadLine());
long X = 0;
while (J >= 3)
{
    
    if (J < 10)
        X = X + 150;
    else
    {
        int I = J;
        I = I - 9;
        I = I * 10;
        I = I + 150;
        X = X + I;
    }
    --J;
}
Console.WriteLine("{0}€ Prämie",X);
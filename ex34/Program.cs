// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

string numero;
float N1, N2, N3;
Console.WriteLine("Digite o primeiro numero: ");
N1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero:");
N2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro numero:");
N3 = float.Parse(Console.ReadLine());
if (N1 <= N2)
{
    Console.WriteLine(N1 + "," + N2 + "," + N3);
}
else if (N2 <= N3)
{
    Console.WriteLine(N2 + "," + N3 + "," + N1);
}
else if (N1 <= N3)
{
    Console.Write(N1 + "," + N3 + "," + N2);
}
else if (N3 <= N1)
{
    Console.Write(N2 + "," + N1 + "," + N3);
}
else
{
    Console.Write(N3 + "," + N2 + "," + N1);
    
}


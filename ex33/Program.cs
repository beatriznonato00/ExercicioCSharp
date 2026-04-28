// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

string Media;
float N1, N2, N3, mediaTotal;
Console.WriteLine("Nota A: ");
N1 = float.Parse(Console.ReadLine());
Console.WriteLine ("Nota B");
N2 = float.Parse(Console.ReadLine());
Console.WriteLine("mediaTotal");
N3 = float.Parse(Console.ReadLine());
mediaTotal = (N1 + N2 + N3) / 3;
if (mediaTotal >= 7) 
{
    Console.WriteLine("Aprovado");
} else if (mediaTotal>=5)
{
    Console.WriteLine("Recuperação");
}
else if (mediaTotal<5)
{
    Console.WriteLine("Reprovado");
}

// See https://aka.ms/new-console-template for more information//
string Media;
float PT, CG , MT, mediaTotal;
Console.WriteLine("Nota de Portugues: ");
PT = float.Parse(Console.ReadLine());
Console.WriteLine("Nota de conhecimento geral: ");
CG = float.Parse(Console.ReadLine());
Console.WriteLine("Nota de Matematica: ");
MT = float.Parse(Console.ReadLine());
mediaTotal = (PT + CG + MT) / 3;
if ( mediaTotal >=7 )
{
    Console.WriteLine("Aprovado");
}
else if (mediaTotal < 7)
{
    Console.WriteLine("Reprovado");
}

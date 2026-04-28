// See https://aka.ms/new-console-template for more information
string numero;
float F1, F2, F3;
    Console.WriteLine("Digite o valor de F1: ");
F1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o de F2");
F2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o de F3");
F3 = float.Parse(Console.ReadLine());
if(F1<= 10) {
    Console.WriteLine("Este numero é f1: ");
} else if (F2 <=10)
{
    Console.WriteLine("Este numero é f2:");
}
else if (F3 <=10)
{
    Console.WriteLine("Este numero é F3:");
}
else { Console.WriteLine("Nenhum numero é igual ou menor que 10");
        }




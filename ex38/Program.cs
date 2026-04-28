// See https://aka.ms/new-console-template for more information

string valor;
float A, B, C, soma;
Console.WriteLine("Valor de A:");
A = float.Parse(Console.ReadLine());
Console.WriteLine("Valor de B: ");
B = float.Parse(Console.ReadLine());
Console.WriteLine("Valor de C: ");
C = float.Parse(Console.ReadLine());
soma = A + B;
if (soma <C)
{
    Console.WriteLine("A soma de A + B é MENOR que C");
}
else if (soma > C)
{
    Console.WriteLine("A soma de A + B é MAIOR que ");
} else if (soma == C) {
    Console.WriteLine("A soma de A + B é igual a C");
}

// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

string nome;
float nota1, nota2, total;
Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a nota 1: " );
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 2: ");
nota2 = float.Parse(Console.ReadLine());
total = nota1 + nota2;
if (total >= 60) 
{
    Console.WriteLine("Aluno Aprovado");
}else {
    Console.WriteLine("Aluno Reprovado");
}






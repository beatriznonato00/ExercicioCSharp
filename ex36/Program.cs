// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

double totalVendas = 0;

for (int i = 1; i <= 3; i++)
{
    Console.Write("Nome do corretor " + i + ": ");
    string nome = Console.ReadLine();

    Console.Write("Valor da venda: ");

    double comissao;

    if (venda > 50000)
    {
        comissao = venda * 0.12;
    }
    else if (venda >= 30000 && venda <= 50000)
    {
        comissao = venda * 0.095;
    }
    else
    {
        comissao = venda * 0.07;
    }

    totalVendas += venda;

    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Valor da venda: " + venda);
    Console.WriteLine("Comissão: " + comissao);
    Console.WriteLine();
}

Console.WriteLine("Total de vendas da empresa: R$ " + totalVendas);
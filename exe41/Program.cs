// See https://aka.ms/new-console-template for more information
string nome = "Carol";

Console.Write("Valor do salário mínimo: ");
double salarioMinimo = double.Parse(Console.ReadLine());

Console.Write("Quantidade de carros vendidos: ");
double carrosVendidos = double.Parse(Console.ReadLine());

Console.Write("Valor total das vendas: ");
double valorVendas = double.Parse(Console.ReadLine());

double salarioFixo = salarioMinimo * 2;
double comissaoCarros = carrosVendidos * 50;
double comissaoVendas = valorVendas * 0.05;

double salarioTotal = salarioFixo + comissaoCarros + comissaoVendas;

Console.WriteLine("Vendedor: " + nome);
Console.WriteLine("Salário fixo: R$ " + salarioFixo);
Console.WriteLine("Comissão por carros: R$ " + comissaoCarros);
Console.WriteLine("Comissão 5% vendas: R$ " + comissaoVendas);
Console.WriteLine("Salário total: R$ " + salarioTotal);
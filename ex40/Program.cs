string nome;
double Qparafusos, Qporcas, Qarruelas, Pparafuso, Pporca, Parruela, Tparafuso, Tporca, Tarruela, Dparafuso, Dporca, Darruela, totalDesconto, totalBruto, totalPagar;

Console.WriteLine("Nome do cliente:");
nome = Console.ReadLine();

Console.Write("Quantidade de parafusos: ");
Qparafusos = double.Parse(Console.ReadLine());

Console.Write("Quantidade de porcas: ");
Qporcas = double.Parse(Console.ReadLine());

Console.Write("Quantidade de arruelas: ");
Qarruelas = double.Parse(Console.ReadLine());

Console.WriteLine("Preço do parafuso:");
Pparafuso = double.Parse(Console.ReadLine());

Console.WriteLine("Preço da porca:");
Pporca = double.Parse(Console.ReadLine());

Console.WriteLine("Preço da arruela:");
Parruela = double.Parse(Console.ReadLine());

// totais
Tparafuso = Qparafusos * Pparafuso;
Tporca = Qporcas * Pporca;
Tarruela = Qarruelas * Parruela;

// descontos
Dparafuso = Tparafuso * 0.20;
Dporca = Tporca * 0.10;
Darruela = Tarruela * 0.30;

// resultados
totalDesconto = Dparafuso + Dporca + Darruela;
totalBruto = Tparafuso + Tporca + Tarruela;
totalPagar = totalBruto - totalDesconto;

// saída
Console.WriteLine("21Nome do cliente: " + nome);
Console.WriteLine("Parafusos: " + Qparafusos);
Console.WriteLine("Porcas: " + Qporcas);
Console.WriteLine("Arruelas: " + Qarruelas);
Console.WriteLine("Total de desconto: R$ " + totalDesconto);
Console.WriteLine("Total a pagar: R$ " + totalPagar);
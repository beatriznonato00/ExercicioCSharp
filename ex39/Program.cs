// See https://aka.ms/new-console-template for more information
string compras;
float compra, pago, troco, total;
Console.WriteLine("Valor da compra: ");
compra = float.Parse(Console.ReadLine());
Console.WriteLine("Valor pago: ");
pago = float.Parse(Console.ReadLine());
total = (pago - compra);
if (compra <= pago)
{
    Console.WriteLine(" O valor do troco é de: " + total);
} 






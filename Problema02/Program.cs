using System.Globalization;

Console.Write("Ingrese el peso del paquete en kg: ");
decimal peso = decimal.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    CultureInfo.InvariantCulture);

decimal tarifa;
if (peso <= 0)
{
    tarifa = 0;
    Console.WriteLine("Peso inválido");
}
else if (peso < 1)
{
    tarifa = 8000;
}
else if (peso < 5)
{
    tarifa = 15000;
}
else if (peso < 20)
{
    tarifa = 32000;
}
else
{
    tarifa = 60000;
}

Console.WriteLine($"Tarifa: ${tarifa:N0}".Replace(",", "."));

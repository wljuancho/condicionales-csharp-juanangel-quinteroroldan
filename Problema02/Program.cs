using System;

Console.WriteLine("¿cuantos kilos llevaras: ");
float kilo = float.Parse(Console.ReadLine());


if (kilo < 1 && kilo > 0)
{
    decimal tarifa = 8000;
    Console.WriteLine($"{tarifa:C0}");
}
else if (kilo >= 1 && kilo < 5)
{
    decimal tarifa = 15000;
    Console.WriteLine($"{tarifa:C0}");
}
else if (kilo >= 5 && kilo < 20)
{
    decimal tarifa = 32000;
    Console.WriteLine($"{tarifa:C0}");
}
else if (kilo >= 20)
{
    decimal tarifa = 60000;
    Console.WriteLine($"{tarifa:C0}");
}
else
{
    Console.WriteLine("tarifa 0 y mensaje de peso inválido");
}

using System.Globalization;

Console.Write("Ingrese la categoría del vehículo (M, A, B, C): ");
char categoria = char.ToUpperInvariant(Console.ReadLine()!.Trim()[0]);

int tarifa = categoria switch
{
    'M' => 0,
    'A' => 12_000,
    'B' => 25_000,
    'C' => 38_000,
    _ => throw new InvalidOperationException("Categoría desconocida")
};

string tarifaFormateada = tarifa.ToString("N0", CultureInfo.GetCultureInfo("es-CO"));
Console.WriteLine($"Categoría {categoria} - Tarifa: ${tarifaFormateada}");

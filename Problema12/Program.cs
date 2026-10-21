using System.Globalization;

Console.Write("¿Tiene empleo? (sí/no): ");
string respuesta = Console.ReadLine()!.Trim().ToLowerInvariant();
bool tieneEmpleo = respuesta switch
{
    "si" or "sí" or "s" or "yes" or "true" => true,
    "no" or "n" or "false" => false,
    _ => throw new FormatException("Respuesta de empleo no válida")
};

if (!tieneEmpleo)
{
    Console.WriteLine("Crédito rechazado");
}
else
{
    Console.Write("Ingrese el ingreso mensual: ");
    decimal ingreso = decimal.Parse(
        Console.ReadLine()!.Replace(',', '.'),
        CultureInfo.InvariantCulture);

    Console.WriteLine(ingreso >= 2_500_000
        ? "Crédito alto aprobado"
        : "Crédito básico aprobado");
}

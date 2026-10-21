using System.Globalization;

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");
Console.Write("Ingrese el valor de la compra: ");
decimal compra = decimal.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    CultureInfo.InvariantCulture);
Console.Write("¿Es cliente frecuente? (sí/no): ");
string respuesta = Console.ReadLine()!.Trim().ToLowerInvariant();
bool esFrecuente = respuesta is "si" or "sí" or "s" or "yes" or "true";

if (compra < 0)
{
    Console.WriteLine("Valor de compra inválido");
}
else
{
    decimal descuento = compra switch
    {
        >= 500_000 => 15,
        >= 200_000 => 10,
        >= 100_000 => 5,
        _ => 0
    };

    if (esFrecuente && compra >= 100_000)
    {
        descuento += 5;
    }

    decimal total = compra * (1 - descuento / 100);
    Console.WriteLine(
        $"Compra: ${compra.ToString("N0", cultura)} | " +
        $"Descuento: {descuento}% | " +
        $"Total a pagar: ${total.ToString("N0", cultura)}");
}

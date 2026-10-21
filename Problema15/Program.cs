using System.Globalization;

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");
Console.Write("Ingrese el peso en kg: ");
decimal peso = decimal.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    CultureInfo.InvariantCulture);
Console.Write("Ingrese la estatura en metros: ");
decimal estatura = decimal.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    CultureInfo.InvariantCulture);

if (peso <= 0 || estatura <= 0)
{
    Console.WriteLine("Datos inválidos");
}
else
{
    decimal imc = peso / (estatura * estatura);
    string categoria = imc switch
    {
        < 18.5m => "Bajo peso",
        < 25m => "Peso normal",
        < 30m => "Sobrepeso",
        _ => "Obesidad"
    };

    Console.WriteLine($"IMC: {imc.ToString("0.0", cultura)} - {categoria}");
}

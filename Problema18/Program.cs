using System.Globalization;

Console.Write("Ingrese la estatura en metros: ");
decimal estatura = decimal.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    CultureInfo.InvariantCulture);
Console.Write("Ingrese la edad: ");
int edad = int.Parse(Console.ReadLine()!);
Console.Write("¿Va acompañada por un adulto? (sí/no): ");
string respuesta = Console.ReadLine()!.Trim().ToLowerInvariant();
bool acompanada = respuesta is "si" or "sí" or "s" or "yes" or "true";

bool puedeSubir = estatura >= 1.40m && (edad >= 12 || acompanada);
Console.WriteLine(puedeSubir ? "Puede subir" : "No puede subir");

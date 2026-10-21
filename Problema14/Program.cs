using System.Globalization;

Console.Write("Ingrese la nota final (0 a 5): ");
decimal nota = decimal.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    CultureInfo.InvariantCulture);

string estado = nota >= 3.0m ? "Aprobado" : "Reprobado";
Console.WriteLine($"Nota: {nota.ToString("0.0", CultureInfo.GetCultureInfo("es-CO"))} - {estado}");

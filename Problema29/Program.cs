Console.Write("Ingrese el rol (admin, instructor o aprendiz): ");
string rol = Console.ReadLine()!.Trim().ToLowerInvariant();
Console.Write("Ingrese la hora de llegada (0 a 23): ");
int hora = int.Parse(Console.ReadLine()!);

bool accesoPermitido = rol switch
{
    "admin" => hora is >= 0 and <= 23,
    "instructor" => hora is >= 6 and <= 21,
    "aprendiz" => hora is >= 6 and <= 18,
    _ => false
};

Console.WriteLine(accesoPermitido ? "Acceso permitido" : "Acceso denegado");

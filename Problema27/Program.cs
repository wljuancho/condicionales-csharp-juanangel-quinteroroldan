Console.Write("Ingrese el día de la semana: ");
string dia = Console.ReadLine()!.Trim().ToLowerInvariant();
Console.Write("¿Es estudiante? (sí/no): ");
string respuesta = Console.ReadLine()!.Trim().ToLowerInvariant();
bool esEstudiante = respuesta is "si" or "sí" or "s" or "yes" or "true";

int precio = (dia, esEstudiante) switch
{
    ("lunes" or "miércoles" or "miercoles" or "jueves" or "viernes", true) => 9000,
    ("lunes" or "miércoles" or "miercoles" or "jueves" or "viernes", false) => 12000,
    ("martes", _) => 7000,
    ("sábado" or "sabado" or "domingo", _) => 15000,
    _ => 0
};

if (precio == 0)
{
    Console.WriteLine("Día no válido");
}
else
{
    Console.WriteLine($"${precio:N0}".Replace(",", "."));
}

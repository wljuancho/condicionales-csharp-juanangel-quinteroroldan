Console.Write("Usuario: ");
string usuario = Console.ReadLine()!;

if (!string.Equals(usuario, "aprendiz", StringComparison.Ordinal))
{
    Console.WriteLine("Usuario no encontrado");
}
else
{
    Console.Write("Contraseña: ");
    string contrasena = Console.ReadLine()!;
    Console.WriteLine(contrasena == "Sena2026"
        ? "Bienvenido"
        : "Contraseña incorrecta");
}

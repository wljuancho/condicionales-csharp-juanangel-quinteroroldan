Console.Write("Ingrese el código de país: ");
string codigo = Console.ReadLine()!.Trim().ToUpperInvariant();

string pais = codigo switch
{
    "CO" => "Colombia",
    "MX" => "México",
    "AR" => "Argentina",
    "PE" => "Perú",
    "CL" => "Chile",
    _ => "País no registrado"
};

Console.WriteLine(pais);

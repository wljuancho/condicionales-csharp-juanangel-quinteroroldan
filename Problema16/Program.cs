using System.Globalization;

Console.Write("Ingrese la coordenada X: ");
double x = LeerCoordenada();
Console.Write("Ingrese la coordenada Y: ");
double y = LeerCoordenada();

string ubicacion;
if (x == 0 && y == 0)
{
    ubicacion = "Origen";
}
else if (x == 0 || y == 0)
{
    ubicacion = "Sobre un eje";
}
else if (x > 0 && y > 0)
{
    ubicacion = "Primer cuadrante";
}
else if (x < 0 && y > 0)
{
    ubicacion = "Segundo cuadrante";
}
else if (x < 0 && y < 0)
{
    ubicacion = "Tercer cuadrante";
}
else
{
    ubicacion = "Cuarto cuadrante";
}

Console.WriteLine(ubicacion);

static double LeerCoordenada() =>
    double.Parse(
        Console.ReadLine()!.Replace(',', '.'),
        CultureInfo.InvariantCulture);

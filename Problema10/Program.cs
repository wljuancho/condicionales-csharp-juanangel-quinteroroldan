using System.Globalization;

Console.Write("Ingrese un dato (texto, entero, decimal o booleano): ");
string entrada = Console.ReadLine()!;

object dato;
if (bool.TryParse(entrada, out bool booleano))
{
    dato = booleano;
}
else if (int.TryParse(entrada, out int entero))
{
    dato = entero;
}
else if (double.TryParse(
    entrada.Replace(',', '.'),
    NumberStyles.Float,
    CultureInfo.InvariantCulture,
    out double decimalDato))
{
    dato = decimalDato;
}
else
{
    dato = entrada;
}

string descripcion = dato switch
{
    string texto => $"Texto de {texto.Length} caracteres",
    int valorEntero => $"Entero: {valorEntero}",
    double valorDecimal => $"Decimal: {valorDecimal.ToString(CultureInfo.CurrentCulture)}",
    bool valorBooleano => $"Booleano: {valorBooleano}",
    _ => "Tipo no reconocido"
};

Console.WriteLine(descripcion);

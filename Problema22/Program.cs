Console.Write("Ingrese el primer número entero: ");
int primero = int.Parse(Console.ReadLine()!);
Console.Write("Ingrese el segundo número entero: ");
int segundo = int.Parse(Console.ReadLine()!);
Console.Write("Ingrese el operador (+, -, *, /): ");
string operador = Console.ReadLine()!.Trim();

if (operador == "/" && segundo == 0)
{
    throw new InvalidOperationException("No se puede dividir entre cero");
}

decimal resultado = operador switch
{
    "+" => primero + segundo,
    "-" => primero - segundo,
    "*" => primero * segundo,
    "/" => (decimal)primero / segundo,
    _ => throw new InvalidOperationException("Operador no soportado")
};

Console.WriteLine($"{primero} {operador} {segundo} = {resultado}");

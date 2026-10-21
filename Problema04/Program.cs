Console.Write("Ingrese el nivel de batería (%): ");
int nivel = int.Parse(Console.ReadLine()!);

if (nivel < 15)
{
    Console.WriteLine("Batería baja: conecte el cargador");
}

Console.WriteLine($"Nivel actual: {nivel} %");

Console.Write("Ingrese el estado del semáforo (Rojo, Amarillo o Verde): ");
string estado = Console.ReadLine()!.Trim();

Semaforo semaforo = Enum.Parse<Semaforo>(estado, ignoreCase: true);
string instruccion = semaforo switch
{
    Semaforo.Rojo => "Deténgase",
    Semaforo.Amarillo => "Precaución, prepárese para detenerse",
    Semaforo.Verde => "Avance",
    _ => throw new ArgumentOutOfRangeException(nameof(semaforo))
};

Console.WriteLine(instruccion);

enum Semaforo
{
    Rojo,
    Amarillo,
    Verde
}

Console.Write("Jugada del jugador 1 (piedra, papel o tijera): ");
string jugador1 = Console.ReadLine()!.Trim().ToLowerInvariant();
Console.Write("Jugada del jugador 2 (piedra, papel o tijera): ");
string jugador2 = Console.ReadLine()!.Trim().ToLowerInvariant();

if (jugador1 == jugador2 && EsJugadaValida(jugador1))
{
    Console.WriteLine("Empate");
}
else if (
    (jugador1 == "piedra" && jugador2 == "tijera")
    || (jugador1 == "tijera" && jugador2 == "papel")
    || (jugador1 == "papel" && jugador2 == "piedra"))
{
    Console.WriteLine("Gana el jugador 1");
}
else if (
    (jugador2 == "piedra" && jugador1 == "tijera")
    || (jugador2 == "tijera" && jugador1 == "papel")
    || (jugador2 == "papel" && jugador1 == "piedra"))
{
    Console.WriteLine("Gana el jugador 2");
}
else
{
    Console.WriteLine("Jugada no válida");
}

static bool EsJugadaValida(string jugada) =>
    jugada is "piedra" or "papel" or "tijera";

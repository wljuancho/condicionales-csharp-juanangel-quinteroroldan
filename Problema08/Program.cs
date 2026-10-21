Console.Write("Ingrese una letra minúscula: ");
string entrada = Console.ReadLine()!.Trim();

if (entrada.Length != 1 || !char.IsLetter(entrada[0]))
{
    Console.WriteLine("No es una letra");
}
else if ("aeiou".Contains(char.ToLowerInvariant(entrada[0])))
{
    Console.WriteLine("Es vocal");
}
else
{
    Console.WriteLine("Es consonante");
}

using System;

Console.WriteLine("¿Cual es tu edad :");
byte edad = byte.Parse(Console.ReadLine());

string mensage= (edad >= 16) ? "Puede votar" : "Aún no puede votar";

Console.WriteLine(mensage);
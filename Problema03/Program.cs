using System;

bool iniar = true;
while (iniar)
{ 
    Console.WriteLine($"--------------Menu------------\n1 = Consultar saldo.\n2 = Retirar.\n3 = Depositar.\n4 = Salir \n \nElije una opcion:");
    int opcion = int.Parse(Console.ReadLine()!);
    switch (opcion)
    {
        case 1:
         Console.WriteLine("Ha seleccionado: Consultar saldo\n");
        break;
        case 2:
         Console.WriteLine("Ha seleccionado: Retirar\n");
        break;
        case 3:
         Console.WriteLine("Ha seleccionado: Depositar\n");
        break;
        case 4:
         Console.WriteLine("Ha seleccionado: Salir\n");
         iniar = false;
        break;
        default:
            Console.WriteLine("Opción no válida. Intenta de nuevo.\n");
        break;
    }
}

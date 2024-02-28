int secreto = 26;
int numero;

do
{
    Console.WriteLine("Ingresa un numero");
    if (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Introduce un numero valido por favor");
        continue;
    }

    if (numero < secreto)
    {
        Console.WriteLine("El numero secreto es mayor");
    }
    else if (numero > secreto)
    {
        Console.WriteLine("El numero secreto es menor");
    }
    else
    {
        Console.WriteLine("WOW! Adivinaste el numero secreto");
    }
} while (numero != secreto);
Console.WriteLine("FIN");
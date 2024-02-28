while (true)
{
    Console.WriteLine("Ingresa un numero entero positivo por favor"); //numero con el que vamos a operar
    if (!int.TryParse(Console.ReadLine(), out int num) || num <= 0)
    {
        Console.WriteLine("Ingresa un numero entero positivo"); //numero que nos indicara que desea hacer
        continue;
    }
    Console.WriteLine("Bienvenido a un peque menu: ");
    Console.WriteLine("Que deseas hacer?");
    Console.WriteLine(" 1) Calcular el factorial del numero ingresado");
    Console.WriteLine(" 2) Calcular la raiz cuadrada del numero ingresado");
    Console.WriteLine(" 3) Salir del programa");
    if (!int.TryParse(Console.ReadLine(), out int opcion))  
    {
        Console.WriteLine("Por favor ingrese un numero entero como opcion :)");
        continue;
    }
    switch (opcion)
    {
        case 1: Console.WriteLine($"El factorial de {num} es: {numfactorial(num)}"); 
            break;
        case 2: Console.WriteLine($"La raiz cuadra de {num} es: {Math.Sqrt(num)}");
            break;
        case 3: Console.WriteLine("Fue un gusto verte, hasta pronto <3");
            return;
        default: Console.WriteLine("Ups! te equivaste, la opcion no es valida.");
            break;
    }
}

static int numfactorial(int num)
{
    if (num == 0 || num ==1)
    {
        return 1; 
    }
    else
    {
        return num * numfactorial(num - 1);
    }
}
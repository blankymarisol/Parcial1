int num1, num2, operador, suma, resta, multiplicacion, division;

try
{
    Console.WriteLine("Ingresa un numero entero por favor");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa un numero entero de nuevo por favor");
    num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Elige el operador que deseas utilizar");
    Console.WriteLine(" 1. Suma +");
    Console.WriteLine(" 2. Resta -");
    Console.WriteLine(" 3. Multiplicacion *");
    Console.WriteLine(" 4. Division /");
    operador = int.Parse(Console.ReadLine());

    suma = num1 + num2;
    resta = num1 - num2;
    multiplicacion = num1 * num2;
    division = num1 / num2;

    switch (operador)
    {
        case 1:
            Console.WriteLine("El resultado de la suma de los dos numeros enteros es: " + suma);
            break;
        case 2:
            Console.WriteLine("El resultado de la resta de los dos numeros enteros es:" + resta);
            break;
        case 3:
            Console.WriteLine("El resultado de la multiplicacion de los dos numertos enteros es: " + multiplicacion);
            break;
        case 4:
            Console.WriteLine("El resultado de la divison de lo dos numeros enteros es: " + division);
            break;
    }
}
catch (Exception ex)
{
    Console.WriteLine("No ingresaste lo que se te solicito :(" + ex.Message);
}
Console.WriteLine("Ingrese el numero del cual desea saber su tabla de multiplicar");
if (!int.TryParse(Console.ReadLine(), out int numero))
{
    Console.WriteLine("Ups! no ingresaste un numero valido");
    return;
}
Console.WriteLine($"Esta es la tabla de multiplicar del numero {numero}:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}
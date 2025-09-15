//                                           Bucles

//Se mostrará el uso básico de los bucles, sea el: for, while y el do while.
//No se explica el funcionamiento por dentro.

//Romano Brian - Desarrollador C#

//Declaramos un contador
int contador = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Hola, esta es la vuelta con for: " + i);
}
//Console.WriteLine("Estado final del i: " + i);
//nota: no se puede acceder desde afuera, porque esa variable "i" es local de for, lo que significa que no existe salvo en el for

while (contador <= 10)
{

    Console.WriteLine("Esta es la vuelta con while: " + contador);
    contador++;
}
Console.WriteLine("Estado final del contador con while: " + contador);

do
{
    Console.WriteLine("Estamos en la vuelta con do while: " + contador);
    contador++;
} while (contador < 20);

Console.WriteLine("Estado final de contador con do while: " + contador);

//Ejercicio: Hacer que un for se ejecute hasta 10, y indicar si el contador es par o no.
for (int i = 0; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"El número {i} es par.");
    }
    else
    {
        Console.WriteLine($"El número {i} es impar");
    }
}








//                                           Bucles

//Se mostrará el uso básico de los bucles, sea el: for, while y el do while.
//No se explica el funcionamiento por dentro.

//Romano Brian - Programador C#

Console.WriteLine("\t\tBucles");
//Declaramos un contador inicializado.
int contador = 0;

//Usamos un for:
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Hola, esta es la vuelta con for: " + i);
}
//Console.WriteLine("Estado final del i: " + i); //fuerad del for no existe "i".

//Usamos un while:
while (contador <= 10)
{

    Console.WriteLine("Esta es la vuelta con while: " + contador);
    contador++;
}
Console.WriteLine("Estado final del contador con while: " + contador);

//Usamos un do while:
do
{
    Console.WriteLine("Estado de contador " + contador + ", dentro del do while.");
    contador++;
} while (contador < 20);

Console.WriteLine("Estado fuera del do while: " + contador);

//Ejercicio 1: Hacer que un for se ejecute hasta 10, y indicar si el contador es par o no.
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








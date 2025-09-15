//                                      Condicionales

//Se mostrará el uso básico de los condicionales, sea el: if, else, else if.
//No se explica el funcionamiento por dentro, hay teoría.

//Romano Brian - Desarrollador C#
//---

//Declaramos algunas variables con diferentes tipos de datos.
string miNombre = "Brian", nombreIngresante; //Cadenas de caracteres
int miEdad = 21, edadIngresante; //Número entero

//Ingreso de datos:

Console.Write("Ingrese su nombre: ");
nombreIngresante = Console.ReadLine();

Console.Write("Ingrese su edad: ");
edadIngresante = Convert.ToInt32(Console.ReadLine());

//Ponemos condiciones, al ser true uno de ellos mostrará información distinta
if (miEdad > edadIngresante)
{
    Console.WriteLine($"La edad de {miNombre} es mayor a la de {nombreIngresante}.");
}
else if (miEdad < edadIngresante)
{
    Console.WriteLine($"La edad de {miNombre} es menor a la de {nombreIngresante}.");
}
else
{
    Console.WriteLine("La edades son iguales.");
}
Console.WriteLine($"Adios!\n\n{DateTime.Now}");


//Ejercicio 1: Crear un programa que deba ingresar nombre, edad y sexo.
// Si es mayor a 18 y es hombre, que muestre "Felicidad NOMBRE_AQUÍ eres un hombre y eres mayor de edad.".
// Si es mayor a 18 y es mujer, que muestre "Felicidad NOMBRE_AQUÍ eres una mujer y eres mayor de edad.".
// Sino cumple ninguna, que muestre "Eres menor.".

//Declaramos las Variables.
int edad;
string nombre, sexo;

//Limpiamos la consola.
Console.WriteLine("Esto se eliminará.");
Thread.Sleep(5000);
Console.Clear();

//Ingreso de datos.
Console.Write("\n\n\tEjercicio 1:");
Console.Write("Deberá ingresar su nombre, edad y sexo, para saber si es mayor o no para el concurso");
Console.WriteLine(" y conocerlo un poco mejor:");
Console.Write("Ingrese el nombre: ");
nombre = Console.ReadLine();
Console.Write("Ingrese la edad: ");
edad = Convert.ToInt32(Console.ReadLine());
Console.Write("y ingrese el sexo: ");
sexo = Console.ReadLine();

//Condiciones
if (sexo.ToLower().Contains("hombre") && edad > 18)
{
    Console.WriteLine($"Felicidad {nombre} eres un hombre y eres mayor de edad!");
}
else if (sexo.ToLower().Contains("mujer") && edad > 18)
{
    Console.WriteLine($"Felicidad {nombre} eres una mujer y eres mayor de edad!");
}
else
{
    Console.WriteLine("Eres menor");
}


//Ejercicio 2: Hacer un progra que busque en la cadena "Esto es una programa, donde aprendo C#" las palabras "programa" y "C#"
// Si lo encuentra que imprima "Encontrado".






//                                        Variables

//Se mostrará el uso de algunas variables con algunos tipos de datos comúnes.

//Romano Brian - Programador C#
//---


Console.WriteLine("\t\tVariables");
//Creamos variables con distintos tipos de datos y sus formas:
// Declaramos 1 variable de tipo string.
string miNombre; //string - Cadenas de caracteres.

// Declaramos 1 variable de tipo int.
int edad; //int - Números entero.

// Declaramos e instanciamos un valor de tipo string.
string serVivo = "Humano";


//Ingreso de datos:
// El ".ReadLine()" por defecto toma tipo de dato string
Console.Write("Ingrese su nombre: ");
miNombre = Console.ReadLine();

// En este caso, pedimos que ingrese un string, pero después a eso lo convertimos en int.
Console.Write("Ingrese su edad: ");
edad = Convert.ToInt32(Console.ReadLine()); // Esta es una mejor manera de convertirlo, después de recibirlo.

// Mostramos los datos con la interpolación de cadenas.
Console.WriteLine($"\nHola {miNombre} tienes {edad}. :)");

Console.WriteLine($"Nos vemos!!!");


//Esto es para mostrar la fecha, por si se la necesita. Toma el día y su número, el mes y su número y el año.
Console.WriteLine($"\n{DateTime.Now.ToString("dddd dd - MMMM MM - yyyy")}");

//Esto es más que nada que "lea" una key, que creo que sería un dato de tipo char. Después de escribir un caracter se finaliza el programa.
Console.ReadKey(); // Permitiendo ver los resultados de lo que se hizo anteriormente, caso contrario se cierra sola sin poder ver lo anterior.

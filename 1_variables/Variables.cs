//                                        Variables

//Se mostrará el uso de algunas variables con algunos tipos de datos comúnes.

//Romano Brian - Desarrollador C#
//---

//Creamos 2 variables con distintos tipos de datos:
// Declaramos 1 variable de tipo string.
string miNombre; //string - Cadenas de caracteres.
// Declaramos 1 variable de tipo int.
int edad; //int - Números entero.
// Declaramos e instanciamos un valor de tipo string
string serVivo = "Humano";

//Ingreso de datos:
// El ".ReadLine()" por defecto toma tipo de dato string
Console.Write("Ingrese su nombre: ");
miNombre = Console.ReadLine();

// En este caso tenemos que pedir un dato de tipo int, lo cuál, lo convertimos de tipo int después de recibir el dato string.
Console.Write("Ingrese su edad: ");
edad = Convert.ToInt32(Console.ReadLine()); //Esta es una mejor manera de convertirlo después de recibirlo.

//Mostramos los datos con la interpolación de cadenas.
Console.WriteLine($"\nHola {miNombre} tienes {edad}. :)");


Console.WriteLine($"Nos vemos!!!");
Console.WriteLine($"\n{DateTime.Now.ToString("dddd dd - MMMM MM - yyyy")}");
Console.ReadKey();

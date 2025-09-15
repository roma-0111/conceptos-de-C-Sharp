using System.Xml;

namespace prueba_con_goto;

class Program
{
    static void Main(string[] args)
    {
        //Ejercicio: Programa que muestra un menu de opciones, dependiendo de cada opciones realizará una operación básica.
        //Condiciones: Usar goto

        //Variables:
        Inicio:
    
        string opcion;
        decimal A, B;

        //Mostramos el menú.
        Console.WriteLine("Debe ingresar un numero para elegir una opción.");
        Console.WriteLine("ׅ\t1 - Sumar A y B.");
        Console.WriteLine("\t2 - Restar A y B.");
        Console.WriteLine("\t3 - Multiplicar A y B.");
        Console.WriteLine("\t4 - Dividir A y B.");
        Console.WriteLine("\t5 - Salir.");
        
        //Ingresa la opción
        opcion = Console.ReadLine(); //Se guarda la opción.
        
        //Limpiamos la consola.
        Console.Clear();

        //Si desea salir.
        if (opcion == "5") goto Salir;

        //Si se equivoca de opción.
        if ((opcion != "1") && (opcion != "2") && (opcion != "3") && (opcion != "4") && (opcion != "5"))
        {
            Console.WriteLine("Opción no permitida. Reiniciando...");
            //Hay que ver.
            Thread.Sleep(2000);
            //Limpiamos la consola.
            Console.Clear();
            goto Inicio;
        }

        //Pedimos los valores para que pueda hacer las operaciones correspondientes, si eligió otra cosa.
        Console.Write("Ingrese el valor de A: ");
        A = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingrese el valor de B: ");
        B = Convert.ToDecimal(Console.ReadLine());
        //Limpiamos la consola.
        Console.Clear();

        //El proceso que se debe de hacer.
        if (opcion == "1") goto Suma;
        if (opcion == "2") goto Resta;
        if (opcion == "3") goto Multiplicacion;
        if (opcion == "4") goto Division;

        Suma:
        {
            Console.WriteLine($"La suma de A y B: {A + B}");
            goto Salir;
        }
        Resta:
        {
            Console.WriteLine($"La resta de A y B: {A - B}");
            goto Salir;
        }
        Multiplicacion:
        {
            Console.WriteLine($"La multiplicación de A y B: {A * B}");
            goto Salir;
        }
        Division:
        {
            Console.WriteLine($"La división de A y B: {A / B}");
            goto Salir;
        }
        //Ultima opción
        Salir:
            Console.WriteLine("Gracias por usar nuestra app, adios. :D");
        
        //Te hace esperar 3 seg o un poco más.
        Thread.Sleep(3000);
        //fin
        Console.WriteLine("Presione cualquier letra para salir.");
        Console.ReadKey();
    }
}
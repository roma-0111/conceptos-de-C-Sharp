using System;
using System.Threading;


namespace pruebas_con_arrays;

class pruebasConArrays
{
    static void Main(string[] args)
    {
        int num = 1;
        num = num + 2;
        Console.WriteLine(num);
        //Muestra como se usa un Vector en el código, y muestra como se imprime.
        Vector();
    }

    public static void Vector()
    {
        //Declaro un Vector e instancio 5 valores.
        String[] nombresIngresados = new String[5];

        //Ingreso de nombres.
        Console.WriteLine("Debe ingresar 5 nombres:");
        int contador = nombresIngresados.Length;

        //Recorro al Vector para agregar los datos.
        for (int i = 0; i < contador; i++)
        {
            Console.Write("Nombre: ");
            nombresIngresados[i] = Console.ReadLine();
        }
        Console.WriteLine("Se ha ingresado los 5 nombres!\n");
        Thread.Sleep(2000);

        //Recorro al Vector para mostrar los datos.
        Console.WriteLine("Acontinuación se enlistarán los nombres:");
        Thread.Sleep(2000);
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"Nombre {i}: {nombresIngresados[i]}");
        }
        Console.WriteLine("");
        Console.ReadKey();
    }
}
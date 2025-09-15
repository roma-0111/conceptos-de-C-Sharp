//                                           Estructuras

//Se mostrará el uso básico de las estructuras, sea el: Vector, Lista, Diccionarios, Listas en Diccionarios.
//No se explica el funcionamiento por dentro.

//Romano Brian - Desarrollador C#

using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;


Console.WriteLine("\tVectores");
//Declaramos un Vector con valores
string[] frutas = ["Manzana", "Banana", "Cereza"];
//Las posiciones comienzan desde 0, osea que el 0 es el 1, jaja.
//Esta es la forma manual de agregar elementos
Console.WriteLine(frutas[0]);
Console.WriteLine(frutas[1]);
Console.WriteLine(frutas[2]);
Console.WriteLine("");
// y  así se puede como recorrer al Vector
for (int i = 0; i < 3; i++)
{
    //Al hacer esa operación en el mensaje, no se suma "i", sino que el resultado de esa operación se mostrará nomás.
    Console.WriteLine($"La caja de fruta {i + 1} tiene {frutas[i]}s.");
}

//---------------------------------------------------------

Console.WriteLine("\n\tListas 1");
//Declaramos una Lista
List<string> listaNombres = new List<string>();
//No se especifica la cantidad de elementos como en los Vectores, solo se usa como Métodos al parecer.

//Forma de agregar datos en las Listas:
listaNombres.Add("Brian");
listaNombres.Add("Roma");
listaNombres.Add("Alex");
listaNombres.Add("123");
// El .Add() es usado para agregar datos al final de la Lista, es la mejor manera de agregar datos.

if (listaNombres.Contains("123"))
{
    listaNombres.Remove("123");
}


for (int i = 0; i < 3; i++)
{
    //Se puede ver así si se sabe las cantidades.
    // Comúnmente se usa el foreach.
    Console.WriteLine(listaNombres[i]);
}

//---------------------------------------------------------

Console.WriteLine("\n\tListas 2");
List<string> listaLugares = new List<string>();
listaLugares.Add("EE.UU");
listaLugares.Add("Argentina");
listaLugares.Add("México");
listaLugares.Add("buenos Aires");

if (listaLugares.Contains("buenos Aires"))
{
    //Con .Remove() podemos especificar que dato queremos quitar
    listaLugares.Remove("buenos Aires"); // en este caso quitamos el dato que diga "buenos Aires"
    Console.WriteLine("Se quitó!");
}

Console.WriteLine("Estado final de la lista 2:");
foreach (string lugar in listaLugares)
{
    Console.WriteLine("Lugares: "+ lugar);
}

//---------------------------------------------------------

Console.WriteLine("\n\tLista 3");
List<string> Elementos = new List<string>();
Elementos.AddRange(listaLugares);
Elementos.AddRange(listaNombres);
Elementos.AddRange(frutas);
//.AddRange - Agrega los elementos que tiene en las estructuras (vector, lista, etc.) que se manden como argumento.

foreach (string element in Elementos)
{
    Console.WriteLine("Elemento: " + element);
}

//---------------------------------------------------------

Console.WriteLine("\n\tDiccionarios 1");
Dictionary<string, int> edadesPersonas = new Dictionary<string, int>();
//Declaro la clave tipo string y un valor de tipo int.


edadesPersonas["Roma"] = 21;
edadesPersonas["Brian"] = 21;
edadesPersonas["Alex"] = 20;
//Se le agrega la clave con su valor, la clave es "Roma" y su clave 21,
// si se repite la clave se reemplaza con el último valor puesto.
edadesPersonas["Alex"] = 21; // No es una buena práctica al hacer esto, es posible que causes bugs a futuro.
// como reemplazar valores de algo importante cuando no tiene que hacer eso, es un bug, por eso.

//Otra forma, más segura, para agregar claves con sus valores es:
edadesPersonas.Add("Romano Brian", 21); // Indicas la clave y el valor.
// edadesPersonas.Add("Romano Brian", 21); //Este da error, al ya existir una clave igual a esa. Por eso es más seguro.

//---------------------------------------------------------

Console.WriteLine("\tDiccionarios 2");
//Se declara un diccionario de tipo string las claves y de tipo List<> los valores,
// lo que se puede tener varios valores en conjunto.
Dictionary<string, List<double>> notas_de_alumnos = new Dictionary<string, List<double>>();
// y guardarlas directamente
notas_de_alumnos["Carla"] = new List<double> { 9.7, 7.0, 9.0 };
notas_de_alumnos["Pepe"] = new List<double> { 8.4, 7.9, 9.0 };
notas_de_alumnos["Yael"] = new List<double> { 7.9, 8.0, 9.0 };

//También crearlas aparte a la Lista
List<double> notas_de_Carlos = new List<double>();
notas_de_Carlos.Add(10.4);
notas_de_Carlos.Add(7.3);
notas_de_Carlos.Add(8.5);
// Y agregar la Lista al Diccionario.
notas_de_alumnos["Carlos"] = notas_de_Carlos;

//Esta es una forma de saber el promedio de los valores con Método de las Listas.
// notas_de_alumnos["Carla"].Average();

//Para recorrer a un diccionario se usa var, porque es un tipo de dato no tan común "string" con "List<double>"
foreach (var alumno in notas_de_alumnos)
{
    //Para saber el promedio es con ".Average()":
    double promedio = alumno.Value.Average();
    Console.WriteLine($"Estudiante:\t{alumno.Key}\nNota:\t\t{promedio.ToString("0.0000")}\n");
}











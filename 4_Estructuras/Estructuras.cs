//                                           Estructuras

//Se mostrará el uso básico de las estructuras, sea el: Vector, Lista, Diccionarios, Listas en Diccionarios.
//No se explica el funcionamiento por dentro.

//Romano Brian - Programador C#


using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("\t\tVectores");
//Declaramos un Vector con valores
string[] frutas = ["Manzana", "Banana", "Cereza"];
//Los índices (posiciones) comienzan desde 0, el cero cuenta como posición.
//Esta es la forma manual de agregar elementos.
Console.WriteLine(frutas[0]);
Console.WriteLine(frutas[1]);
Console.WriteLine(frutas[2]);
Console.WriteLine("");

//y así se puede como "recorrer" uno por uno al Vector.
for (int i = 0; i < 3; i++)
{
    //Al hacer esa operación en el mensaje, no se suma "i", sino que el resultado de esa operación se muestra.
    Console.WriteLine($"La caja de fruta {i + 1} tiene {frutas[i]}s.");
}

//---------------------------------------------------------

Console.WriteLine("\t\tListas 1");
//Declaramos una Lista de tipo string
List<string> listaNombres = new List<string>();
//No se especifica la cantidad de elementos como en los Vectores, solo se la declara y lo que le agreguemos será su tamaño, nose si hay límite.

//Forma de agregar datos en las Listas:
listaNombres.Add("Brian");
listaNombres.Add("Roma");
listaNombres.Add("Alex");
listaNombres.Add("123");
// El .Add() es usado para agregar datos al final de la Lista, es la mejor manera de agregar datos.

//Si en la lista contiene "123",
if (listaNombres.Contains("123"))
{
    // en tal caso eliminar/remover "123".
    listaNombres.Remove("123");
}

//Se puede ver así si se sabe las cantidades.
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(listaNombres[i]);
}


//---------------------------------------------------------


Console.WriteLine("\t\tListas 2");
//Declaramos una lista de tipo string
List<string> listaLugares = new List<string>();

//Agregamos los datos.
listaLugares.Add("EE.UU");
listaLugares.Add("Argentina");
listaLugares.Add("México");
listaLugares.Add("buenos Aires");

//Si contiene "buenos Aires".
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


Console.WriteLine("\t\tLista 3");
List<string> distintosElementos = new List<string>();
distintosElementos.AddRange(listaLugares);
distintosElementos.AddRange(listaNombres);
distintosElementos.AddRange(frutas);
//.AddRange - Agrega los elementos que tiene en diferentes estructuras creadas anteriormente (vector, lista, etc.) que se manden como argumento.

//Nos fijamos los elementos.
foreach (string elemento in distintosElementos)
{
    Console.WriteLine("Elemento: " + elemento);
}


//---------------------------------------------------------


Console.WriteLine("\n\tDiccionarios 1");
//Declaro un diccionario con la clave tipo string y un valor de tipo int.
Dictionary<string, int> edadesPersonas = new Dictionary<string, int>();

//Se debe agregar la clave con su valor, la clave es "Roma" y su clave 21,
// si se repite la clave se reemplaza con el último valor puesto.
edadesPersonas["Roma"] = 21;
edadesPersonas["Brian"] = 21;

//No es una buena práctica al hacer esto, es posible que causes bugs a futuro, por reemplazar valores, etc.
edadesPersonas["Alex"] = 20;
edadesPersonas["Alex"] = 21; 

//Otra forma, más segura, para agregar claves con sus valores es:
edadesPersonas.Add("Romano Brian", 21); // Indicas la clave y el valor.
//edadesPersonas.Add("Romano Brian", 21); // Este da error directamente, al ya existir una clave igual a esam pero el valor no pasa nada. Por eso es más seguro.


//---------------------------------------------------------


Console.WriteLine("\tDiccionarios 2");
//Se declara un diccionario con la clave de tipo string y el valor de tipo List<double>, lo que se puede tener varios valores en conjunto double en valor por ser una lista de tipo double como de valor del diccionario, si se puede mezclar las estructuras.
Dictionary<string, List<double>> notas_de_alumnos = new Dictionary<string, List<double>>();
//Se puede guardarlas directamente
notas_de_alumnos["Carla"] = new List<double> { 9.7, 7.0, 9.0 };
notas_de_alumnos["Pepe"] = new List<double> { 8.4, 7.9, 9.0 };
notas_de_alumnos["Yael"] = new List<double> { 7.9, 8.0, 9.0 };

//También crear aparte la Lista
List<double> notas_de_Carlos = new List<double>();
notas_de_Carlos.Add(10.4);
notas_de_Carlos.Add(7.3);
notas_de_Carlos.Add(8.5);
// Y agregar la Lista al Diccionario.
notas_de_alumnos["Carlos"] = notas_de_Carlos;

//Para recorrer a un diccionario se usa var, porque es un tipo de dato no tan común "string" con "List<double>", si var es como "cualquier tipo de dato funca".
foreach (var alumno in notas_de_alumnos)
{
    //Para saber el promedio es con ".Average()":
    double promedio = alumno.Value.Average();
    Console.WriteLine($"Estudiante:\t{alumno.Key}\nNota:\t\t{promedio.ToString("0.0000")}\n");
}


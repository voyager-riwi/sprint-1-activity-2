using System;
using System.Collections.Generic;

// NOTAS DE UN CURSO

// Lista para guardar las notas
List<double> notas = new List<double>();
bool seguirAgregando = true;

Console.WriteLine("--- BIENVENIDO AL SISTEMA DE NOTAS ---");
Console.WriteLine("Ingresa las notas de los estudiantes (de 1.0 a 5.0).");
Console.WriteLine("Escribe '0' para terminar y calcular los resultados.");

// Entrada de notas
while (seguirAgregando)
{
    Console.Write("Nueva nota: ");
    double notaIngresada = Convert.ToDouble(Console.ReadLine());

    if (notaIngresada == 0)
    {
        seguirAgregando = false;
    }
    else if (notaIngresada >= 1 && notaIngresada <= 5)
    {
        notas.Add(notaIngresada);
    }
    else
    {
        Console.WriteLine("Error: La nota debe estar entre 1.0 y 5.0.");
    }
}

// Procesar las notas
ProcesarNotas(notas);


//Función para procesar y mostrar los resultados 
void ProcesarNotas(List<double> listaDeNotas)
{
    Console.WriteLine("\n--- RESULTADOS DEL CURSO ---");

    if (listaDeNotas.Count == 0)
    {
        Console.WriteLine("No se ingresaron notas.");
        return;
    }

    double sumaTotal = 0;
    bool hayEstudiantesEnRiesgo = false;

    Console.WriteLine("Notas registradas:");
    for (int i = 0; i < listaDeNotas.Count; i++)
    {
        double notaActual = listaDeNotas[i];
        sumaTotal += notaActual;

        if (notaActual >= 3.0)
        {
            Console.WriteLine($"- Nota {notaActual}: Aprobó");
        }
        else
        {
            Console.WriteLine($"- Nota {notaActual}: Reprobó");
        }

        if (notaActual < 2.0)
        {
            hayEstudiantesEnRiesgo = true;
        }
    }

    double promedio = sumaTotal / listaDeNotas.Count;
    Console.WriteLine($"El promedio del grupo es: {promedio:F2}");

    if (hayEstudiantesEnRiesgo)
    {
        Console.WriteLine("ALERTA Hay estudiantes en riesgo académico.");
    }
}

// Segundo ejercicio conscurso de canto

List<string> concursantes = new List<string>();
bool seguirInscribiendo = true;

Console.WriteLine("--- SISTEMA DE INSCRIPCIÓN DEL CONCURSO ---");
Console.WriteLine("Ingresa los nombres de los concursantes.");
Console.WriteLine("Deja el nombre vacío y presiona Enter para terminar.");

// Bucle para añadir nombres
while (seguirInscribiendo)
{
    Console.Write("Nombre del concursante: ");
    string nombreIngresado = Console.ReadLine();

    // Si el usuario no escribe nada, salimos del bucle
    if (nombreIngresado == "")
    {
        seguirInscribiendo = false;
    }
    else
    {
        concursantes.Add(nombreIngresado);
        Console.WriteLine($"{nombreIngresado} ha sido inscrito.");
    }
}

// Llamamos a la función que gestiona el concurso
GestionarConcurso(concursantes);


// Función para mostrar la información del concurso
void GestionarConcurso(List<string> listaDeNombres)
{
    Console.WriteLine("INFORMACIÓN DEL CONCURSO");

    if (listaDeNombres.Count == 0)
    {
        Console.WriteLine("No hay concursantes inscritos.");
        return;
    }

    // Mostramos cuántos concursantes hay
    Console.WriteLine($"Total de concursantes inscritos: {listaDeNombres.Count}");

    Console.WriteLine("Lista de concursantes:");
    // Bucle para mostrar cada nombre
    foreach (string nombre in listaDeNombres)
    {
        Console.WriteLine($"- {nombre}");
    }

    // Buscamos si un nombre especifico está en la lista
    Console.Write("Escribe un nombre para ver si está inscrito: ");
    string nombreABuscar = Console.ReadLine();

    bool fueEncontrado = false;
    foreach (string nombre in listaDeNombres)
    {
        // convertimostodo a minusculas para evitar errores por mayusculas
        if (nombre.ToLower() == nombreABuscar.ToLower())
        {
            fueEncontrado = true;
            break;
        }
    }

    if (fueEncontrado)
    {
        Console.WriteLine($"Sí, '{nombreABuscar}' está en la lista de concursantes.");
    }
    else
    {
        Console.WriteLine($"No, '{nombreABuscar}' no fue encontrado.");
    }

    // Contamos cuantos nombres empiezan con A
    int contadorA = 0;
    foreach (string nombre in listaDeNombres)
    {
        if (nombre.ToUpper().StartsWith("A"))
        {
            contadorA = contadorA + 1;
        }
    }
    Console.WriteLine($"Número de concursantes cuyo nombre empieza con A: {contadorA}");
}

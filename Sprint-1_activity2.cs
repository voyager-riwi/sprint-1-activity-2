using System;
using System.Collections.Generic;

// NOTAS DE UN CURSO
// Lista para guardar las notas
List<double> notas = new List<double>();
bool seguirAgregando = true;

Console.WriteLine("BIENVENIDO AL SISTEMA DE NOTAS");
Console.WriteLine("Ingresa las notas de los estudiantes de 1.0 a 5.0.");
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
    Console.WriteLine("RESULTADOS DEL CURSO");

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

Console.WriteLine("SISTEMA DE INSCRIPCIÓN DEL CONCURSO");
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

    // Mostramos cuantos concursantes hay
    Console.WriteLine($"Total de concursantes inscritos: {listaDeNombres.Count}");

    Console.WriteLine("Lista de concursantes:");
    // Bucle para mostrar cada nombre
    foreach (string nombre in listaDeNombres)
    {
        Console.WriteLine($" {nombre}");
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
        Console.WriteLine($"Si, '{nombreABuscar}' está en la lista de concursantes.");
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


// CARRITO DE COMPRAS
// Aqui creo que si se justifica usar una clase, aunque apenas la estamos comprendiendo

public class Producto
{
    public string Nombre;
    public int Cantidad;
    public double Precio;
}

List<Producto> carrito = new List<Producto>();
bool seguirComprando = true;

Console.WriteLine("BIENVENIDO A LA TIENDA VIRTUAL");
Console.WriteLine("Agrega productos a tu carrito.");
Console.WriteLine("Escribe 'fin' en el nombre del producto para terminar.");

while (seguirComprando)
{
    Console.Write("Nombre del producto: ");
    string nombre = Console.ReadLine();

    if (nombre.ToLower() == "fin")
    {
        seguirComprando = false;
        continue; 
    }

    Console.Write("Cantidad: ");
    int cantidad = Convert.ToInt32(Console.ReadLine());

    Console.Write("Precio unitario: ");
    double precio = Convert.ToDouble(Console.ReadLine());

    // Creamos un nuevo objeto de tipo Producto y lo agregamos al carrito
    Producto nuevoProducto = new Producto();
    nuevoProducto.Nombre = nombre;
    nuevoProducto.Cantidad = cantidad;
    nuevoProducto.Precio = precio;
    carrito.Add(nuevoProducto);

    Console.WriteLine($"'{nombre}' fue agregado al carrito.");
}

// Llamamos la función
ProcesarCarrito(carrito);


//Función para mostrar el resumen de la compra
void ProcesarCarrito(List<Producto> listaDeProductos)
{
    Console.WriteLine("RESUMEN DE TU COMPRA");

    if (listaDeProductos.Count == 0)
    {
        Console.WriteLine("El carrito está vacío");
        return;
    }

    double totalCompra = 0;

    Console.WriteLine("Productos en el carrito:");
    foreach (Producto prod in listaDeProductos)
    {
        Console.WriteLine($" {prod.Nombre}  Cantidad: {prod.Cantidad}  Precio: ${prod.Precio}");
        
        if (prod.Cantidad == 0)
        {
            Console.WriteLine($" OHHH El producto '{prod.Nombre}' tiene cantidad 0.");
        }
        
        // Se calcula el costo total
        totalCompra = totalCompra + (prod.Cantidad * prod.Precio);
    }

    Console.WriteLine($"Subtotal de la compra: ${totalCompra}");

    // Revisamos si aplica el descuento
    if (totalCompra > 200)
    {
        double descuento = totalCompra * 0.10; 
        double totalConDescuento = totalCompra - descuento;
        Console.WriteLine($"Felicidades tu compra supera los $200 y tienes un descuento de ${descuento}");
        Console.WriteLine($"Total a pagar: ${totalConDescuento}");
    }
    else
    {
        Console.WriteLine($"Total a pagar: ${totalCompra}");
    }
}


// DATOS DE LOS EMPLEADOS 
// Usamos una clase simple tambien, es necesario para agrupar los datos
public class Empleado
{
    public string Nombre;
    public int Edad;
    public string Correo;
}

List<Empleado> empleados = new List<Empleado>();
bool seguirAgregando = true;

Console.WriteLine("SISTEMA DE REGISTRO DE EMPLEADOS");
Console.WriteLine("Ingresa los datos de los empleados.");
Console.WriteLine("Escribe 'fin' en el nombre para terminar.");

while (seguirAgregando)
{
    Console.Write("Nombre del empleado: ");
    string nombre = Console.ReadLine();

    if (nombre.ToLower() == "fin")
    {
        seguirAgregando = false;
        continue;
    }

    Console.Write("Edad: ");
    int edad = Convert.ToInt32(Console.ReadLine());

    Console.Write("Correo electrónico: ");
    string correo = Console.ReadLine();

    Empleado nuevoEmpleado = new Empleado();
    nuevoEmpleado.Nombre = nombre;
    nuevoEmpleado.Edad = edad;
    nuevoEmpleado.Correo = correo;
    empleados.Add(nuevoEmpleado);

    Console.WriteLine($"Empleado '{nombre}' registrado.");
}

ProcesarEmpleados(empleados);


// Función que muestra el reporte de empleados
void ProcesarEmpleados(List<Empleado> listaDeEmpleados)
{
    Console.WriteLine("REPORTE DE EMPLEADOS");

    // Revisamos si hay empleados
    if (listaDeEmpleados.Count == 0)
    {
        Console.WriteLine("No hay empleados registrados.");
        return;
    }

    int contadorMenores = 0;
    int edadMasAlta = 0;
    string nombreMasViejo = "";

    Console.WriteLine("Lista de empleados:");
    foreach (Empleado emp in listaDeEmpleados)
    {
        Console.WriteLine($" Nombre: {emp.Nombre}  Edad: {emp.Edad}  Correo: {emp.Correo}");

        // Contamos a los menores de edad
        if (emp.Edad < 18)
        {
            contadorMenores = contadorMenores + 1;
        }

        // Buscamos al empleado de mayor edad
        if (emp.Edad > edadMasAlta)
        {
            edadMasAlta = emp.Edad;
            nombreMasViejo = emp.Nombre;
        }
    }

    // Mostramos los resultados finales
    Console.WriteLine($"Número de empleados menores de edad: {contadorMenores}");
    Console.WriteLine($"El empleado de mayor edad es: {nombreMasViejo} con {edadMasAlta} años.");
}

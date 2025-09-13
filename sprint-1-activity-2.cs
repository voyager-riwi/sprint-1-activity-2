Console.WriteLine("Actividades");
Console.WriteLine();
Console.WriteLine("1. Notas de un curso");
Console.WriteLine("2. Concurso de canto");
Console.WriteLine("3. Carrito de compras");
Console.WriteLine("4. Gestión de empleados");
Console.WriteLine();

Console.Write("Elige una opción (1-4): ");
string opcion = Console.ReadLine();

while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
{
    Console.WriteLine("Opciones válidas: 1, 2, 3, 4");
    Console.Write("Elige una opción: ");
    opcion = Console.ReadLine();
}

if (opcion == "1")
{
    Console.WriteLine();
    Console.WriteLine(" NOTAS DE UN CURSO ");
    
    List<double> notas = new List<double>();
    
    Console.WriteLine("Ingresa las notas (1-5). Escribe 'fin' para terminar:");
    
    while (true)
    {
        Console.Write("Nota: ");
        string input = Console.ReadLine();
        
        if (input == "fin")
        {
            break;
        }
        
        if (double.TryParse(input, out double nota))
        {
            if (nota >= 1 && nota <= 5)
            {
                notas.Add(nota);
            }
            else
            {
                Console.WriteLine("La nota debe estar entre 1 y 5");
            }
        }
        else
        {
            Console.WriteLine("Debe ser un número");
        }
    }
    
    Console.WriteLine();
    Console.WriteLine(" RESULTADOS ");
    
    if (notas.Count == 0)
    {
        Console.WriteLine("No hay notas registradas");
    }
    else
    {
        Console.WriteLine("Todas las notas:");
        for (int i = 0; i < notas.Count; i++)
        {
            Console.WriteLine($"Nota {i + 1}: {notas[i]}");
        }
        
        Console.WriteLine();
        Console.WriteLine("Estados:");
        for (int i = 0; i < notas.Count; i++)
        {
            if (notas[i] >= 3)
            {
                Console.WriteLine($"Nota {i + 1}: {notas[i]} - APROBÓ");
            }
            else
            {
                Console.WriteLine($"Nota {i + 1}: {notas[i]} - REPROBÓ");
            }
        }
        
        double suma = 0;
        foreach (double nota in notas)
        {
            suma += nota;
        }
        double promedio = suma / notas.Count;
        Console.WriteLine();
        Console.WriteLine($"Promedio del grupo: {promedio:F2}");
        
        bool hayRiesgo = false;
        foreach (double nota in notas)
        {
            if (nota < 2)
            {
                hayRiesgo = true;
                break;
            }
        }
        
        if (hayRiesgo)
        {
            Console.WriteLine();
            Console.WriteLine("¡ALERTA: Hay estudiantes en riesgo académico!");
        }
    }
}

else if (opcion == "2")
{
    Console.WriteLine();
    Console.WriteLine(" CONCURSO DE CANTO ");
    
    List<string> participantes = new List<string>();
    
    Console.WriteLine("Ingresa los nombres de los participantes. Escribe 'fin' para terminar:");
    
    while (true)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        
        if (nombre == "fin")
        {
            break;
        }
        
        if (string.IsNullOrEmpty(nombre))
        {
            Console.WriteLine("El nombre no puede estar vacío");
        }
        else
        {
            participantes.Add(nombre);
        }
    }
    
    Console.WriteLine();
    Console.WriteLine(" PARTICIPANTES REGISTRADOS ");
    
    if (participantes.Count == 0)
    {
        Console.WriteLine("No hay participantes registrados");
    }
    else
    {
        for (int i = 0; i < participantes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {participantes[i]}");
        }
        
        Console.WriteLine();
        Console.WriteLine($"Total de participantes: {participantes.Count}");
        
        int nombresConA = 0;
        foreach (string nombre in participantes)
        {
            if (nombre.ToUpper().StartsWith("A"))
            {
                nombresConA++;
            }
        }
        Console.WriteLine($"Nombres que empiezan con 'A': {nombresConA}");
        
        Console.WriteLine();
        Console.Write("Buscar participante: ");
        string buscar = Console.ReadLine();
        
        bool encontrado = false;
        foreach (string nombre in participantes)
        {
            if (nombre.ToUpper() == buscar.ToUpper())
            {
                encontrado = true;
                break;
            }
        }
        
        if (encontrado)
        {
            Console.WriteLine($"'{buscar}' SÍ está inscrito");
        }
        else
        {
            Console.WriteLine($"'{buscar}' NO está inscrito");
        }
    }
}

else if (opcion == "3")
{
    Console.WriteLine();
    Console.WriteLine(" CARRITO DE COMPRAS ");
    
    List<string> nombres = new List<string>();
    List<int> cantidades = new List<int>();
    List<double> precios = new List<double>();
    
    Console.WriteLine("Agrega productos. Escribe 'fin' en el nombre para terminar:");
    
    while (true)
    {
        Console.Write("Nombre del producto: ");
        string nombre = Console.ReadLine();
        
        if (nombre == "fin")
        {
            break;
        }
        
        if (string.IsNullOrEmpty(nombre))
        {
            Console.WriteLine("El nombre no puede estar vacío");
            continue;
        }
        
        Console.Write("Cantidad: ");
        string inputCantidad = Console.ReadLine();
        if (!int.TryParse(inputCantidad, out int cantidad) || cantidad < 0)
        {
            Console.WriteLine("La cantidad debe ser un número positivo");
            continue;
        }
        
        Console.Write("Precio: ");
        string inputPrecio = Console.ReadLine();
        if (!double.TryParse(inputPrecio, out double precio) || precio < 0)
        {
            Console.WriteLine("El precio debe ser un número positivo");
            continue;
        }
        
        nombres.Add(nombre);
        cantidades.Add(cantidad);
        precios.Add(precio);
        
        Console.WriteLine("Producto agregado");
        Console.WriteLine();
    }
    
    Console.WriteLine();
    Console.WriteLine(" DETALLE DEL CARRITO ");
    
    if (nombres.Count == 0)
    {
        Console.WriteLine("Carrito vacío");
    }
    else
    {
        double total = 0;
        bool hayCantidadCero = false;
        
        for (int i = 0; i < nombres.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {nombres[i]} - Cantidad: {cantidades[i]} - Precio: ${precios[i]} - Subtotal: ${cantidades[i] * precios[i]:F2}");
            total += cantidades[i] * precios[i];
            
            if (cantidades[i] == 0)
            {
                hayCantidadCero = true;
            }
        }
        
        if (hayCantidadCero)
        {
            Console.WriteLine();
            Console.WriteLine("¡ADVERTENCIA: Hay productos con cantidad 0!");
        }
        
        Console.WriteLine();
        Console.WriteLine($"Subtotal: ${total:F2}");
        
        if (total > 200)
        {
            double descuento = total * 0.10;
            double totalConDescuento = total - descuento;
            Console.WriteLine($"Descuento 10%: ${descuento:F2}");
            Console.WriteLine($"TOTAL: ${totalConDescuento:F2}");
        }
        else
        {
            Console.WriteLine($"TOTAL: ${total:F2}");
        }
    }
}

else if (opcion == "4")
{
    Console.WriteLine();
    Console.WriteLine(" GESTIÓN DE EMPLEADOS ");
    
    List<string> nombres = new List<string>();
    List<int> edades = new List<int>();
    List<string> correos = new List<string>();
    
    Console.WriteLine("Ingresa los empleados. Escribe 'fin' en el nombre para terminar:");
    
    while (true)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        
        if (nombre == "fin")
        {
            break;
        }
        
        if (string.IsNullOrEmpty(nombre))
        {
            Console.WriteLine("El nombre no puede estar vacío");
            continue;
        }
        
        Console.Write("Edad: ");
        string inputEdad = Console.ReadLine();
        if (!int.TryParse(inputEdad, out int edad) || edad < 0 || edad > 100)
        {
            Console.WriteLine("La edad debe ser un número entre 0 y 100");
            continue;
        }
        
        Console.Write("Correo: ");
        string correo = Console.ReadLine();
        
        if (string.IsNullOrEmpty(correo))
        {
            Console.WriteLine("El correo no puede estar vacío");
            continue;
        }
        
        nombres.Add(nombre);
        edades.Add(edad);
        correos.Add(correo);
        
        Console.WriteLine("Empleado agregado");
        Console.WriteLine();
    }
    
    Console.WriteLine();
    Console.WriteLine(" EMPLEADOS REGISTRADOS ");
    
    if (nombres.Count == 0)
    {
        Console.WriteLine("No hay empleados registrados");
    }
    else
    {
        int menoresEdad = 0;
        int mayorEdad = 0;
        string nombreMayor = "";
        
        for (int i = 0; i < nombres.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {nombres[i]} - Edad: {edades[i]} - Correo: {correos[i]}");
            
            if (edades[i] < 18)
            {
                menoresEdad++;
            }
            
            if (edades[i] > mayorEdad)
            {
                mayorEdad = edades[i];
                nombreMayor = nombres[i];
            }
        }
        
        Console.WriteLine();
        Console.WriteLine($"Menores de edad: {menoresEdad}");
        Console.WriteLine($"Empleado de mayor edad: {nombreMayor} ({mayorEdad} años)");
    }
}

Console.WriteLine();
Console.WriteLine("Programa terminado. Presiona Enter para salir.");
Console.ReadLine();

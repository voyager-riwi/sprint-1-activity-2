// ejercicio 1
bool salir = false;
List<int> notes = new();

while (!salir)
{
    Console.WriteLine("Bienvenido al sistema de registro de notas");
    Console.WriteLine("Elije una de las opciones\n" +
                      "1. Registro de notas\n" +
                      "2. Mostrar notas\n" +
                      "3. Calcular notas\n" +
                      "4. Salir\n");
    Console.Write("Introduce una opción:");
    string opcion = Console.ReadLine();
    int opcionInt = int.Parse(opcion);

    switch (opcionInt)
    {
        case 1:
            Console.WriteLine("Por favor inserte la nota (1-5)");
            string note = Console.ReadLine();
            notes.Add(int.Parse(note));
            break;
        case 2:
            if (notes.Count == 0)
            {
                Console.WriteLine("No hay notas registradas");
            }
            else
            {
                Console.WriteLine("Notas registradas:");
                foreach (int n in notes)
                {
                    if (n >= 3)
                    {
                        Console.WriteLine($"{n}, Esta nota esta aprobada");
                    }
                    else
                    {
                        Console.WriteLine($"{n}, Este estudiante esta en riesgo academico");
                    }
                }
            }
            break;
        case 3:
            if (notes.Count > 0)
            {
                int promedio = (int)Math.Round(notes.Average());
                Console.WriteLine($"Promedio de notas: {promedio}");
            }
            else
            {
                Console.WriteLine("No hay notas registradas.");
            } 
            break;
        case 4:
            Console.WriteLine("Saliendo del programa...");
            salir = true;
            break;
    }
}

// ejercicio 2
bool salir = false;
List<string> concursantes = new();

while (!salir)
{
    Console.WriteLine("Bienvenido al sistema de registro de notas");
    Console.WriteLine("Elije una de las opciones\n" +
                      "1. Registro de concursantes\n" +
                      "2. Mostrar concursantes\n" +
                      "3. Editar concursantes\n" +
                      "4. Eliminar concursantes\n" +
                      "5. Busqueda concursante\n" +
                      "6. Total concursante\n" +
                      "7. Busqueda concursante con letra A\n" +
                      "8. Salir\n");
    Console.Write("Introduce una opción:");
    string opcion = Console.ReadLine();
    int opcionInt = int.Parse(opcion);

    switch (opcionInt)
    {
        case 1:
            Console.WriteLine("Por favor ingrese nombre del concursante");
            string name = Console.ReadLine();
            concursantes.Add(name);
            break;
        case 2:
            if (concursantes.Count == 0)
            {
                Console.WriteLine("No hay concursantes");
            }
            else
            {
                foreach (string n in concursantes)
                {
                    Console.WriteLine(n);
                }
            }
            break;
        case 3:
            Console.WriteLine("Por favor ingrese nombre del concursante a editar");
            string nameEdit = Console.ReadLine();
            int indice = concursantes.IndexOf(nameEdit);
            
            if (indice != -1)
            {
                Console.WriteLine($"Por favor digite el nuevo nombre para {nameEdit}");
                string newName = Console.ReadLine();
                concursantes[indice] = newName;
                Console.WriteLine("Nombre editado con éxito.");
            }
            else
            {
                Console.WriteLine("El concursante no fue encontrado.");
            }
            break;
        case 4:
            Console.WriteLine("Por favor ingrese nombre del concursante a eliminar");
            string nameDelete = Console.ReadLine();
            int indiceDelete = concursantes.IndexOf(nameDelete);
            
            if (indiceDelete != -1)
            {
                concursantes.Remove(nameDelete);
                Console.WriteLine("Nombre eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("El concursante no fue encontrado.");
            }
            break;
        case 5:
            Console.Write("Escribe un nombre para buscar si está en la lista: ");
            string nameSearch = Console.ReadLine();

            if (concursantes.Contains(nameSearch))
            {
                Console.WriteLine($"¡Sí, '{nameSearch}' está inscrito en el concurso!");
            }
            else
            {
                Console.WriteLine($"No, '{nameSearch}' no se encuentra en la lista.");
            }
            break;
        case 6:
            if (concursantes.Count > 0)
            {
                Console.WriteLine($"El total de concursantes es {concursantes.Count}");
            }
            else
            {
                Console.WriteLine("No hay concursantes registrados.");
            } 
            break;
        case 7:
            int countA = 0;
            foreach (string concursante in concursantes)
            {
                if (concursante.ToUpper().StartsWith("A"))
                {
                    countA++;
                }
            }
            Console.WriteLine($"Hay {countA} concursante(s) cuyo nombre empieza con la letra 'A'.");
            break;
        case 8:
            Console.WriteLine("Saliendo del programa....");
            salir = true;
            break;
    }
}

// ejercicio 3

List<List<object>> carrito = new List<List<object>>();

int opcion = 0;

while (opcion != 6)
{
    Console.WriteLine("\n===== Carrito de Compras =====");
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Mostrar carrito");
    Console.WriteLine("3. Actualizar producto");
    Console.WriteLine("4. Eliminar producto");
    Console.WriteLine("5. Calcular total");
    Console.WriteLine("6. Salir");
    Console.Write("Elige una opción: ");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.Write("Nombre del producto: ");
        string nombre = Console.ReadLine();

        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.Write("Precio: ");
        double precio = double.Parse(Console.ReadLine());

        carrito.Add(new List<object> { nombre, cantidad, precio });
        Console.WriteLine($"Producto '{nombre}' agregado.");
    }
    else if (opcion == 2)
    {
        Console.WriteLine("\n===== Detalle del Carrito =====");
        if (carrito.Count == 0)
        {
            Console.WriteLine("Carrito vacío.");
        }
        else
        {
            int i = 1;
            foreach (var producto in carrito)
            {
                string nombre = (string)producto[0];
                int cantidad = (int)producto[1];
                double precio = (double)producto[2];

                Console.WriteLine($"{i}. {nombre} - Cantidad: {cantidad} - Precio: {precio}");
                if (cantidad == 0)
                {
                    Console.WriteLine("Advertencia: este producto tiene cantidad 0");
                }
                i++;
            }
        }
    }
    else if (opcion == 3)
    {
        Console.Write("Nombre del producto a actualizar: ");
        string nombre = Console.ReadLine();

        bool encontrado = false;
        foreach (var producto in carrito)
        {
            if ((string)producto[0] == nombre)
            {
                Console.Write("Nueva cantidad (dejar vacío si no cambia): ");
                string entradaCantidad = Console.ReadLine();
                if (entradaCantidad != "")
                {
                    producto[1] = int.Parse(entradaCantidad);
                }

                Console.Write("Nuevo precio (dejar vacío si no cambia): ");
                string entradaPrecio = Console.ReadLine();
                if (entradaPrecio != "")
                {
                    producto[2] = double.Parse(entradaPrecio);
                }

                Console.WriteLine($"Producto '{nombre}' actualizado.");
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine($"No se encontró el producto '{nombre}'.");
        }
    }
    else if (opcion == 4)
    {
        Console.Write("Nombre del producto a eliminar: ");
        string nombre = Console.ReadLine();

        int index = carrito.FindIndex(p => (string)p[0] == nombre);

        if (index != -1)
        {
            carrito.RemoveAt(index);
            Console.WriteLine($"Producto '{nombre}' eliminado.");
        }
        else
        {
            Console.WriteLine($"No se encontró el producto '{nombre}'.");
        }
    }
    else if (opcion == 5)
    {
        double total = 0;
        foreach (var producto in carrito)
        {
            int cantidad = (int)producto[1];
            double precio = (double)producto[2];
            total += cantidad * precio;
        }

        Console.WriteLine($"\nSubtotal: {total:F2}");

        if (total > 200000)
        {
            double descuento = total * 0.10;
            total -= descuento;
            Console.WriteLine($"Descuento aplicado: -{descuento:F2}");
        }

        Console.WriteLine($" Total a pagar: {total:F2}");
    }
    else if (opcion == 6)
    {
        Console.WriteLine("¡Gracias por usar el carrito!");
        System.Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Opción inválida, intenta de nuevo.");
    }
}

// ejercicio 4

List<string> nombres = new List<string>();
List<int> edades = new List<int>();
List<string> correos = new List<string>();

int opcion = 0;
while (opcion != 6)
{
    Console.WriteLine("\n===== CRUD Empleados =====");
    Console.WriteLine("1. Registrar (Crear)");
    Console.WriteLine("2. Listar (Leer)");
    Console.WriteLine("3. Actualizar (Actualizar)");
    Console.WriteLine("4. Eliminar (Eliminar)");
    Console.WriteLine("5. Estadísticas (menores + más viejo)");
    Console.WriteLine("6. Salir");
    Console.Write("Elige una opción: ");
    
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());
        if (edad < 0)
        {
            Console.WriteLine("Edad inválida. Registro cancelado.");
            continue;
        }

        Console.Write("Correo: ");
        string correo = Console.ReadLine() ?? "";

        nombres.Add(nombre);
        edades.Add(edad);
        correos.Add(correo);

        Console.WriteLine($"Empleado '{nombre}' registrado.");
    }
    else if (opcion == 2)
    {
        if (nombres.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados.");
            continue;
        }

        Console.WriteLine("\n===== Empleados registrados =====");
        for (int i = 0; i < nombres.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {nombres[i]} - Edad: {edades[i]} - Correo: {correos[i]}");
        }
    }
    else if (opcion == 3)
    {
        if (nombres.Count == 0)
        {
            Console.WriteLine("No hay empleados para actualizar.");
            continue;
        }

        Console.WriteLine("\nSeleccione el número del empleado a actualizar:");
        for (int i = 0; i < nombres.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {nombres[i]}");
        }

        int num = int.Parse(Console.ReadLine());
        if (num < 1 || num > nombres.Count)
        {
            Console.WriteLine("Selección inválida.");
            continue;
        }

        int idx = num - 1;

        Console.Write($"Nuevo nombre (Enter para mantener '{nombres[idx]}'): ");
        string nuevoNombre = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(nuevoNombre))
        {
            nombres[idx] = nuevoNombre;
        }

        Console.Write($"Nueva edad (Enter para mantener {edades[idx]}): ");
        string nuevaEdadTxt = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(nuevaEdadTxt))
        {
            int nuevaEdad = int.Parse(nuevaEdadTxt);
            if (nuevaEdad >= 0)
            {
                edades[idx] = nuevaEdad;
            }
            else
            {
                Console.WriteLine("Edad inválida. Se mantiene la anterior.");
            }
        }

        Console.Write($"Nuevo correo (Enter para mantener '{correos[idx]}'): ");
        string nuevoCorreo = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(nuevoCorreo))
        {
            correos[idx] = nuevoCorreo;
        }

        Console.WriteLine("Empleado actualizado.");
    }
    else if (opcion == 4)
    {
        if (nombres.Count == 0)
        {
            Console.WriteLine("No hay empleados para eliminar.");
            continue;
        }

        Console.WriteLine("\nSeleccione el número del empleado a eliminar:");
        for (int i = 0; i < nombres.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {nombres[i]}");
        }

        int numDel = int.Parse(Console.ReadLine());
        if (numDel < 1 || numDel > nombres.Count)
        {
            Console.WriteLine("Selección inválida.");
            continue;
        }

        int idxDel = numDel - 1;
        Console.Write($"¿Eliminar a '{nombres[idxDel]}'? (s/n): ");
        string confirm = Console.ReadLine() ?? "";
        if (confirm.Trim().ToLower().StartsWith("s"))
        {
            nombres.RemoveAt(idxDel);
            edades.RemoveAt(idxDel);
            correos.RemoveAt(idxDel);
            Console.WriteLine("Empleado eliminado.");
        }
        else
        {
            Console.WriteLine("Eliminación cancelada.");
        }
    }
    else if (opcion == 5)
    {
        if (nombres.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados.");
            continue;
        }

        int menores = 0;
        int mayorEdad = edades[0];
        string empleadoMayor = nombres[0];

        for (int i = 0; i < edades.Count; i++)
        {
            if (edades[i] < 18) menores++;
            if (edades[i] > mayorEdad)
            {
                mayorEdad = edades[i];
                empleadoMayor = nombres[i];
            }
        }

        Console.WriteLine($"\nMenores de edad: {menores}");
        Console.WriteLine($"Empleado de mayor edad: {empleadoMayor} ({mayorEdad} años)");
    }
    else if (opcion == 6)
    {
        Console.WriteLine("Saliendo...");
    }
    else
    {
        Console.WriteLine("⚠ Opción inválida.");
    }
}




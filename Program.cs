using System.IO;
using System.Text.Json;
using Inventario;

Console.Title = "Inventario de Productos";

Inventario.Inventario inventario = new Inventario.Inventario();
string carpeta = Path.Combine(AppContext.BaseDirectory, "Data");
Directory.CreateDirectory(carpeta);
string filePath = Path.Combine(carpeta, "productos.json");

int opcion;

do
{
    //Console.Clear();

    Console.WriteLine("Bienvenido al Inventario de Productos");
    Console.WriteLine("================================");
    Console.WriteLine("     Sistemas de Inventario     ");
    Console.WriteLine("================================");
    Console.WriteLine();
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Mostrar productos");
    Console.WriteLine("3. Buscar producto");
    Console.WriteLine("4. Editar producto");
    Console.WriteLine("5. Eliminar producto");
    Console.WriteLine("6. Entrada de mercancía");
    Console.WriteLine("7. Salida de mercancía");
    Console.WriteLine("8. Guardar");
    Console.WriteLine("9. Cargar");
    Console.WriteLine("0. Salir");

    Console.Write("Opción: ");
    opcion = int.Parse(Console.ReadLine() ?? string.Empty);

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Agregar producto");
            Console.Write("Ingrese el nombre del producto: ");
            String nombre = Console.ReadLine() ?? string.Empty;
            
            Console.Write("Ingrese la descripción del producto: ");
            String descripcion = Console.ReadLine() ?? string.Empty;
            
            Console.Write("Ingrese el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Ingrese el stock del producto: ");
            int stock = int.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.Write("Ingrese la categoría del producto: ");
            String categoria = Console.ReadLine() ?? string.Empty;

            inventario.AgregarProducto(new Producto
            {
                ID = inventario.VerProductos().Count + 1,
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precio,
                Stock = stock,
                Categoria = categoria
            });
            break;

        case 2:
            Console.WriteLine("Mostrar productos");
            List<Producto> productos = inventario.VerProductos();
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos en el inventario.");
            }
            else
            {
                foreach (var producto in productos)
                {
                    Console.WriteLine($"ID: {producto.ID}");
                    Console.WriteLine($"Nombre: {producto.Nombre}");
                    Console.WriteLine($"Descripción: {producto.Descripcion}");
                    Console.WriteLine($"Precio: {producto.Precio}");
                    Console.WriteLine($"Stock: {producto.Stock}");
                    Console.WriteLine($"Categoría: {producto.Categoria}");
                    Console.WriteLine($"=========================================");
                }
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine("Buscar producto");
            Console.Write("Ingrese el nombre del producto a buscar: ");
            string nombreBusqueda = Console.ReadLine() ?? string.Empty;

            var productoEncontrado = inventario.VerProductos().Where(c => c.Nombre.Contains(nombreBusqueda, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            
            if (productoEncontrado != null)
            {
                foreach (var producto in inventario.VerProductos().Where(c => c.Nombre.Contains(nombreBusqueda, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"ID: {producto.ID}");
                    Console.WriteLine($"Nombre: {producto.Nombre}");
                    Console.WriteLine($"Descripción: {producto.Descripcion}");
                    Console.WriteLine($"Precio: {producto.Precio}");
                    Console.WriteLine($"Stock: {producto.Stock}");
                    Console.WriteLine($"Categoría: {producto.Categoria}");
                    Console.WriteLine($"=========================================");
                }
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
            break;

        case 4:
            Console.WriteLine("Editar producto");
            Console.Write("Ingrese el ID del producto a editar: ");
            int idEditar = int.Parse(Console.ReadLine() ?? string.Empty);

            var productoEditar = inventario.VerProductos().FirstOrDefault(p => p.ID == idEditar);
            if (productoEditar != null)
            {
                Console.Write("Ingrese el nuevo nombre del producto (deje en blanco para no cambiar): ");
                string nuevoNombre = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    productoEditar.Nombre = nuevoNombre;
                }

                Console.Write("Ingrese la nueva descripción del producto (deje en blanco para no cambiar): ");
                string nuevaDescripcion = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(nuevaDescripcion))
                {
                    productoEditar.Descripcion = nuevaDescripcion;
                }

                Console.Write("Ingrese el nuevo precio del producto (deje en blanco para no cambiar): ");
                string nuevoPrecioInput = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(nuevoPrecioInput) && decimal.TryParse(nuevoPrecioInput, out decimal nuevoPrecio))
                {
                    productoEditar.Precio = nuevoPrecio;
                }

                Console.Write("Ingrese el nuevo stock del producto (deje en blanco para no cambiar): ");
                string nuevoStockInput = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(nuevoStockInput) && int.TryParse(nuevoStockInput, out int nuevoStock))
                {
                    productoEditar.Stock = nuevoStock;
                }

                Console.Write("Ingrese la nueva categoría del producto (deje en blanco para no cambiar): ");
                string nuevaCategoria = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(nuevaCategoria))
                {
                    productoEditar.Categoria = nuevaCategoria;
                }

                Console.WriteLine("Producto actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
            break;

        case 5:
            Console.WriteLine("Eliminar producto");
            Console.Write("Ingrese el ID del producto a eliminar: ");
            int idEliminar = int.Parse(Console.ReadLine() ?? string.Empty);

            var productoEliminar = inventario.VerProductos().FirstOrDefault(p => p.ID == idEliminar);
            if (productoEliminar != null)
            {
                inventario.VerProductos().Remove(productoEliminar);
                Console.WriteLine("Producto eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
            break;

        case 6:
            Console.WriteLine("Entrada de mercancía");
            Console.Write("Ingrese el ID del producto para la entrada de mercancía: ");
            int idEntrada = int.Parse(Console.ReadLine() ?? string.Empty);

            var productoEntrada = inventario.VerProductos().FirstOrDefault(p => p.ID == idEntrada);
            if (productoEntrada != null)
            {
                Console.Write("Ingrese la cantidad a agregar al stock: ");
                int cantidadEntrada = int.Parse(Console.ReadLine() ?? string.Empty);
                productoEntrada.Stock += cantidadEntrada;
                Console.WriteLine("Stock actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
            break;

        case 7:
            Console.WriteLine("Salida de mercancía");
            Console.Write("Ingrese el ID del producto para la salida de mercancía: ");
            int idSalida = int.Parse(Console.ReadLine() ?? string.Empty);

            var productoSalida = inventario.VerProductos().FirstOrDefault(p => p.ID == idSalida);
            if (productoSalida != null)
            {
                Console.Write("Ingrese la cantidad a quitar del stock: ");
                int cantidadSalida = int.Parse(Console.ReadLine() ?? string.Empty);
                if (cantidadSalida <= productoSalida.Stock)
                {
                    productoSalida.Stock -= cantidadSalida;
                    Console.WriteLine("Stock actualizado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Cantidad insuficiente en stock.");
                }
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
            break;

        case 8:
            Console.WriteLine("Guardar productos en el archivo productos.json");
            string json = JsonSerializer.Serialize(inventario.VerProductos(), new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            Console.WriteLine($"Productos guardados exitosamente en: {Path.GetFullPath(filePath)}");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
            break;

        case 9:
            Console.WriteLine("Cargar productos desde archivo JSON");
            if (File.Exists(filePath))
            {
                string jsonCargar = File.ReadAllText(filePath);
                List<Producto> productosCargados = JsonSerializer.Deserialize<List<Producto>>(jsonCargar) ?? new List<Producto>();
                inventario = new Inventario.Inventario();
                foreach (var producto in productosCargados)
                {
                    inventario.AgregarProducto(producto);
                }
                Console.WriteLine("Productos cargados exitosamente.");
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Archivo de productos no encontrado.");
            }
            break;

        case 0:
            Console.WriteLine("Saliendo del programa...");
            break;
        
        default:
            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
            break;
    }

}while (opcion != 0);
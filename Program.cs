using System.IO;
using System.Text.Json;
using Inventario;

Console.Title = "Inventario de Productos";

Inventario.Inventario inventario = new Inventario.Inventario();
string filePath = "productos.json";

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
                    Console.WriteLine($"ID: {producto.ID}, Nombre: {producto.Nombre}, Descripción: {producto.Descripcion}, Precio: {producto.Precio}, Stock: {producto.Stock}, Categoría: {producto.Categoria}");
                }
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
            break;
        
        default:
            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
            break;
    }

}while (opcion != 0);
namespace Inventario
{
    public class Inventario
    {
        private readonly List<Producto> productos = [];
        public Inventario()
        {
            productos = new List<Producto>();
        }
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }
        public List<Producto> VerProductos()
        {
            return productos;
        }
    }
}
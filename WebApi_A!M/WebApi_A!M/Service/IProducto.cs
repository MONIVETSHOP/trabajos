using WebApi_A_M.Model;

namespace WebApi_A_M.Service
{
    public interface IProducto
    {
        IEnumerable<Producto>GetAllProductos();
        Producto ObtenerPorId(int id);
        void add(Producto obj);
        void modificar(Producto obj);
        void eliminar(int id);
    }
}

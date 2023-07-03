using Microsoft.Extensions.ObjectPool;
using System.Threading;
using WebApi_A_M.Model;

namespace WebApi_A_M.Service
{
    public class ProductoRepository : IProducto

    {
        public static List<Producto> lstProducto = new List<Producto>()
        {
            new Producto() { Id = 1, descripcion="lacteos", monto=20.00, stock=5},
            new Producto() { Id = 2, descripcion = "arroz", monto = 4.50, stock = 5},
            new Producto() { Id = 3, descripcion = "leche", monto = 5.00, stock = 5 },
            new Producto() { Id = 4, descripcion = "carne", monto = 28.00, stock = 5},
            new Producto() { Id = 5, descripcion = "agua", monto = 1.50, stock = 5},
    };

        public void add(Producto obj)
        {
            lstProducto.Add(obj);
        }

        public void eliminar(int id)
        {
            lstProducto.Remove(ObtenerPorId(id));
        }

        public IEnumerable<Producto> GetAllProductos()
        {
            return lstProducto;
        }

        public void modificar(Producto objPro)
        {
            var obj = lstProducto.Where(tpro => tpro.Id == objPro.Id).FirstOrDefault();
            obj.descripcion = objPro.descripcion;
            obj.monto = objPro.monto;
            obj.stock = objPro.stock;

        }

        public Producto ObtenerPorId(int id)
        {
          return lstProducto.Where(tpro => tpro.Id == id).FirstOrDefault();

        }
    }
}

using BackendPvTest.EntityDB;
using BackendPvTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BackendPvTest.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public async Task<List<Producto>> GetProduct()
        {
            EntityContext entityContext = new EntityContext();
            return entityContext.Productos.ToList();
        }

        [HttpGet]
        public async Task<List<Departamento>> GetDep()
        {
            EntityContext entityContext = new EntityContext();
            return entityContext.Departamentos.ToList();
        }

        [HttpPost]
        public async Task<object> AddProduct(ProductModel request)
        {
            Producto producto = new Producto() { Descripcion = request.Description, IdDepartamento = request.DepartmentId, Precio = request.Price };
            EntityContext entityContext = new EntityContext();
            entityContext.Productos.Add(producto);
            await entityContext.SaveChangesAsync();
            var result = new { SellId = producto.IdProducto, Status = true };
            return result;
        }

        [HttpPost]
        public async Task<object> EditProduct(ProductModel request)
        {
            EntityContext entityContext = new EntityContext();
            Producto producto = entityContext.Productos.Where(e => e.IdProducto == request.ProductId).FirstOrDefault();
            producto.Descripcion = request.Description;
            producto.IdDepartamento = request.DepartmentId;
            producto.Precio = request.Price;
            await entityContext.SaveChangesAsync();
            var result = new { SellId = producto.IdProducto, Status = true };
            return result;
        }
    }
}

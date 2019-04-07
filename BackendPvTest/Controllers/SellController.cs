using BackendPvTest.EntityDB;
using BackendPvTest.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BackendPvTest.Controllers
{
    public class SellController : ApiController
    {
        [HttpPost]
        public async Task<object> AddSell(SellModel request)
        {
            EntityContext entityContext = new EntityContext();
            var venta = entityContext.Ventas.Add(new Venta()
            {
                CantidadProductos = request.SubSellList.Select(e=>e.Quantity).Sum(),
                IdUsuario = request.UserId,
                Fecha = DateTime.Now,
                ImporteTotal = request.SubSellList.Select(e => e.Total).Sum()
            });
            entityContext.SaveChanges();
            foreach(SubSellModel subSell in request.SubSellList)
            {
                entityContext.SubVentas.Add(new SubVentas()
                {
                    Cantidad = subSell.Quantity,
                    IdProducto = subSell.ProductId,
                    IdVenta = venta.IdVenta,
                    Importe = subSell.Total
                });
            }
            entityContext.SaveChanges();
            return new { SellId = venta.IdVenta, Status = true };
        }
        [HttpGet]
        public async Task<List<SellListResult>> GetSell()
        {
            List<SellListResult> result = new List<SellListResult>();
            EntityContext entityContext = new EntityContext();
            var sellList = entityContext.Ventas.ToList();
            foreach(Venta venta in sellList)
            {
                result.Add(new SellListResult() { Date = venta.Fecha, Quantity = venta.CantidadProductos, SellId = venta.IdVenta, Total = venta.ImporteTotal });
            }
            return result;
        }
    }
}

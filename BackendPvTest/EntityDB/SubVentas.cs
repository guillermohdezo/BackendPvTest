using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendPvTest.EntityDB
{
    public class SubVentas
    {
        [Key]
        [Column(Order = 0)]
        public int IdVenta { get; set; }
        [Key]
        [Column(Order = 1)]
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }

        [JsonIgnore]
        public virtual Venta Venta { get; set; }
        [JsonIgnore]
        public virtual Producto Producto { get; set; }
    }
}
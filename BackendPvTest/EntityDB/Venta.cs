using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BackendPvTest.EntityDB
{
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        public decimal ImporteTotal { get; set; }
        public int CantidadProductos { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }

        [JsonIgnore]
        public virtual Usuario Usuario { get; set; }
        [JsonIgnore]
        public virtual ICollection<SubVentas> SubVentas { get; set; }
    }
}
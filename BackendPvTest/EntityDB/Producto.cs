using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BackendPvTest.EntityDB
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int IdDepartamento { get; set; }

        [JsonIgnore]
        public virtual Departamento Departamento { get; set; }
        [JsonIgnore]
        public virtual ICollection<SubVentas> SubVentas { get; set; }
    }
}
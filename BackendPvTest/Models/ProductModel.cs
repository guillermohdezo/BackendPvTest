using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendPvTest.Models
{
    public class ProductModel
    {
        [JsonProperty(PropertyName = "IdProducto")]
        public int ProductId { get; set; }
        [JsonProperty(PropertyName = "Descripcion")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "Precio")]
        public decimal Price { get; set; }
        [JsonProperty(PropertyName = "IdDepartamento")]
        public int DepartmentId { get; set; }
        public decimal Total { get; set; }
    }
}
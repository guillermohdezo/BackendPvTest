using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BackendPvTest.EntityDB
{
    public class EntityContext : DbContext
    {
        public EntityContext() : base("name=EntityContext")
        {
            Database.SetInitializer<EntityContext>(new CreateDatabaseIfNotExists<EntityContext>());
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<SubVentas> SubVentas { get; set; }
    }
}
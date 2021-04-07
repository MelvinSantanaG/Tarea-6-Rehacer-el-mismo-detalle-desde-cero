using Microsoft.EntityFrameworkCore;
using Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.Entidades;

namespace Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<RolesDetalle> RolesDetalles { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\GestionRoles.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                new Permisos() { PermisoId = 1, Descripcion = "Administrador" },
                new Permisos() { PermisoId = 2, Descripcion = "Programador"},
                new Permisos() { PermisoId = 3, Descripcion = "Diseñador"}
                );
        }
    }
}

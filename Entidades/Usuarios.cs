using System;
using System.ComponentModel.DataAnnotations;

namespace Tarea_6_Rehacer_el_mismo_detalle_desde_cero.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Alias { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Activo { get; set; }

        public int RolId { get; set; }
    }
}

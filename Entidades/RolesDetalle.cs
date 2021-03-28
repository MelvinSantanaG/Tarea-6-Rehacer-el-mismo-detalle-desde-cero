using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tarea_6_Rehacer_el_mismo_detalle_desde_cero.Entidades
{
    public class RolesDetalle
    {
        [Key]
        public int RolDetalleId { get; set; }
        public int RolId { get; set; }
        public int PermisoId { get; set; }
        public bool EsAsignado { get; set; }

        public RolesDetalle()
        {
            RolDetalleId = 0;
            RolId = 0;
            PermisoId = 0;
            EsAsignado = true;
        }
    }
}

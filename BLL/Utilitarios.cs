using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.BLL
{
    public static class Utilitarios
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;

            int.TryParse(valor, out retorno);

            return retorno;
        }
    }
}

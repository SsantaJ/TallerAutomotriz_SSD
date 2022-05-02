using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerAutomotriz_SSD
{
    class Detalle_Prestacion : Detalle_Atencion
    {
        private List<Prestacion> prestacion = new List<Prestacion>();

        public Detalle_Prestacion(List<Prestacion> prestacion)
        {
            this.prestacion = prestacion;
        }
    }
}

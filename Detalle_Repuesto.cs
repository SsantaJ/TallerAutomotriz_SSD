using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerAutomotriz_SSD
{
    class Detalle_Repuesto : Detalle_Atencion
    {
        private List<Repuesto> repuesto = new List<Repuesto>();

        public Detalle_Repuesto(List<Repuesto> repuesto)
        {
            this.repuesto = repuesto;
        }
    }
}

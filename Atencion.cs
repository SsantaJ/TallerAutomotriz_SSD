using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerAutomotriz_SSD
{
    class Atencion
    {
        //ATRIBUTOS
        private DateTime fecha; //Fecha realizada la atencion
        private double valor_total; //El valor total de la atencion, o la venta que se realizara
        private List<Cliente> cliente = new List<Cliente>();  // el cliente(singular) al que se le hace la atencion
        private List<Detalle_Atencion> detalles_atenciones = new List<Detalle_Atencion>(); //Los detalles de atencion que se le realizaron a dicha atencion

        //CONSTRUCTOR
        public Atencion(DateTime fecha, double valor_total, List<Cliente> cliente, List<Detalle_Atencion> detalles_atenciones)
        {
            this.fecha = fecha;
            this.valor_total = valor_total;
            this.cliente = cliente;
            this.detalles_atenciones = detalles_atenciones;
        }

        //PROPIEDADES
        public DateTime Fecha { get => fecha; protected set => fecha = value; }
        public double Valor_total { get => valor_total; protected set => valor_total = value; }
        internal List<Cliente> Cliente { get => cliente; set => cliente = value; }
        internal List<Detalle_Atencion> Detalles_atenciones { get => detalles_atenciones; set => detalles_atenciones = value; }

        //METODOS

    }
}

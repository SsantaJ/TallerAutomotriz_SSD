using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerAutomotriz_SSD
{
    class Detalle_Atencion
    {
        //ATRIBUTOS
        private double precio_detalle; //precio total del detalle 
        private int cantidad_atentida; // cantidad que se va a vender en la atencion ya sea de prestacion o de repuesto

        //CONSTRUCTOR
        public Detalle_Atencion(double precio_detalle, int cantidad_atentida)
        {
            this.precio_detalle = precio_detalle;
            this.cantidad_atentida = cantidad_atentida;
        }

        //PROPIEDADES
        public double Precio_detalle { get => precio_detalle; protected set => precio_detalle = value; }
        public int Cantidad_atentida { get => cantidad_atentida; protected set => cantidad_atentida = value; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerAutomotriz_SSD
{
    class Repuesto
    {
        //ATRIBUTOS
        private string nombre_repuesto; //nombre del respuesto
        private int codigo; //codigo unico que identifica el repuesto
        private string unidad_medida; //unidad de medida por el cual va ser evaluado el repuesto (unidades, litros, etc...)
        private double precio_UM; //precio que sera calculado por la unidad de medida
        private int cant_disp_rep; //cantidad disponibles del repuesto

        //CONSTRUCTOR
        public Repuesto(string nombre_repuesto, int codigo, string unidad_medida, double precio_UM, int cant_disp_rep)
        {
            this.nombre_repuesto = nombre_repuesto;
            this.codigo = codigo;
            this.unidad_medida = unidad_medida;
            this.precio_UM = precio_UM;
            this.cant_disp_rep = cant_disp_rep;
        }

        //PROPIEDADES
        public string Nombre_repuesto { get => nombre_repuesto; protected set => nombre_repuesto = value; }
        public int Codigo { get => codigo; protected set => codigo = value; }
        public string Unidad_medida { get => unidad_medida; protected set => unidad_medida = value; }
        public double Precio_UM { get => precio_UM; protected set => precio_UM = value; }
        public int Cant_disp_rep { get => cant_disp_rep; set => cant_disp_rep = value; } //lo coloque sin portected ya que la cantidad disponible puede cambiar desde otras clases

        //METODOS

        public void añadirRepuesto()
        {
            //implementacion
        }

        public void borrarRepuesto()
        {
            //implementacion
        }

        public void editarRepuesto()
        {
            //implementacion
        }
    }
}

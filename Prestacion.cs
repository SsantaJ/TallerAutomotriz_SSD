using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerAutomotriz_SSD
{
    class Prestacion
    {
        //ATRIBUTOS
        private string nombre_prestacion; //nombre de la prestacion
        // private int codigo_prestacion; //codigo unico que identifica la prestacion ( si si se coloca, se debe cambiar el nombre en la clase de Repuesto)
        private double precio_prestacion; //precio de la prestacion

        //CONSTRUCTOR
        public Prestacion(string nombre_prestacion, double precio_prestacion)
        {
            this.nombre_prestacion = nombre_prestacion;
            this.precio_prestacion = precio_prestacion;
        }

        //PROPIEDADES
        public string Nombre_prestacion { get => nombre_prestacion; protected set => nombre_prestacion = value; }
        public double Precio_prestacion { get => precio_prestacion; protected set => precio_prestacion = value; }

        //METODOS

        public void añadirPrestacion()
        {
            //implementacion
        }

        public void borrarPrestacion()
        {
            //implementacion
        }
        public void editarPrestacion()
        {
            //implementacion
        }
    }
}

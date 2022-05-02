using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerAutomotriz_SSD
{
    class Cliente
    {
        //ATRIBUTOS
        private string nombre_cliente; //nombre del cliente
        private string cedula;
        private int nro_contacto; //numero de contecto
        private string correo;
        private Boolean esPreferencial;

        //CONSTRUCTOR
        public Cliente(string nombre_cliente, string cedula, int nro_contacto, string correo, bool esPreferencial)
        {
            this.nombre_cliente = nombre_cliente;
            this.cedula = cedula;
            this.nro_contacto = nro_contacto;
            this.correo = correo;
            this.esPreferencial = esPreferencial;
        }

        //PROPIEDADES
        public string Nombre_cliente { get => nombre_cliente; protected set => nombre_cliente = value; }
        public string Cedula { get => cedula; protected set => cedula = value; }
        public int Nro_contacto { get => nro_contacto; protected set => nro_contacto = value; }
        public string Correo { get => correo; protected set => correo = value; }
        public bool EsPreferencial { get => esPreferencial; protected set => esPreferencial = value; }

        //METODOS

    }
}

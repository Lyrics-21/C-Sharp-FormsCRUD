using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_De_Clases
{
    public class Arquero : Personaje
    {
        //Atributos con Propiedades get set
        public TipoArco TipoArco { get; set; }
        public int CantidadFlechas { get; set; }

        //Constructores
        public Arquero() { }
        public Arquero(int vida, string nombre, int nivel, string estilo, int daño, TipoArco tipoArco, int cantidadFlechas) : base(vida, nombre, nivel, estilo, daño)
        {
            this.TipoArco = tipoArco;
            this.CantidadFlechas = cantidadFlechas;
        }
        public Arquero(int vida, string nombre, int nivel, string estilo, int daño, TipoArco tipoArco) : this(vida, nombre, nivel, estilo, daño, tipoArco, 5)
        {

        }
        //Constructor de Arquero sin Daño
        public Arquero(int vida, string nombre, int nivel, string estilo, TipoArco tipoArco, int cantidadFlechas) : this(vida, nombre, nivel, estilo, 100, tipoArco, cantidadFlechas)
        {

        }

        public Arquero(int vida, string nombre, int nivel, string estilo, TipoArco tipoArco) : this(vida, nombre, nivel, estilo, 100, tipoArco, 5)
        {

        }
        //Constructor Arquero sin Vida
        public Arquero(string nombre, int nivel, string estilo, int daño, TipoArco tipoArco, int cantidadFlechas) : this(1000, nombre, nivel, estilo, daño, tipoArco, cantidadFlechas)
        {

        }
        public Arquero(string nombre, int nivel, string estilo, int daño, TipoArco tipoArco) : this(1000, nombre, nivel, estilo, daño, tipoArco, 5)
        {

        }
        //Constructos sin Vida ni Daño
        public Arquero(string nombre, int nivel, string estilo, TipoArco tipoArco, int cantidadFlechas) : this(1000, nombre, nivel, estilo, 100, tipoArco, cantidadFlechas)
        {

        }
        public Arquero(string nombre, int nivel, string estilo, TipoArco tipoArco) : this(1000, nombre, nivel, estilo, 100, tipoArco, 5)
        {

        }
        //Sobreescribo Tostring 
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Arco : {this.TipoArco.ToString()}");
            sb.AppendLine($"Cantidad de flechas : {this.CantidadFlechas}");
            return sb.ToString();
        }
    }
}

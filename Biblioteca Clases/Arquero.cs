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
        public TipoArco TipoArco { get; set; }
        public int CantidadFlechas { get; set; }

        public Arquero() { }
        public Arquero(int vida, string nombre, int nivel, string estilo, int daño, TipoArco tipoArco, int cantidadFlechas) : base(vida, nombre, nivel, estilo, daño)
        {
            this.TipoArco = tipoArco;
            this.CantidadFlechas = cantidadFlechas;
        }
        public Arquero(int vida, string nombre, int nivel, string estilo, int daño, TipoArco tipoArco) : this(vida, nombre, nivel, estilo, daño, tipoArco, 5)
        {
        }
        public Arquero(int vida, string nombre, int nivel, string estilo, int daño) : this(vida, nombre, nivel, estilo, daño, TipoArco.Madera, 5)
        {

        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Arco : {this.TipoArco.ToString()}");
            sb.AppendLine($"Cantidad de flechas : {this.CantidadFlechas}");
            return sb.ToString();
        }

        public static Coleccion operator +(Coleccion co, Personaje personaje)
        {
            if (!co.listPersonajes.Any(c => c == personaje))
            {
                co.listPersonajes.Add(personaje);
            }
            return co;
        }
    }
}

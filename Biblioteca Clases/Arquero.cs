using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_De_Clases
{
    internal class Arquero : Personaje
    {
        private string tipoArco;
        private int cantidadFlechas;

        public Arquero(int vida, string nombre, int nivel, string estilo, int daño, string tipoArco, int cantidadFlechas) : base(vida, nombre, nivel, estilo, daño)
        {
            this.tipoArco = tipoArco;
            this.cantidadFlechas = cantidadFlechas;
        }
        public Arquero(int vida, string nombre, int nivel, string estilo, int daño, string tipoArco) : this(vida, nombre, nivel, estilo, daño, tipoArco, 5)
        {
        }
        public Arquero(int vida, string nombre, int nivel, string estilo, int daño) : this(vida, nombre, nivel, estilo, daño, "Madera Taxus baccata", 5)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Arco: {this.tipoArco}");
            sb.AppendLine($"Cantidad de flechas: {this.cantidadFlechas}");
            return sb.ToString();
        }
    }
}

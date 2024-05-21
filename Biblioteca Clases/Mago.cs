using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_De_Clases
{
    internal class Mago : Personaje
    {
        private string tipoMagia;
        private int mana;

        public Mago(int vida, string nombre, int nivel, string estilo, int daño, string tipoMagia, int mana) : base(vida, nombre, nivel, estilo, daño)
        {
            this.tipoMagia = tipoMagia;
            this.mana = mana;
        }

        public Mago(int vida, string nombre, int nivel, string estilo, int daño, string tipoMagia) : this(vida, nombre, nivel, estilo, daño, tipoMagia, 100)
        {

        }
        public Mago(int vida, string nombre, int nivel, string estilo, int daño) : this(vida, nombre, nivel, estilo, daño, "Elemental tipo Aire", 100)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Tipo de magia {this.tipoMagia}");
            sb.AppendLine($"Mana: {this.mana}");
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_De_Clases
{
    public class Mago : Personaje
    {
        public TipoMagia TipoMagia { get; set; }
        public int Mana { get; set; }

        public Mago() { }
        public Mago(int vida, string nombre, int nivel, string estilo, int daño, TipoMagia tipoMagia, int mana) : base(vida, nombre, nivel, estilo, daño)
        {
            this.TipoMagia = tipoMagia;
            this.Mana = mana;
        }

        public Mago(int vida, string nombre, int nivel, string estilo, int daño, TipoMagia tipoMagia) : this(vida, nombre, nivel, estilo, daño, tipoMagia, 100)
        {

        }
        public Mago(int vida, string nombre, int nivel, string estilo, int daño) : this(vida, nombre, nivel, estilo, daño, TipoMagia.Elemental, 100)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Tipo de magia {this.TipoMagia.ToString()}");
            sb.AppendLine($"Mana: {this.Mana}");
            return sb.ToString();
        }
    }
}

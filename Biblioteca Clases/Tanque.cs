using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_De_Clases
{
    internal class Tanque : Personaje
    {
        private string tipoArmadura;
        private int fuerza;

        public Tanque(int vida, string nombre, int nivel, string estilo, int daño, string armadura, int fuerza) : base(vida, nombre, nivel, estilo, daño)
        {
            this.tipoArmadura = armadura;
            this.fuerza = fuerza;
        }
        public Tanque(int vida, string nombre, int nivel, string estilo, int daño, string armadura) : this(vida, nombre, nivel, estilo, daño, armadura, 500)
        {

        }
        public Tanque(int vida, string nombre, int nivel, string estilo, int daño) : this(vida, nombre, nivel, estilo, daño, "Piel Oso", 500)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Tipo de armadura: {this.tipoArmadura}");
            sb.AppendLine($"Fuerza: {this.fuerza}");
            return sb.ToString();
        }
    }
}

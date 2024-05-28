using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_De_Clases
{
    public class Tanque : Personaje
    {
        private TipoArmadura tipoArmadura;
        private int fuerza;

        public Tanque(int vida, string nombre, int nivel, string estilo, int daño, TipoArmadura armadura, int fuerza) : base(vida, nombre, nivel, estilo, daño)
        {
            this.tipoArmadura = armadura;
            this.fuerza = fuerza;
        }
        public Tanque(int vida, string nombre, int nivel, string estilo, int daño, TipoArmadura armadura) : this(vida, nombre, nivel, estilo, daño, armadura, 500)
        {

        }
        public Tanque(int vida, string nombre, int nivel, string estilo, int daño) : this(vida, nombre, nivel, estilo, daño, TipoArmadura.Cuero, 500)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Tipo de armadura: {this.tipoArmadura.ToString()}");
            sb.AppendLine($"Fuerza: {this.fuerza}");
            return sb.ToString();
        }
    }
}

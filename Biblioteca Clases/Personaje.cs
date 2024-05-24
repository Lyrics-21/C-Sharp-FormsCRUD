using System.Text;

namespace Libreria_De_Clases
{
     abstract class Personaje
    {
        private int vida;
        private string nombre;
        private int nivel;
        private string estilo;
        private int daño;

        public Personaje(int vida, string nombre, int nivel, string estilo, int daño)
        {
            this.vida = vida;
            this.nombre = nombre;
            this.nivel = nivel;
            this.estilo = estilo;
            this.daño = daño;
        }
        public Personaje(int vida, string nombre, string estilo, int daño) : this(vida, nombre, 0, estilo, daño)
        {

        }
        public Personaje(string nombre, string estilo, int daño) : this(0, nombre, 0, estilo, daño)
        {

        }

        public string mostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Vida: {this.vida}");
            sb.AppendLine($"Nivel: {this.nivel}");
            sb.AppendLine($"Estilo: {this.estilo}");
            sb.AppendLine($"Daño: {this.daño}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return mostrarInfo();
        }
    }
}

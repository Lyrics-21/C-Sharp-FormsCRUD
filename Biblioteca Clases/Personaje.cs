using System.Text;

namespace Libreria_De_Clases
{
     public abstract class Personaje
    {
        public int Vida { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public string Estilo { get; set; }
        public int Daño { get; set; }

        public Personaje() { }
        public Personaje(int vida, string nombre, int nivel, string estilo, int daño)
        {
            this.Vida = vida;
            this.Nombre = nombre;
            this.Nivel = nivel;
            this.Estilo = estilo;
            this.Daño = daño;
        }
        public Personaje(int vida, string nombre, string estilo, int daño) : this (vida, nombre, 1, estilo, daño)
        {

        }
        public Personaje(string nombre, string estilo, int daño) : this (1000, nombre, 1, estilo, daño)
        {

        }
        public string mostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Vida: {this.Vida}");
            sb.AppendLine($"Nivel: {this.Nivel}");
            sb.AppendLine($"Estilo: {this.Estilo}");
            sb.AppendLine($"Daño: {this.Daño}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return mostrarInfo();
        }
    }
}

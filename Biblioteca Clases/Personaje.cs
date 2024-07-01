using System.Text;

namespace Libreria_De_Clases
{
    public abstract class Personaje
    {
        //Atributos con propiedad get set
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
        public Personaje(int vida, string nombre, int nivel, string estilo) : this(vida, nombre, nivel, estilo, 100)
        {

        }
        public Personaje(string nombre, int nivel, string estilo, int daño) : this(1000, nombre, nivel, estilo, daño)
        {

        }
        public Personaje(string nombre, int nivel, string estilo) : this(1000, nombre, nivel, estilo, 100)
        {

        }

        //Genero metodo abstracto que sobrescribe ToString
        public abstract override string ToString();

        //Sobrecarga operados == que verifica si el nombre y estilo del personaje son iguales
        public static bool operator ==(Personaje personaje1, Personaje personaje2)
        {
            if (personaje1 is null || personaje2 is null)
            {
                return false;
            }
            else
            {
                return (personaje1.Nombre == personaje2.Nombre && personaje1.Estilo == personaje2.Estilo);
            }
        }
        //De lo contrario false
        public static bool operator !=(Personaje personaje1, Personaje personaje2)
        {
            return !(personaje1 == personaje2);
        }

        //Sobreescribo Equals usando el == y si el objeto es distitno a null, y es personaje, y ese personaje es igual al this retorna true
        public override bool Equals(object? obj)
        {
            if (obj is Personaje && obj != null)
            {
                return ((Personaje)obj) == this;
            }
            else
            {
                return false;
            }
        }

        //Sobrecarga operador Implicit Explicit
        public static implicit operator string(Personaje personaje)
        {
            return personaje.Nombre;
        }
        public static explicit operator int(Personaje personaje)
        {
            return personaje.Nivel;
        }
    }
}

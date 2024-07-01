using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_De_Clases
{
    public class Tanque : Personaje
    {
        public TipoArmadura TipoArmadura { get; set; }
        public int Fuerza { get; set; }
        public Tanque() { }

        public Tanque(int vida, string nombre, int nivel, string estilo, int daño, TipoArmadura armadura, int fuerza) : base(vida, nombre, nivel, estilo, daño)
        {
            this.TipoArmadura = armadura;
            this.Fuerza = fuerza;
        }
        public Tanque(int vida, string nombre, int nivel, string estilo, int daño, TipoArmadura armadura) : this(vida, nombre, nivel, estilo, daño, armadura, 1000)
        {

        }
        //Constructor de Tanque sin Daño
        public Tanque(int vida, string nombre, int nivel, string estilo, TipoArmadura armadura, int fuerza) : this(vida, nombre, nivel, estilo, 500, armadura, fuerza)
        {

        }

        public Tanque(int vida, string nombre, int nivel, string estilo, TipoArmadura armadura) : this(vida, nombre, nivel, estilo, 500, armadura, 1000)
        {

        }
        //Constructor Tanque sin Vida
        public Tanque(string nombre, int nivel, string estilo, int daño, TipoArmadura armadura, int fuerza) : this(5000, nombre, nivel, estilo, daño, armadura, fuerza)
        {

        }
        public Tanque(string nombre, int nivel, string estilo, int daño, TipoArmadura armadura) : this(5000, nombre, nivel, estilo, daño, armadura, 1000)
        {

        }
        //Constructos Tanque sin Vida ni Daño
        public Tanque(string nombre, int nivel, string estilo, TipoArmadura armadura, int fuerza) : this(5000, nombre, nivel, estilo, 500, armadura, fuerza)
        {

        }
        public Tanque(string nombre, int nivel, string estilo, TipoArmadura armadura) : this(5000, nombre, nivel, estilo, 500, armadura, 1000)
        {

        }

        //Sobreescribo Tostring
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Vida: {this.Vida}");
            sb.AppendLine($"Nivel: {this.Nivel}");
            sb.AppendLine($"Estilo: {this.Estilo}");
            sb.AppendLine($"Daño: {this.Daño}");
            sb.AppendLine($"Tipo de armadura: {this.TipoArmadura.ToString()}");
            sb.AppendLine($"Fuerza: {this.Fuerza}");
            return sb.ToString();
        }

        //Sobrecarga operados == que verifica si el nombre y estilo del personaje son iguales
        public static bool operator ==(Tanque tanque1, Tanque tanque2)
        {
            if (tanque1 is null || tanque2 is null)
            {
                return false;
            }
            else
            {
                return (tanque1.Nombre == tanque2.Nombre);
            }
        }
        //De lo contrario false
        public static bool operator !=(Tanque tanque1, Tanque tanque2)
        {
            return !(tanque1 == tanque2);
        }

        //Sobreescribo Equals usando el == y si el objeto es distitno a null, y es arquero, y ese arquero es igual al this retorna true
        public override bool Equals(object? obj)
        {
            if (obj is Tanque && obj != null)
            {
                return ((Tanque)obj) == this;
            }
            else
            {
                return false;
            }
        }

        //Sobrecarga operador Implicit Explicit
        public static implicit operator string(Tanque tanque)
        {
            return tanque.Nombre;
        }
        public static explicit operator int(Tanque tanque)
        {
            return tanque.Nivel;
        }
    }
}

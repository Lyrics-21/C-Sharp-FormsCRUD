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
        public Mago(int vida, string nombre, int nivel, string estilo, int daño, TipoMagia tipoMagia) : this(vida, nombre, nivel, estilo, daño, tipoMagia, 500)
        {

        }
        //Constructor de Mago sin Daño
        public Mago(int vida, string nombre, int nivel, string estilo, TipoMagia tipoMagia, int mana) : this(vida, nombre, nivel, estilo, 100, tipoMagia, mana)
        {

        }

        public Mago(int vida, string nombre, int nivel, string estilo, TipoMagia tipoMagia) : this(vida, nombre, nivel, estilo, 100, tipoMagia, 500)
        {

        }
        //Constructor Mago sin Vida
        public Mago(string nombre, int nivel, string estilo, int daño, TipoMagia tipoMagia, int mana) : this(1000, nombre, nivel, estilo, daño, tipoMagia, mana)
        {

        }
        public Mago(string nombre, int nivel, string estilo, int daño, TipoMagia tipoMagia) : this(1000, nombre, nivel, estilo, daño, tipoMagia, 500)
        {

        }
        //Constructos Mago sin Vida ni Daño
        public Mago(string nombre, int nivel, string estilo, TipoMagia tipoMagia, int mana) : this(1000, nombre, nivel, estilo, 100, tipoMagia, mana)
        {

        }
        public Mago(string nombre, int nivel, string estilo, TipoMagia tipoMagia) : this(1000, nombre, nivel, estilo, 100, tipoMagia, 500)
        {

        }

        //Sobreescribo Tostring
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Tipo de magia : {this.TipoMagia.ToString()}");
            sb.AppendLine($"Mana: {this.Mana}");
            return sb.ToString();
        }

        //Sobrecarga operados == que verifica si el nombre y estilo del personaje son iguales
        public static bool operator ==(Mago mago1, Mago mago2)
        {
            if (mago1 is null || mago2 is null)
            {
                return false;
            }
            else
            {
                return (mago1.Nombre == mago2.Nombre);
            }
        }
        //De lo contrario false
        public static bool operator !=(Mago mago1, Mago mago2)
        {
            return !(mago1 == mago2);
        }

        //Sobreescribo Equals usando el == y si el objeto es distitno a null, y es arquero, y ese arquero es igual al this retorna true
        public override bool Equals(object? obj)
        {
            if (obj is Mago && obj != null)
            {
                return ((Mago)obj) == this;
            }
            else
            {
                return false;
            }
        }

        //Sobrecarga operador Implicit Explicit
        public static implicit operator string(Mago mago)
        {
            return mago.Nombre;
        }
        public static explicit operator int(Mago mago)
        {
            return mago.Nivel;
        }
    }
}

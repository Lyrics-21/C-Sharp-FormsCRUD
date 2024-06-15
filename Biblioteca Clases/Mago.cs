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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Tipo de magia : {this.TipoMagia.ToString()}");
            sb.AppendLine($"Mana: {this.Mana}");
            return sb.ToString();
        }
        public static bool operator ==(Mago mago1, Mago mago2)
        {
            if (mago1 is null || mago2 is null)
            {
                return false;
            }
            else
            {
                return (mago1.TipoMagia == mago2.TipoMagia && mago1.Nombre == mago2.Nombre);
            }
        }
        public static bool operator !=(Mago mago1, Mago mago2)
        {
            return !(mago1 == mago2);
        }
    }
}

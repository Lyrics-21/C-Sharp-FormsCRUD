using Libreria_De_Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca_Clases
{
    public class Coleccion
    {
        public List<Personaje> listPersonajes;
        public Coleccion()
        {
            this.listPersonajes = new List<Personaje>();
        }
        public static bool operator ==(Coleccion co, Personaje personaje)

        {
            return co.listPersonajes.Contains(personaje);
        }

        public static bool operator !=(Coleccion co, Personaje personaje)
        {
            return !(co == personaje);
        }
        public static Coleccion operator +(Coleccion co, Personaje personaje)
        {
            if (!co.listPersonajes.Any(c => c == personaje))
            {
                co.listPersonajes.Add(personaje);
            }
            return co;
        }
        public static Coleccion operator -(Coleccion co, Personaje personaje)
        {
            int index = co.listPersonajes.FindIndex(c => c == personaje);
            if (index >= 0)
            {
                co.listPersonajes.RemoveAt(index);
            }
            return co;
        }
    }
}
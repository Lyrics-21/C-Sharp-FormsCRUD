using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Libreria_De_Clases
{
    public class Coleccion
    {
        //Lista de personajes, aca se guarda ya sea un Arquero, Tanque o Mago
        public List<Personaje> listPersonajes;
        public Coleccion()
        {
            this.listPersonajes = new List<Personaje>();
        }

        //Sobrecarga del operador == si personaje esta dentro de la lista de personajes devuelve true
        public static bool operator ==(Coleccion co, Personaje personaje)

        {
            return co.listPersonajes.Contains(personaje);
        }

        //De lo contrario false
        public static bool operator !=(Coleccion co, Personaje personaje)
        {
            return !(co == personaje);
        }

        //Sobrecarga operador + agrega a el personaje a la lista de personaje siempre y cuando este no este en la lista y devuelve esa lista
        public static Coleccion operator +(Coleccion co, Personaje personaje)
        {
            co.listPersonajes.Add(personaje);
            return co;
        }

        //Encuentra el indice seleccionado y si ese indice coincide con un personaje si conincide lo saca de la lista 
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
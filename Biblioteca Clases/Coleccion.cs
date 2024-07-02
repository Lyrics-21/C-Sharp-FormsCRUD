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
    public class Coleccion<T> where T : class
    {
        //Lista de personajes, aca se guarda ya sea un Arquero, Tanque o Mago
        public List<T> listaColeccion;
        public Coleccion()
        {
            this.listaColeccion = new List<T>();
        }

        //Sobrecarga del operador == si personaje esta dentro de la lista de personajes devuelve true
        public static bool operator ==(Coleccion<T> co, T t)

        {
            return co.listaColeccion.Contains(t);
        }

        //De lo contrario false
        public static bool operator !=(Coleccion<T> co, T t)
        {
            return !(co == t);
        }

        //Sobrecarga operador + agrega a el personaje a la lista de personaje siempre y cuando este no este en la lista y devuelve esa lista
        public static Coleccion<T> operator +(Coleccion<T> co, T t)
        {
            co.listaColeccion.Add(t);
            return co;
        }

        //Encuentra el indice seleccionado y si ese indice coincide con un personaje si conincide lo saca de la lista 
        public static Coleccion<T> operator -(Coleccion<T> co, T t)
        {
            if(co == t)
            {
                co.listaColeccion.Remove(t);
            }
            return co;
        }
    }
}
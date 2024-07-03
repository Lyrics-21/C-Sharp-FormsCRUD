using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Libreria_De_Clases;

namespace TestUnitario
{
    [TestClass]
    public class Personajes_Test
    {
        [TestMethod]
        public void VerificarEqualsArqueros_Ok()
        {
            // Arrange
            Arquero arquero1 = new Arquero("nombre1", 21, "Arquero/a", TipoArco.Carbono);
            Arquero arquero2 = new Arquero("nombre1", 12, "Arquero/a", TipoArco.Magico);

            // Act
            bool rta = arquero1.Equals(arquero2);

            // Assert
            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarEqualsArqueros_Falla()
        {
            // Arrange
            Arquero arquero1 = new Arquero("nombre1", 2, "Arquero/a", TipoArco.Aluminio);
            Arquero arquero2 = new Arquero("nombre2", 2, "Arquero/a", TipoArco.Aluminio);

            // Act
            bool rta = arquero1.Equals(arquero2);

            // Assert
            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarEqualsPersonajes_Ok()
        {
            // Arrange
            Mago mago1 = new Mago("nombre1", 21, "Mago", TipoMagia.Divina);
            Mago mago2 = new Mago("nombre1", 12, "Mago", TipoMagia.Oscura);

            // Act
            bool rta = mago1.Equals(mago2);

            // Assert
            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarEqualsPersonajes_Falla()
        {
            // Arrange
            Mago mago1 = new Mago("nombre1", 21, "Mago", TipoMagia.Divina);
            Mago mago2 = new Mago("nombre2", 21, "Mago", TipoMagia.Oscura);

            // Act
            bool rta = mago1.Equals(mago2);

            // Assert
            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarEliminarPersonaje_Ok()
        {
            // Arrange
            Coleccion<Personaje> coleccion = new Coleccion<Personaje>();
            Mago mago1 = new Mago("Leo Messi", 10, "Mago", TipoMagia.Divina);
            coleccion += mago1;

            // Act
            coleccion -= mago1;
            bool rta = !coleccion.listaColeccion.Contains(mago1);

            // Assert
            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarEliminarPersonaje_Falla()
        {
            // Arrange
            Coleccion<Personaje> coleccion = new Coleccion<Personaje>();
            Mago mago1 = new Mago("Leo Messi", 10, "Mago", TipoMagia.Divina);

            // Act
            coleccion -= mago1;
            bool rta = !coleccion.listaColeccion.Contains(mago1);

            // Assert
            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarAgregarPersonaje_Ok()
        {
            // Arrange
            Coleccion<Personaje> coleccion = new Coleccion<Personaje>();
            Tanque tanque1 = new Tanque("Jhon Wick", 5000, "Tanque", TipoArmadura.Adamantium);

            // Act
            coleccion += tanque1;
            bool rta = coleccion.listaColeccion.Contains(tanque1);

            // Assert
            Assert.IsTrue(rta);
        }

        [TestMethod]
        public void VerificarAgregarPersonaje_Falla()
        {
            // Arrange
            Coleccion<Personaje> coleccion = new Coleccion<Personaje>();
            Tanque tanque1 = new Tanque("Jhon Wick", 5000, "Tanque", TipoArmadura.Adamantium);

            // Act
            bool rta = !coleccion.listaColeccion.Contains(tanque1);

            // Assert
            Assert.IsTrue(rta);
        }
    }
}


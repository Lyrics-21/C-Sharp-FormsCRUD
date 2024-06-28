using System;

namespace Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            if (formLogin.DialogResult == DialogResult.OK)
            {
                formLogin.Close();
                Application.Run(new Formulario1());
            }
        }
    }
}



//NO genera m�todo abstracto.

//Faltan sobrecargas de operadores implicit/explicit en clases derivadas

//? Poder elegir la ubicaci�n del archivo para la serializaci�n / deserializaci�n

//(utilizando controles de tipo OpenFileDialog y SaveFileDialog)

//Agregar la posibilidad de poder ordenar los objetos de la colecci�n con, al menos, dos criterios

//distintos de ordenamiento. Cada criterio de ordenaci�n deber� incluir el modo ascendente y
//descendente.
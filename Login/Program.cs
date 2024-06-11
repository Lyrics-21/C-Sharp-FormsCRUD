using System;

namespace Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        //Faltan más comentarios XML
        //Faltan sobrecargas de operadores ==, Equals, ToString, implicit/explicit en clases derivadas
        //La clave se debería mostrar en modo 'password'.

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
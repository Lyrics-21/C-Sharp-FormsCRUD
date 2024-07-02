using Libreria_De_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public delegate void DelegadoUsuarios();

    public partial class Usuarios : Form
    {
        private Task task;
        private string datosUsuario;
        public Usuarios(string datosUsuario)
        {
            InitializeComponent();
            this.datosUsuario = datosUsuario;
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            //Muestra "Cargando usuarios" y despues inicio como subproceso la carga de Usuarios logueados
            this.richTextBox1.Font = new Font(this.richTextBox1.Font, FontStyle.Bold);
            this.richTextBox1.Text = "Cargando usuarios...";
            //Inicio el hilo llamando a CambiarLabel
            this.task = Task.Run(() => this.CambiarTexto());
        }
        private void CambiarTexto()
        {
            try
            {
                //Si se invoco al richTextBox1 entra
                if (this.richTextBox1.InvokeRequired)
                {
                    //Espera 3 segundos
                    Thread.Sleep(3000);
                    //Creo el delegado que tambien llama a cambiar texto
                    DelegadoUsuarios delegadoUsuarios = new DelegadoUsuarios(this.CambiarTexto);

                    //invoco a ese delegado
                    this.richTextBox1.Invoke(delegadoUsuarios);
                }
                else
                {
                    //Como ya se invoco al richTextBox1 no entra al if y muestra los datos del usuario
                    this.richTextBox1.Font = new Font(this.richTextBox1.Font, FontStyle.Regular);
                    this.richTextBox1.Text = this.datosUsuario;
                }
            }
            catch (Exception e)
            {
            }

        }

        private void Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            //No me deja cerrar el form hasta que el subproceso no haya finalizado
            if(!this.task.IsCompleted)
            {
                e.Cancel = true;
                MessageBox.Show("Espere a que la carga de usuarios se complete", "No se puede cerrar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}